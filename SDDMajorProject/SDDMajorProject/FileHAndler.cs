using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace SDDMajorProject
{
    class FileHandler
    {
        public static void Read(string Event)
        {
            //gets the path with the name of the executable in it
            //string path = System.Reflection.Assembly.GetEntryAssembly().Location;

            //Gets the name of the folder the executbale is in(help from https://dailydotnettips.com/different-ways-of-getting-path/)
            string ExePath = AppDomain.CurrentDomain.BaseDirectory;
            string EvntsPth;
            Console.WriteLine("Current directory:" + ExePath);

            //Check if the events folder is in the same location as the executable
            if (Directory.Exists(ExePath + "\\Events")){
                EvntsPth = ExePath + "\\Events";
                Console.WriteLine(EvntsPth);
            }else{
                Console.WriteLine("Events folder not located in " + EvntsPth);
            }
        }

        static void Write()
        {

        }
    }
}
