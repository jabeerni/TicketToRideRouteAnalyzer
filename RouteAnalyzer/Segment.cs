using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteAnalyzer
{
    public class Segment
    {
        public string StartCity { get; set; }
        public string EndCity { get; set; }
        public int NumberOfTrains { get; set; }
    }
}
