using System.Linq;
using System.Reflection;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using NUnit.Framework;

namespace TaskDiProva
{
    public class FetchTestClasses : Task
    {
        [Output]
        public string[] TestClasses { get; set; }

        [Required]
        public string AssemblyFile { get; set; }

        public override bool Execute()
        {
            TestClasses = Assembly.LoadFrom(AssemblyFile)
                .GetTypes()
                .Where(x => x.GetCustomAttributes(typeof (TestFixtureAttribute), true).Any())
                .Select(x => x.FullName)
                .ToArray();
                
            return true;
        }
    }
}
