using System;
using System.Xml.Serialization;

namespace SharpGPX.GPX1_1
{
    /// <summary>
    /// Bounds
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Xml Serialization Name")]
    [System.Diagnostics.DebuggerDisplay("Bounds {maxlat},{maxlon},{minlat},{minlon}")]
    public partial class boundsType
    {
        public boundsType() { }

        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="other"></param>
        public boundsType(boundsType other)
        {
            if (other == null) return;
            minlat = other.minlat;
            maxlat = other.maxlat;
            minlon = other.minlon;
            maxlon = other.maxlon;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="minlat"></param>
        /// <param name="maxlat"></param>
        /// <param name="minlon"></param>
        /// <param name="maxlon"></param>
        public boundsType(decimal minlat, decimal maxlat, decimal minlon, decimal maxlon)
        {
            this.minlat = minlat;
            this.maxlat = maxlat;
            this.minlon = minlon;
            this.maxlon = maxlon;
        }

        /// <summary>
        /// Make a union of this bounds and the given bounds
        /// </summary>
        /// <returns></returns>
        public boundsType Union(boundsType other)
        {
            if (other == null || other.IsEmpty()) return this;
            if (IsEmpty()) return other;

            maxlat = Math.Max(maxlat, other.maxlat);
            maxlon = Math.Max(maxlon, other.maxlon);
            minlat = Math.Min(minlat, other.minlat);
            minlon = Math.Min(minlon, other.minlon);

            return this;
        }

        /// <summary>
        /// Is this an empty bounds
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty() =>
            maxlat == decimal.Zero &&
            minlat == decimal.Zero &&
            maxlon == decimal.Zero &&
            minlon == decimal.Zero;

        [XmlIgnore]
        public decimal Width => maxlon - minlon;

        [XmlIgnore]
        public decimal Height => maxlat - minlat;
    }

}
