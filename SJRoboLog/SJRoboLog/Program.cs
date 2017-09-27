using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;
using System.Runtime.InteropServices;


namespace SJRoboLog
{
    class Program
    {
        const int SWP_NOSIZE = 0x0001;

        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GetConsoleWindow();

        private static IntPtr MyConsole = GetConsoleWindow();

        [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
        public static extern IntPtr SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int x, int y, int cx, int cy, int wFlags);

        static void Main(string[] args)
        {
            using (var log = new EventLog("Application"))
            {

                int xpos = 300;                
                int width = 500;
                int height = 500;
                //Console.WriteLine("length = "+ args.Length.ToString());
                if (args.Length == 2)
                {
                    
                    width = int.Parse(args[0].ToString());
                    height = int.Parse(args[1].ToString());

                    Console.WriteLine("Width = " + width + "  Height = " + height);

                    if (width < 500)
                    {
                        xpos = 300;
                        width = 500;
                    }
                    if (height < 500)
                    {                    
                        height = 500;
                    }
                    xpos = width - 600;                    
                }

                SetWindowPos(MyConsole, 0, xpos, 0, 0, 0, SWP_NOSIZE);
                Console.SetWindowSize(70, 50);
                log.EnableRaisingEvents = true;
                log.EntryWritten += DisplayEntry;
                Console.ReadLine();
            }
        }

        static void DisplayEntry(object sender, EntryWrittenEventArgs e)
        {
            EventLogEntry entry = e.Entry;
            Console.WriteLine(entry.Message);
        }
    }
}
