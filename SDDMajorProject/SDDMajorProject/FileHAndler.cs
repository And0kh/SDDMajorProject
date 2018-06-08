using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDDMajorProject
{
    class FileHandler
    {
        public static void Read(/*string Event*/)
        {
            string text = System.IO.File.ReadAllText(@"W:\");
            Console.WriteLine(text);
        }

        static void Write()
        {

        }
    }
}
