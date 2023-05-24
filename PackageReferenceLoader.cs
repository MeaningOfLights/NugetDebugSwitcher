namespace NuGetDebugSwitcher;

using System.Collections.Generic;
using Buildalyzer;
using NuGetDebugSwitcher.ProjectStyles;

public class PackageReferenceLoader
{
    public PackageReferenceLoader()
    {
    }

    public HashSet<PackageReferenceInfo> LoadPackageReferences(IEnumerable<ProjectAnalyzer> projects)
    {
        var results = new HashSet<PackageReferenceInfo>();

        foreach (var project in projects)
        {
         
            var projectStyle = ProjectStyle.Create(project);
            var projectPackages = projectStyle.LoadPackageReferences();
            
            results.UnionWith(projectPackages);
        }

        return results;
    }
    
}