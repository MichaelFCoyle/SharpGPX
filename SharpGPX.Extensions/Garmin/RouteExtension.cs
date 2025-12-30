using System.Drawing;
using System.Xml.Serialization;

namespace SharpGPX.Extensions.Garmin
{
    public partial class RouteExtension
    {
        [XmlIgnore]
        public Color Color => this.DisplayColor.ToWindowsColor();
    }
}
