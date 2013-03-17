using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteAnalyzer
{
    public class Route
    {
        public City StartCity { get; set; }
        public City EndCity { get; set; }
        public int NumberOfPoints { get; set; }
    }
}
