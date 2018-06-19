using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.IO;
using System.Threading.Tasks;

namespace SDDMajorProject
{
    class FileHandler
    {
        public static void Read(string Event)
        {
            //string path = @"W:\Visual Studio 2017\SDDMajorProject\SDDMajorProject\SDDMajorProject\Events\"+ Event +".txt";
            //string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Data\Names.txt");
            string path = System.Reflection.Assembly.GetEntryAssembly().Location;
            if (path.GetDirectories)
            string text = System.IO.File.ReadAllText(path);
            Console.WriteLine(path);
        }

        static void Write()
        {

        }
    }
}
