

namespace ps4
{
    using System.Runtime.InteropServices;
    using System.Windows.Forms;
    using System.Threading;
    using System.Diagnostics;
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Checking For PS4 using WIFI");
           DialogResult dialogResult = MessageBox.Show("Do you want PS4 Rift Installer to access WI-FI? ", "Windows Security", MessageBoxButtons.YesNo);
            
           if(dialogResult == DialogResult.Yes)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Accessing WI-FI");
                Thread.Sleep(3000);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Checking for ps4.");
                Thread.Sleep(3000);
                Console.Clear();
                Console.WriteLine("Checking for ps4..");
                Thread.Sleep(3000);
                Console.Clear();
                Console.WriteLine("Checking for ps4...");
                Thread.Sleep(3000);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("PS4 Found!");
                Thread.Sleep(3000);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Injecting rift into ps4.");
                Thread.Sleep(3000);
                Console.Clear();
                Console.WriteLine("Injecting rift into ps4..");
                Thread.Sleep(3000);
                Console.Clear();
                Console.WriteLine("Injecting rift into ps4...");
                Thread.Sleep(3000);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Injected! Have fun with rift!");
                Thread.Sleep(2000);
                Process myProcess = new Process();
                myProcess.StartInfo.UseShellExecute = true;
                myProcess.StartInfo.FileName = "https://www.youtube.com/watch?v=dQw4w9WgXcQ&";
                myProcess.Start();


            }

        }
    }
}



