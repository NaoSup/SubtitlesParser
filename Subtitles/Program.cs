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
            Parser MrRobot = new Parser();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            MrRobot.FileRecovery(path + @"\MrRobot-trailer.txt");
            MrRobot.DisplaySubtitles();
            Console.Read();
        }
    }
}
