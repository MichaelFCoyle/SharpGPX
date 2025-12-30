using System;

namespace Utility.Issues
{
    public class Issue8
    {
        public bool Execute()
        {
            try
            {
                Console.Write(Examples.ReadAndPrint("Files\\Issue #8 RoutePointExtension.gpx"));
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());   
                return false;
            }
        }
    }
}
