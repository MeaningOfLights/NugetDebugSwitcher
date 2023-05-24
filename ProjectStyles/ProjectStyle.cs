namespace NuGetDebugSwitcher.ProjectStyles;

using System;
using System.Collections.Generic;
using System.Xml.Linq;
using Buildalyzer;

public abstract class ProjectStyle
{
    public const string MsbuildNamespaceUri = "http://schemas.microsoft.com/developer/msbuild/2003";
    
    protected ProjectStyle(ProjectAnalyzer project, XElement projectXml)
    {
        this.Project = project;
        this.ProjectXml = projectXml;
    }

    public abstract IEnumerable<PackageReferenceInfo> LoadPackageReferences();
    

    protected ProjectAnalyzer Project { get; }

    protected XElement ProjectXml { get; }

    public static ProjectStyle Create(ProjectAnalyzer project)
    {
        var projectXml = XElement.Load(project.ProjectFile.Path);

        var isSdkStyle = SdkProjectStyle.IsSdkStyleProject(projectXml);
        var isOldStyle = OldProjectStyle.IsOldStyleProject(projectXml);

        if (isSdkStyle && !isOldStyle)
        {
            return new SdkProjectStyle(project, projectXml);
        }

        if (isOldStyle && !isSdkStyle)
        {
            return new OldProjectStyle(project, projectXml);
        }
            
        throw new Exception($"Error: could not recognize project style: {project.ProjectFile.Path}");
    }
}