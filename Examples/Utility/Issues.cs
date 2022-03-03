using SharpGPX;

namespace Utility
{
    public static class Issues
    {
        public static bool Execute()
        {
            return Issue9();
        }

        public static bool Issue9()
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
