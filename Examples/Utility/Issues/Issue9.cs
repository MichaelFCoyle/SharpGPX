using SharpGPX;

namespace Utility.Issues
{
    public class Issue9
    {
        public bool Execute()
        {
            GpxClass gpx = new GpxClass();
            gpx.Waypoints.Add(new SharpGPX.GPX1_1.wptType()
            {
                name = "1",
                lat = 49,
                lon = -123,
                ele = 100
            });

            gpx.Waypoints.Add(new SharpGPX.GPX1_1.wptType()
            {
                name = "2",
                lat = 49,
                lon = -123,
            });

            _ = gpx.ToXml();

            return true;
        }
    }
}
