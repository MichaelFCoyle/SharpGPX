using System.Collections.Generic;

namespace SharpGPX.GPX1_1
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Xml Serialization Name")]
    public partial class linkTypeCollection
    {
        public linkTypeCollection() { }

        public linkTypeCollection(IEnumerable<linkType> collection) : base(collection) { }

        internal void Preserialize() => ForEach(x => x.Preserialize());
    }
}
