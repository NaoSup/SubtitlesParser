using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Subtitles
{
    class Parser
    {
        public void FileRecovery(string path)
        {
            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    string ST = null;
                    TimeSpan start = TimeSpan.Parse("00:00");
                    TimeSpan stop = TimeSpan.Parse("00:00");
                    string[] split = null;
                    List<Subtitles> STs = new List<Subtitles>();


                    while ((line = reader.ReadLine()) != null)
                    {
                        Regex time = new Regex(@"^\d\d:\d\d:\d\d,\d\d\d");
                        Regex text = new Regex(@"^(-|[a-zA-Z]).+(\r\n|$)");

                        if (time.Match(line).Success)
                        {
                            split = line.Split(' ');
                            start = TimeSpan.Parse(split[0]);
                            stop = TimeSpan.Parse(split[2]);
                        }

                        if (text.Match(line).Success)
                        {
                            ST = line;
                        }
                        

                        
                        if (ST != null && start != TimeSpan.Parse("00:00") && stop != TimeSpan.Parse("00:00"))
                        {
                            STs.Add(new Subtitles(start, stop, ST));

                            ST = null;
                            start = TimeSpan.Parse("00:00");
                            stop = TimeSpan.Parse("00:00");

                        }
                        //Console.WriteLine(ST + " " + start + " " + stop);


                    }

                    reader.Close();
                    /*for (int i = 0; i < split.Length; i++)
                    {
                        Console.WriteLine(split[i] + " ");
                    }
                    Console.WriteLine("Start time : " + start);
                    Console.WriteLine("Stop time : " + stop);*/


                    /*foreach(string ST in STs)
                    {
                        Console.WriteLine(ST);
                    }*/

                    for (int i = 0; i < STs.Count; i++)
                    {

                    Console.WriteLine(STs[i].ST + " " + STs[i].start + " " + STs[i].stop);
                    }
                    Console.WriteLine(STs.Count);


                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
