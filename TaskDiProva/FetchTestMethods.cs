using System.Linq;
using System.Reflection;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using NUnit.Framework;

namespace TaskDiProva
{
    public class FetchTestMethods : Task
    {
        [Output]
        public string[] TestMethods { get; set; }

        [Required]
        public string AssemblyFile { get; set; }

        [Required]
        public string TypeFullName { get; set; }

        public override bool Execute()
        {
            TestMethods = Assembly.LoadFile(AssemblyFile)
                .GetType(TypeFullName)
                .GetMethods()
                .Where(x => x.GetCustomAttributes(typeof (TestAttribute), true).Any())
                .Select(x => x.Name)
                .ToArray();
            
            return true;
        }
    }
}