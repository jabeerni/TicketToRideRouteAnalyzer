using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteAnalyzer
{
    public class Path
    {
        public List<Path> DownlinePaths { get; set; }
        public int Cost { get; set; }
        public List<City> CitiesReached { get; set; }
        public Segment CurrentSegment { get; set; }
        public Stack<Segment> SegmentsTraversed { get; set; }

        public Path()
        {
            DownlinePaths = new List<Path>();
            CitiesReached = new List<City>();
            SegmentsTraversed = new Stack<Segment>();
        }
    }
}
