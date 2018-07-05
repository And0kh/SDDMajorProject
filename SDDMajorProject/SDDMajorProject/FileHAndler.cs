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
        public static void Read(string Event){
            //gets the path with the name of the executable in it
            //string path = System.Reflection.Assembly.GetEntryAssembly().Location;

            //Gets the name of the folder the executbale is in(help from https://dailydotnettips.com/different-ways-of-getting-path/)
            string ExePath = AppDomain.CurrentDomain.BaseDirectory;
            string EvntsPth = ExePath;
            Console.WriteLine("Current directory:" + ExePath);
            string FlPth = "";
            string FlText = "";

            //Check if the "Events" folder is in the same location as the executable
            if (Directory.Exists(Path.Combine(ExePath, "Events"))){ //Creating a new directory https://msdn.microsoft.com/en-us/library/system.io.path.combine.aspx
                EvntsPth = Path.Combine(ExePath, "Events");//Creates a string which the events folder directory
                Console.WriteLine("Loading event details from "+ EvntsPth);
                FlPth = Path.Combine(EvntsPth, Event, @".txt");//Creates a string with the relevent txt file's directory path
                FlText = System.IO.File.ReadAllText(FlPth);//Reads in the events from the relevent file
                Console.WriteLine(FlText);//For testing purposes
            }else{
                Console.WriteLine("Events folder not located in " + ExePath + "\nTrying a different location.");

                //Checks to see if the "Events" folder is in the visual studio solution folder
                //This is mainly used during the development process
                EvntsPth = Path.GetFullPath(Path.Combine(ExePath, @"..\..\"));//Goes up two levels/directories
                Console.WriteLine("Trying in " + EvntsPth);
                if (Directory.Exists(Path.Combine(EvntsPth, "Events"))){//Checks to see if the "Events" folder is present
                    EvntsPth = Path.Combine(ExePath, "Events");//Creates a string with the directory path
                    Console.WriteLine("Loading event details from " + EvntsPth);//For testing purposes
                    FlPth = Path.Combine(EvntsPth, Event, @".txt");//Creates a string with the relevent txt file's directory path
                    FlText = System.IO.File.ReadAllText(FlPth);//Reads in the events from the relevent file
                    Console.WriteLine(FlText);//For testing purposes
                }
            }

        }

        //string path = @"W:\Visual Studio 2017\SDDMajorProject\SDDMajorProject\SDDMajorProject\Events\" + Event + ".txt";
        //string text = System.IO.File.ReadAllText(path);

        static void Write(){

        }
    }
}
