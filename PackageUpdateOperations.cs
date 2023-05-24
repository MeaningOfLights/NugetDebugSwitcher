// Copyright (c) 2023 Jeremy Lecky-Thompson. All rights reserved.
// This code is proprietary and may not be used without permission.

namespace NuGetDebugSwitcher;

using System.Text;
using System.Text.RegularExpressions;

public class PackageUpdateOperations
{
    
    // PLAN for improvement

    // 0. Automate the build process with tagging.
    
    // 1. Ensure the Main branches dont have pending files
    // 2. Ensure the Main branches are up to date
    // 3. Ensure the Main branches are clean
    // 4. Ensure the Main branches are not ahead of the remote
    // 5. Ensure the Main branches are not behind the remote
    // 6. Ensure the Main branches are not diverged from the remote
    // 7. Ensure the Main branches are not in a conflicted state
    // 8. Ensure the Main branches are not in a detached HEAD state
    // 9. Ensure the Main branches are not in a merge state
    // 10. Ensure the Main branches are not in a rebase state

    // 11. Check out a new branch called BaseVersionUpdate
    // 12. Update the version of the package in the projects and save csproj files
    // 13. Commit the changes
    // 14. Push the changes
    // 15. Create a PR
    // 16. Merge the PR
    // 17. Kick off a build
    // 18. Delete the branch
    // 19. Check out the Main branch
    // 20. Get Latest on Main

    public string UpdatePackages(string utitltiesDirPath, string sourcePackage, Version targetVersion)
    {
        List<string> sourceFiles = Directory.EnumerateFiles(utitltiesDirPath, "*.csproj", SearchOption.AllDirectories).ToList();
        StringBuilder sb = new();
        foreach (string file in sourceFiles)
        {
            string pattern = @"<PackageReference\s+Include=""(\S+)""\s+Version=""(\S+)""\s*/>";
            Regex regex = new Regex(pattern);

            foreach (string line in File.ReadAllLines(file))
            {
                Match match = regex.Match(line);
                if (match.Success)
                {
                    string packageName = match.Groups[1].Value;
                    if (packageName == sourcePackage)
                    {
                        string packageVersionString = match.Groups[2].Value;
                        Version packageVersion = new Version(packageVersionString);
                        if (packageVersion < targetVersion)
                        {
                            sb.AppendLine("Updated " + Path.GetFileName(file) + " from version: " + packageVersionString + " to version " + targetVersion.ToString());
                            string fileContent = File.ReadAllText(file);
                            // Package reference found with newer version
                            string newLine = line.Replace(packageVersionString, targetVersion.ToString());
                            fileContent = fileContent.Replace(line, newLine);
                            File.WriteAllText(file, fileContent, Encoding.UTF8);
                            break;
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
}