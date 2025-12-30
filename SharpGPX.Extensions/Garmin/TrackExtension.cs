using System.Drawing;
using System.Xml.Serialization;

namespace SharpGPX.Extensions.Garmin
{
    public partial class TrackExtension
    {
        [XmlIgnore]
        public Color Color => this.DisplayColor.ToWindowsColor();
    }
}
