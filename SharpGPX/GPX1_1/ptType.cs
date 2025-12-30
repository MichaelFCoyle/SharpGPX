using System;
using System.Xml.Serialization;

namespace SharpGPX.GPX1_1
{
    /// <summary>
    /// Point
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Xml Serialization Name")]
    [System.Diagnostics.DebuggerDisplay("{DebuggerDisplay, nq}")]
    public partial class ptType
    {
        public ptType()
        {
            timeSpecified = false;
            eleSpecified = false;
            ele = NULL_ELE;
        }

        public static decimal NULL_ELE = -99999;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        /// <param name="elevation"></param>
        /// <param name="dateTime"></param>
        public ptType(double latitude, double longitude, double? elevation = null, DateTime? dateTime = null) : this()
        {
            lat = (decimal)latitude;
            lon = (decimal)longitude;
            eleSpecified = false;

            timeSpecified = dateTime.HasValue;
            if (dateTime.HasValue)
                time = dateTime.Value;

            eleSpecified = elevation.HasValue;
            if (elevation.HasValue)
                ele = (decimal)elevation.Value;
        }

        internal void Preserialize()
        {
            if (time == DateTime.MinValue)
                timeSpecified = false;

            if (!eleSpecified)
                eleSpecified = (ele != NULL_ELE);
        }

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never), System.ComponentModel.Browsable(false)]
        [XmlIgnore]
        internal string DebuggerDisplay => (ele == NULL_ELE) ? $"{lat}, {lon}" : $"{lat}, {lon}, {ele}m";
    }


}
