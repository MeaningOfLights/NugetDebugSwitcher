// This code is from Buildalyzer

using Buildalyzer;

namespace NuGetDebugSwitcher
{
    public class WorkspaceLoader
    {
        public IEnumerable<ProjectAnalyzer> LoadProjects(string filePath, bool isSolution)
        {
            var analyzerManager = (isSolution 
                ? new AnalyzerManager(filePath) 
                : new AnalyzerManager());

            if (isSolution)
            {
                return (IEnumerable<ProjectAnalyzer>)analyzerManager.Projects.Values;
            }
            else
            {
                var project = analyzerManager.GetProject(filePath);
                return new[] { (ProjectAnalyzer)project };
            }
        }
    }
}