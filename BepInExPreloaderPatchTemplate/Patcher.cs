using Mono.Cecil;
using System.Collections.Generic;

namespace BepInExPreloaderPatchTemplate
{
    public static class Patcher
    {
        public static IEnumerable<string> TargetDLLs { get; } = new[] { "Assembly-CSharp.dll" };

        public static void Initialize()
        {

        }

        public static void Finish()
        {

        }

        public static void Patch(AssemblyDefinition assembly)
        {

        }
    }
}
