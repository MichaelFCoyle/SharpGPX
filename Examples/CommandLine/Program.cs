using System;

namespace Examples
{
    class Program
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "<Pending>")]
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

                //}

                Utility.Examples.TestUTF8();

                Utility.Examples.TestGarminExtensions();

                Issues();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error processing file:\r\n{0}", ex);
            }
        }

        public static void Issues()
        {
            new Utility.Issues.Issue8().Execute();
            new Utility.Issues.Issue9().Execute();
            new Utility.Issues.Issue10().Execute();
        }
    }
}