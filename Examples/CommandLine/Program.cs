using SharpGPX;
using SharpGPX.GPX1_1;
using System;
using System.Linq;
using System.Security.Principal;
using Utility;

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
                    ReadAndPrint(args[0]);
                }
                else
                {
                    ReadAndPrint("Files\\All Buntzen Trails.gpx");
                    ReadAndPrint("Files\\Buntzen Waypoints.gpx");
                    ReadAndPrint("Files\\Burnaby Walk.gpx");
                }

                // create a new file
                GpxClass newGpx = new GpxClass()
                {
                    Creator = WindowsIdentity.GetCurrent().Name,
                    Version = "Test",
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

                CreateTrack();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error processing file:\r\n{0}", ex);
            }
        }

        private static void ReadAndPrint(string fileName)
        {
            Console.WriteLine("File Name: {0}", fileName);
            // read a file
            GpxClass gpx = GpxClass.FromFile(fileName);

            Console.WriteLine("{0} elements total", gpx.CountElements());

            Console.WriteLine("Waypoints: {0}", gpx.Waypoints.Count);
            gpx.Waypoints.ForEach(x => Console.WriteLine("\tWaypoint: {0}", x.name));
            Console.WriteLine("Routes: {0}", gpx.Routes.Count);
            gpx.Routes.ForEach(x => Console.WriteLine("\tRoute: {0}, {1} points", x.name, x.rtept.Count));
            Console.WriteLine("Tracks: {0}", gpx.Tracks.Count);
            gpx.Tracks.ForEach(x => Console.WriteLine("\tTrack: {0}, {1} segments", x.name, x.trkseg.Count));

            foreach(var track in gpx.Tracks)
            {
                var garminExt = track.GetGarminExt();
                if(garminExt!=null) 
                    Console.WriteLine("Track {0} has Garmin extension", track.name );
                var color = garminExt?.Color;
                var lineExt = track.GetTopografixLine();
                if (lineExt != null) Console.WriteLine("Track {0} has Topografix extension", track.name);

            }
        }

        private static void CreateTrack()
        {
            //GpxClass track = Examples.CreateTrack();
            //track.ToFile("Test2.gpx");
        }
    }
}