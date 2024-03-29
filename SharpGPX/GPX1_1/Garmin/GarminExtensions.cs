﻿using System.Drawing;
using System.Xml.Serialization;

namespace SharpGPX.GPX1_1.Garmin
{
    public static class GarminExtensions
    {
        internal static Color ConvertColor(DisplayColor_t colorEnum)
        {
            switch (colorEnum)
            {
                case DisplayColor_t.Black: return Color.Black;
                case DisplayColor_t.Blue: return Color.Blue;
                case DisplayColor_t.Cyan: return Color.Cyan;
                case DisplayColor_t.DarkBlue: return Color.DarkBlue;
                case DisplayColor_t.DarkCyan: return Color.DarkCyan;
                case DisplayColor_t.DarkGray: return Color.DarkGray;
                case DisplayColor_t.DarkGreen: return Color.DarkGreen;
                case DisplayColor_t.DarkMagenta: return Color.DarkMagenta;
                case DisplayColor_t.DarkRed: return Color.DarkRed;
                case DisplayColor_t.DarkYellow: return Color.DarkGoldenrod;
                case DisplayColor_t.Green: return Color.Green;
                case DisplayColor_t.LightGray: return Color.LightGray;
                case DisplayColor_t.Magenta: return Color.Magenta;
                case DisplayColor_t.Red: return Color.Red;
                case DisplayColor_t.Transparent: return Color.Transparent;
                case DisplayColor_t.White: return Color.White;
                case DisplayColor_t.Yellow: return Color.Yellow;
                default: return Color.Black;
            }
        }
    }

    public interface IPointExtension { }

    public partial class WaypointExtension : IPointExtension { }

    public partial class RoutePointExtension : IPointExtension { }

    public partial class TrackPointExtension : IPointExtension { }

    public partial class TrackExtension
    {
        [XmlIgnore]
        public Color Color => GarminExtensions.ConvertColor(DisplayColor);
    }

    public partial class RouteExtension
    {
        [XmlIgnore]
        public Color Color => GarminExtensions.ConvertColor(DisplayColor);
    }

}
