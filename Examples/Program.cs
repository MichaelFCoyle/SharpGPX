using SharpGPX;
using SharpGPX.GPX1_1;
using System;
using System.Security.Principal;

namespace Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ReadAndPrint("Files\\All Buntzen Trails.gpx");
                ReadAndPrint("Files\\Buntzen Waypoints.gpx");

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
                    lat = (Decimal)49.3402360,
                    lon = (Decimal)(-122.8770030),
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

            Console.WriteLine("Waypoints: {0}");
            gpx.Waypoints.ForEach(x => Console.WriteLine("\tWaypoint: {0}\r\n", x.name));
            Console.WriteLine("Routes:");
            gpx.Routes.ForEach(x => Console.WriteLine("\tRoute: {0}\r\n", x.name));
            Console.WriteLine("Routes:");
            gpx.Tracks.ForEach(x => Console.WriteLine("\tTrack: {0}\r\n", x.name));
        }

        private static void CreateTrack()
        {

            GpxClass track = new GpxClass()
            {
                Metadata = new metadataType()
                {
                    author = new personType() { name = WindowsIdentity.GetCurrent().Name },
                    link = new linkTypeCollection().AddLink(new linkType() { href = "www.BlueToque.ca", text = "Blue Toque Software" })
                },
                Tracks = new trkTypeCollection()
            };

            track.Tracks.Add(new trkType()
            {
                name = "11-AUG-11 18:18:27",
                trkseg = new trksegTypeCollection().Addtrkseg(
                    new trksegType()
                    {
                        trkpt = new wptTypeCollection()
                            .Addwpt(new wptType()
                            {
                                lat = (Decimal)49.706482,
                                lon = (Decimal)(-123.111961),
                                ele = (Decimal)38.11,
                                eleSpecified = true,
                            })
                            .Addwpt(new wptType()
                            {
                                lat = (Decimal)49.706417,
                                lon = (Decimal)(-123.112190),
                                ele = (Decimal)38.11,
                                eleSpecified = true,
                            })
                            .Addwpt(new wptType()
                            {
                                lat = (Decimal)49.706348,
                                lon = (Decimal)(-123.112495),
                                ele = (Decimal)76.08,
                                eleSpecified = true,
                            })
                            .Addwpt(new wptType()
                            {
                                lat = (Decimal)49.706242,
                                lon = (Decimal)(-123.111961),
                                ele = (Decimal)74.16,
                                eleSpecified = true,
                            })
                            .Addwpt(new wptType()
                            {
                                lat = (Decimal)49.705872,
                                lon = (Decimal)(-123.111961),
                                ele = (Decimal)38.11,
                                eleSpecified = true,
                            })
                    })
            });

            track.ToFile("Test2.gpx");
        }
    }
}