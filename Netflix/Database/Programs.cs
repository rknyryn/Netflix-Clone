using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Netflix.Database
{
    class Programs
    {
        public int id;
        public string name;
        public string programType;
        public List<string> programKind = new List<string>();
        public int numberOfEpisodes;
        public float programLength;
        public string bannerUrl;
        public double puan;
    }
}
