using System;
using System.Xml.Serialization;

namespace SharpGPX.GPX1_1
{
    /// <summary>
    /// Waypoint
    /// 
    /// Note the fields in this class that have "specified" fields.
    /// 
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Xml Serialization Name")]
    [System.Diagnostics.DebuggerDisplay("{DebuggerDisplay, nq}")]
    public partial class wptType
    {
        public wptType()
        {
            timeSpecified = false;
            eleSpecified = false;
            ele = NULL_ELE;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        /// <param name="elevation"></param>
        /// <param name="dateTime"></param>
        public wptType(double latitude, double longitude, double? elevation = null, DateTime? dateTime = null) : this()
        {
            lat = (decimal)latitude;
            lon = (decimal)longitude;

            timeSpecified = dateTime.HasValue;
            if (dateTime.HasValue)
                time = dateTime.Value;

            eleSpecified = elevation.HasValue;
            if (elevation.HasValue)
                ele = (decimal)elevation.Value;
        }

        public static decimal NULL_ELE = -99999;

        internal void Preserialize()
        {
            if (time == DateTime.MinValue)
                timeSpecified = false;

            if (!eleSpecified)
                eleSpecified = (ele != NULL_ELE);

            if (extensions != null && extensions.Count == 0)
                extensions = null;
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never), System.ComponentModel.Browsable(false)]
        [XmlIgnore]
        internal string DebuggerDisplay => (ele == NULL_ELE) ? $"{lat}, {lon}" : $"{lat}, {lon}, {ele}m";

    }

}
