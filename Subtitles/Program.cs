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
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            MrRobot.FileRecovery(path + @"\Mr.Robot.st.txt");

           
            sw.Stop();
            //Console.WriteLine(sw.Elapsed);

            Console.Read();
        }
    }
}
