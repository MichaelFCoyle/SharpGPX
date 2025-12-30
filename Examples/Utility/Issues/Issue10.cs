using SharpGPX;
using System;

namespace Utility.Issues
{
    public class Issue10
    {

        public bool Execute()
        {
            GpxClass gpx = GpxClass.FromFile("Files\\Issue #10 TripExtensionsv1.gpx");
            Console.WriteLine(gpx.Print());
            return true;
        }
    }
}
