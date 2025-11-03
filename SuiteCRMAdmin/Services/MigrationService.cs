using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace SuiteCRMAdmin.Services
{
    public class MigrationService
    {
        public bool GenerateAndApplyMigration(string migrationName, string projectPath, string contextName)
        {
            // Generate migration
            var generateProcess = Process.Start(new ProcessStartInfo
            {
                FileName = "dotnet",
                Arguments = $"ef migrations add {migrationName} --project {projectPath} --context {contextName}",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            });
            if (generateProcess != null)
            {
                generateProcess.WaitForExit();
                if (generateProcess.ExitCode != 0) return false;
            }
            else
            {
                return false;
            }

            // Apply migration
            var updateProcess = Process.Start(new ProcessStartInfo
            {
                FileName = "dotnet",
                Arguments = $"ef database update --project {projectPath} --context {contextName}",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            });
            if (updateProcess != null)
            {
                updateProcess.WaitForExit();
                return updateProcess.ExitCode == 0;
            }
            else
            {
                return false;
            }
        }
    }
}
