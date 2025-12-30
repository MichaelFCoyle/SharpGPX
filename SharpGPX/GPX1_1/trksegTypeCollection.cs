using System.Collections.Generic;

namespace SharpGPX.GPX1_1
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Xml Serialization Name")]
    public partial class trksegTypeCollection
    {
        public trksegTypeCollection() { }

        public trksegTypeCollection(IEnumerable<trksegType> collection) : base(collection) { }

        /// <summary>
        /// Get a boundsType that represents the bounds of this data
        /// </summary>
        /// <returns></returns>
        public boundsType GetBounds()
        {
            boundsType bounds = new();
            foreach (var trkSeg in this)
                bounds = trkSeg.trkpt.GetBounds().Union(bounds);
            return bounds;
        }

        internal void Preserialize() => ForEach(x => x.Preserialize());
    }

}
