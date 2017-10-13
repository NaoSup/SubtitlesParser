using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Subtitles
{
    class Subtitles
    {
        public TimeSpan start;
        public TimeSpan stop;
        public string ST;
        
        //Constructeurs
        public Subtitles( TimeSpan start, TimeSpan stop, string ST)
        {
            this.start = start;
            this.stop = stop;
            this.ST = ST;
        }
    }
}
