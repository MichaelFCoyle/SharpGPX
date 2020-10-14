using System.IO;
using System.Reflection;

namespace SharpGPX
{
    static class ResourceHelper
    {
        internal static Stream GetStream(string name)
        {
            var assembly = typeof(ResourceHelper).GetTypeInfo().Assembly;
            return assembly.GetManifestResourceStream($"MyLibrary._fonts.{name}");
        }

        internal static string GetText(string name)
        {
            using (var streamReader =new StreamReader( GetStream(name)))
                return streamReader.ReadToEnd();
        }
    }
}
