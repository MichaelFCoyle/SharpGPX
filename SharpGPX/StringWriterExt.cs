using System.IO;
using System.Text;

namespace SharpGPX
{
    sealed class StringWriterExt : StringWriter
    {
        public StringWriterExt(Encoding desiredEncoding) : base() => Encoding = desiredEncoding;

        public override Encoding Encoding { get; }
    }

}
