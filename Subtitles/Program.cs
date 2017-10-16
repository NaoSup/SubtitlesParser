using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subtitles
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            Parser MrRobot = new Parser();
            MrRobot.FileRecovery(@"C:\Users\npaul\Desktop\Mr.Robot.st.txt");

           
            sw.Stop();
            //Console.WriteLine(sw.Elapsed);

            Console.Read();
        }
    }
}
