using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace SDDMajorProject
{
    public class FileHandler
    {
        public static string[] FlText;

        public static void FilePresent(){
            string ExePath;
        }

        public static void Read(string Event){
            //gets the path with the name of the executable in it
            //string path = System.Reflection.Assembly.GetEntryAssembly().Location;

            //Gets the name of the folder the executbale is in(help from https://dailydotnettips.com/different-ways-of-getting-path/)
            string ExePath = AppDomain.CurrentDomain.BaseDirectory;
            string EvntsPth = Path.Combine(ExePath, "Events");//Creating a new directory https://msdn.microsoft.com/en-us/library/system.io.path.combine.aspx
            Console.WriteLine("Current directory:" + ExePath);
            string FlPth = "";
            //string FlText = "";

            //Check if the "Events" folder is in the same location as the executable
            if (Directory.Exists(EvntsPth)){
                Console.WriteLine("Checking in " + EvntsPth);
                Console.WriteLine("Loading event details from "+ EvntsPth);
                FlPth = Path.Combine(EvntsPth, (Event + @".txt"));//Creates a string with the relevent txt file's directory path
                if (File.Exists(FlPth)){
                    FileHandler.FlText = File.ReadLines(FlPth).ToArray();//Reads in the events from the relevent file
                    Console.WriteLine(FlText + "\nLoaded contents");//For testing purposes
                }
                else
                {
                    MessageBox.Show("Could not load events file.");
                }
            }
            else{
                Console.WriteLine("Events folder not located in " + ExePath + "\nTrying a different location.");

                //Checks to see if the "Events" folder is in the visual studio solution folder
                //This is mainly used during the development process
                EvntsPth = Path.GetFullPath(Path.Combine(ExePath, @"..\..\"));//Goes up two levels/directories
                Console.WriteLine("Trying in " + EvntsPth);
                EvntsPth = Path.Combine(EvntsPth, "Events");

                if (Directory.Exists(EvntsPth)){ //Checks to see if the "Events" folder is present
                    Console.WriteLine("Loading event details from " + EvntsPth);//For testing purposes
                    FlPth = Path.Combine(EvntsPth, (Event + @".txt"));//Creates a string with the relevent txt file's directory path

                    if (File.Exists(FlPth)){
                        FlText = File.ReadLines(FlPth).ToArray();//Reads in the events from the relevent file
                        Console.WriteLine(FlText + "\nLoaded contents");//For testing purposes
                    }
                    else
                    {
                        Console.WriteLine("Relevent .txt file not prsent.");
                    }

                }
                else{
                    MessageBox.Show("Could not load events file.");
                }
            }

        }

        //string path = @"W:\Visual Studio 2017\SDDMajorProject\SDDMajorProject\SDDMajorProject\Events\" + Event + ".txt";
        //string text = System.IO.File.ReadAllText(path);

        static void Write(){

        }

        public static void ChangeEvents(string events){
            //cmboBxEvnts.Items.Add(events);
            ComboBox cmboBxEvnts = new ComboBox();
            System.Object[] ItemObject = new System.Object[10];
            for (int i = 0; i <= 9; i++)
            {
                ItemObject[i] = "Item" + i;
            }
            cmboBxEvnts.Items.AddRange(ItemObject);
        }
    }
}
