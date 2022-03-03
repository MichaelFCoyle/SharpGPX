using SharpGPX;
using SharpGPX.GPX1_1;
using System;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Xml;
using Utility;

namespace Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //if (args.Count() != 0)
                //{
                //    Utility.Examples.ReadAndPrint(args[0]);
                //}
                //else
                //{
                //    Utility.Examples.CopyGpxFile("Files\\All Buntzen Trails.gpx");

                //    Utility.Examples.ReadAndPrint("Files\\All Buntzen Trails.gpx");
                //    Utility.Examples.ReadAndPrint("Files\\Buntzen Waypoints.gpx");
                //    Utility.Examples.ReadAndPrint("Files\\Burnaby Walk.gpx");

                    Utility.Examples.ReadAndPrint("Files\\Issue #8 RoutePointExtension.gpx");
                //}

                Utility.Examples.TestUTF8();

                Utility.Examples.TestGarminExtensions();

                Issues.Execute();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error processing file:\r\n{0}", ex);
            }
        }
    }
}