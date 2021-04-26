using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace omni
{
    class Program
    {
        static void Main(string[] args)
        {
            if(!Directory.Exists("C:\\omni\\"))
            {
                Directory.CreateDirectory("C:\\omni\\");
            }
            if (args.Length < 1)
            {
                Console.WriteLine("No arguments found.");
            }
            else
            {
                try
                {
                    if(args[0] == "install" && !string.IsNullOrEmpty(args[1]))
                    {
                        WebClient client = new WebClient();
                        client.DownloadFile("https://github.com/TunaOnAir/omni/raw/main/files/" + args[1] + ".exe", "C:\\omni\\"+ args[1] + ".exe");
                        Console.WriteLine("Done.");
                        Process.Start("C:\\omni\\");
                    }
                }
                catch
                {
                    Console.WriteLine("Error. Press any key to continue.");
                    Console.ReadKey();
                }
            }
        }
    }
}
