// Copyright (c) 2023 Jeremy Lecky-Thompson. All rights reserved.
// This code is proprietary and may not be used without permission.

namespace NuGetDebugSwitcher;

using System.Text;
using System.Text.RegularExpressions;

public class SymLinkOperations
{
    public string SymLink(string utitltiesDirPath, string packageToSymLink, string csProjectRefFile, Version targetVersion, bool CreateNotRemoveSymLinks = true)
    {
        List<string> symLinkedNuGetPackages = new List<string>();
        List<string> sourceFiles = Directory.EnumerateFiles(utitltiesDirPath, "*.csproj", SearchOption.AllDirectories).ToList();
        StringBuilder sb = new();
        foreach (string file in sourceFiles)
        {
            // Find Package Refs with a RegEx: <PackageReference Include="CompanyX.MS.Base.Core" Version="2.1.0" />
            string pattern = @"<PackageReference\s+Include=""(\S+)""\s+Version=""(\S+)""\s*/>";
            Regex regex = new Regex(pattern);

            foreach (string line in File.ReadAllLines(file))
            {
                Match match = regex.Match(line);
                if (match.Success)
                {

                    string packageName = match.Groups[1].Value;
                    if (packageName == packageToSymLink)
                    {
                        string packageVersionString = match.Groups[2].Value;
                        Version packageVersion = new Version(packageVersionString);
                        if (packageVersion == targetVersion)
                        {

                            var allProjects = new WorkspaceLoader().LoadProjects(file, false);
                            var referenceLoader = new PackageReferenceLoader();
                            var allPackages = referenceLoader.LoadPackageReferences(allProjects);
                            
                            // Keep a list so we only create one symlink for each nuget package version
                            if (symLinkedNuGetPackages.Contains(packageName)) continue;
                            symLinkedNuGetPackages.Add(packageName);

                            PackageReferenceInfo packageToSwitch = allPackages.FirstOrDefault(p => p.PackageId == packageName);
                            if (packageToSwitch == null) throw new Exception(packageName + " cant be found!");
                            try
                            {
                                if (!Directory.Exists(packageToSwitch.LibFolderPath))
                                {
                                    var errMsg = "The NuGet folder doesn't exist: " + packageToSwitch.LibFolderPath;
                                    MessageBox.Show(errMsg);
                                    return errMsg;
                                }
                                
                                //'Check if the user already created the NuGet Folder Backup? If so dont bother doing it again.
                                if (!Directory.Exists(packageToSwitch.LibBackupFolderPath))
                                {
                                    try
                                    {
                                        // Take a back up to be able to revert.
                                        Directory.Move(packageToSwitch.LibFolderPath, packageToSwitch.LibBackupFolderPath);
                                    }
                                    catch (DirectoryNotFoundException ex)
                                    {
                                        var errMsg = "Double check the Package Exists, try a Package Manager Console: 'dotnet restore' command and then retry! Err: " + ex.Message;
                                        MessageBox.Show(errMsg);
                                        return errMsg;
                                    }
                                    catch (IOException ex)
                                    {
                                        var errMsg = "You probably have an instance of Visual Studio open that is locking the NuGet package. Please close anything that could cause a File Lock on the NuGet Library and retry! Err: " + ex.Message;
                                        MessageBox.Show(errMsg);
                                        return errMsg;
                                    }
                                    catch (Exception ex)
                                    {
                                        var errMsg = "Unknown Err: " + ex.Message;
                                        MessageBox.Show(errMsg);
                                        return errMsg;
                                    }
                                }

                                
                                if (CreateNotRemoveSymLinks)
                                {
                                    // Didn't work, will try again another time.... run with Admin for now.
                                    // AdminElevate.RequireAdminPrivileges(() => CreateSymLinkWithAdmin(packageToSwitch.LibFolderPath, csProjectRefFile));
                                    CreateSymLinkWithAdmin(packageToSwitch.LibFolderPath, csProjectRefFile);
                                    sb.AppendLine(packageName + ": " + packageToSwitch.LibFolderPath + " -> " + csProjectRefFile);
                                }
                                else
                                {
                                    sb.AppendLine(RevertOperation(packageToSwitch));
                                    sb.AppendLine(packageName + " removed Symlink: " + packageToSwitch.LibFolderPath);
                                }
                            }
                            catch (IOException ex1)
                            {
                                var errMsg = "Oops! You need to run in Admin Mode, Err: " + ex1.Message;
                                MessageBox.Show(errMsg);
                                return errMsg;
                            }
                            catch (Exception ex1)
                            {
                                throw ex1;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }                
        }
        return sb.ToString();
    }

    public void CreateSymLinkWithAdmin(string libFolderPath, string csProjectRefFile)
    {
        SymbolicLinkWithDiagnostics.Create(fromPath: libFolderPath,toPath: csProjectRefFile);
    }

    string RevertOperation(PackageReferenceInfo packageToSwitch)
    {
        try
        {
            Directory.Delete(packageToSwitch.LibFolderPath);
            Directory.Move(packageToSwitch.LibBackupFolderPath, packageToSwitch.LibFolderPath);
            return "";
        }
        catch (Exception ex)
        {
            var errMsg = "Unknown Err while reverting back to NuGet Package: " + ex.Message;
            MessageBox.Show(errMsg);
            return errMsg;
        }
    }
}