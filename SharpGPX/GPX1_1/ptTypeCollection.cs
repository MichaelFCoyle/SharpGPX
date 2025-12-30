using System.Collections.Generic;
using System.Linq;

namespace SharpGPX.GPX1_1
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Xml Serialization Name")]
    public partial class ptTypeCollection
    {
        public ptTypeCollection() { }

        public ptTypeCollection(IEnumerable<ptType> collection) : base(collection) { }

        /// <summary>
        /// Get a boundsType that represents the bounds of this data
        /// </summary>
        /// <returns></returns>
        public boundsType GetBounds() => Count == 0 ? new boundsType() : new boundsType(this.Min(x => x.lat), this.Max(x => x.lat), this.Min(x => x.lon), this.Max(x => x.lon));

        internal void Preserialize() => ForEach(x => x.Preserialize());
    }
}
