using SharpGPX;
using SharpGPX.GPX1_1;
using System;
using System.Linq;
using System.Security.Principal;


namespace Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (args.Count() != 0)
                {
                    Utility.Examples.ReadAndPrint(args[0]);
                }
                else
                {
                    Utility.Examples.CopyGpxFile("Files\\All Buntzen Trails.gpx");

                    Utility.Examples.ReadAndPrint("Files\\All Buntzen Trails.gpx");
                    Utility.Examples.ReadAndPrint("Files\\Buntzen Waypoints.gpx");
                    Utility.Examples.ReadAndPrint("Files\\Burnaby Walk.gpx");
                }

                // create a new file
                GpxClass newGpx = new GpxClass()
                {
                    Creator = WindowsIdentity.GetCurrent().Name,
                    Waypoints = new wptTypeCollection(),
                };

                wptType waypoint = new wptType()
                {
                    name = "Test Waypoint",
                    cmt = "Comment",
                    desc = "Description",
                    lat = (decimal)49.3402360,
                    lon = (decimal)-122.8770030,
                    time = DateTime.Now,
                    timeSpecified = true,
                    sym = "Waypoint",
                };

                newGpx.Waypoints.Add(waypoint);

                newGpx.ToFile("Test.gpx");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error processing file:\r\n{0}", ex);
            }

        }
    }
}