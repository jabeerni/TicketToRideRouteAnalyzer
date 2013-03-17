using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteAnalyzer
{
    public class SegmentManager
    {
        private static SegmentManager instance;
        private static List<Segment> segments;

        public IEnumerable<Segment> Segments
        {
            get { return segments; }
        }

        private SegmentManager()
        {
            segments = new List<Segment>();

            AddOriginalSegments(segments);
            AddReverseSegments(segments);
        }

        private void AddOriginalSegments(List<Segment> segments)
        {
            segments.Add(new Segment { StartCity = "Los Angeles", EndCity = "San Francisco", NumberOfTrains = 3 });
            segments.Add(new Segment { StartCity = "San Francisco", EndCity = "Portland", NumberOfTrains = 5 });
            segments.Add(new Segment { StartCity = "Los Angeles", EndCity = "El Paso", NumberOfTrains = 6 });
            segments.Add(new Segment { StartCity = "Los Angeles", EndCity = "Las Vegas", NumberOfTrains = 2 });
            segments.Add(new Segment { StartCity = "Los Angeles", EndCity = "Phoenix", NumberOfTrains = 3 });
            segments.Add(new Segment { StartCity = "Portland", EndCity = "Seattle", NumberOfTrains = 1 });
            segments.Add(new Segment { StartCity = "Seattle", EndCity = "Vancouver", NumberOfTrains = 1 });
            segments.Add(new Segment { StartCity = "Seattle", EndCity = "Calgary", NumberOfTrains = 4 });
            segments.Add(new Segment { StartCity = "Vancouver", EndCity = "Calgary", NumberOfTrains = 3 });

            segments.Add(new Segment { StartCity = "Las Vegas", EndCity = "Salt Lake City", NumberOfTrains = 3 });
            segments.Add(new Segment { StartCity = "Portland", EndCity = "Salt Lake City", NumberOfTrains = 6 });
            segments.Add(new Segment { StartCity = "Seattle", EndCity = "Helena", NumberOfTrains = 6 });
            segments.Add(new Segment { StartCity = "Calgary", EndCity = "Helena", NumberOfTrains = 4 });
            segments.Add(new Segment { StartCity = "Calgary", EndCity = "Winnipeg", NumberOfTrains = 6 });

            segments.Add(new Segment { StartCity = "Helena", EndCity = "Winnipeg", NumberOfTrains = 4 });
            segments.Add(new Segment { StartCity = "Helena", EndCity = "Salt Lake City", NumberOfTrains = 3 });
            segments.Add(new Segment { StartCity = "Helena", EndCity = "Omaha", NumberOfTrains = 5 });
            segments.Add(new Segment { StartCity = "Helena", EndCity = "Duluth", NumberOfTrains = 6 });
            segments.Add(new Segment { StartCity = "Winnipeg", EndCity = "Duluth", NumberOfTrains = 4 });
            segments.Add(new Segment { StartCity = "Winnipeg", EndCity = "Sault St. Marie", NumberOfTrains = 6 });
            segments.Add(new Segment { StartCity = "Phoenix", EndCity = "El Paso", NumberOfTrains = 3 });
            segments.Add(new Segment { StartCity = "Denver", EndCity = "Phoenix", NumberOfTrains = 5 });
            segments.Add(new Segment { StartCity = "Denver", EndCity = "Salt Lake City", NumberOfTrains = 3 });
            segments.Add(new Segment { StartCity = "Denver", EndCity = "Helena", NumberOfTrains = 4 });

            segments.Add(new Segment { StartCity = "Denver", EndCity = "Omaha", NumberOfTrains = 4 });
            segments.Add(new Segment { StartCity = "Denver", EndCity = "Kansas City", NumberOfTrains = 4 });
            segments.Add(new Segment { StartCity = "Denver", EndCity = "Oklahoma City", NumberOfTrains = 4 });
            segments.Add(new Segment { StartCity = "Denver", EndCity = "Santa Fe", NumberOfTrains = 2 });
            segments.Add(new Segment { StartCity = "Santa Fe", EndCity = "El Paso", NumberOfTrains = 2 });
            segments.Add(new Segment { StartCity = "Santa Fe", EndCity = "Oklahoma City", NumberOfTrains = 3 });
            segments.Add(new Segment { StartCity = "El Paso", EndCity = "Oklahoma City", NumberOfTrains = 5 });
            segments.Add(new Segment { StartCity = "El Paso", EndCity = "Dallas", NumberOfTrains = 4 });
            segments.Add(new Segment { StartCity = "El Paso", EndCity = "Houston", NumberOfTrains = 6 });

            segments.Add(new Segment { StartCity = "Duluth", EndCity = "Sault St. Marie", NumberOfTrains = 3 });
            segments.Add(new Segment { StartCity = "Duluth", EndCity = "Omaha", NumberOfTrains = 2 });
            segments.Add(new Segment { StartCity = "Duluth", EndCity = "Chicago", NumberOfTrains = 3 });
            segments.Add(new Segment { StartCity = "Duluth", EndCity = "Toronto", NumberOfTrains = 6 });
            segments.Add(new Segment { StartCity = "Omaha", EndCity = "Kansas City", NumberOfTrains = 1 });
            segments.Add(new Segment { StartCity = "Omaha", EndCity = "Chicago", NumberOfTrains = 4 });
            segments.Add(new Segment { StartCity = "Kansas City", EndCity = "Oklahoma City", NumberOfTrains = 2 });
            segments.Add(new Segment { StartCity = "Kansas City", EndCity = "Saint Louis", NumberOfTrains = 2 });
            segments.Add(new Segment { StartCity = "Oklahoma City", EndCity = "Dallas", NumberOfTrains = 2 });
            segments.Add(new Segment { StartCity = "Oklahoma City", EndCity = "Little Rock", NumberOfTrains = 2 });
            segments.Add(new Segment { StartCity = "Dallas", EndCity = "Houston", NumberOfTrains = 1 });
            segments.Add(new Segment { StartCity = "Dallas", EndCity = "Little Rock", NumberOfTrains = 2 });
            segments.Add(new Segment { StartCity = "Houston", EndCity = "New Orleans", NumberOfTrains = 2 });

            segments.Add(new Segment { StartCity = "Little Rock", EndCity = "New Orleans", NumberOfTrains = 3 });
            segments.Add(new Segment { StartCity = "Little Rock", EndCity = "Nashville", NumberOfTrains = 3 });
            segments.Add(new Segment { StartCity = "Little Rock", EndCity = "Saint Louis", NumberOfTrains = 2 });

            segments.Add(new Segment { StartCity = "Sault St. Marie", EndCity = "Montreal", NumberOfTrains = 5 });
            segments.Add(new Segment { StartCity = "Sault St. Marie", EndCity = "Toronto", NumberOfTrains = 2 });
            segments.Add(new Segment { StartCity = "Toronto", EndCity = "Montreal", NumberOfTrains = 3 });
            segments.Add(new Segment { StartCity = "Toronto", EndCity = "Pittsburgh", NumberOfTrains = 2 });
            segments.Add(new Segment { StartCity = "Chicago", EndCity = "Toronto", NumberOfTrains = 4 });
            segments.Add(new Segment { StartCity = "Chicago", EndCity = "Saint Louis", NumberOfTrains = 2 });
            segments.Add(new Segment { StartCity = "Chicago", EndCity = "Pittsburgh", NumberOfTrains = 3 });

            segments.Add(new Segment { StartCity = "Montreal", EndCity = "New York", NumberOfTrains = 3 });
            segments.Add(new Segment { StartCity = "Montreal", EndCity = "Boston", NumberOfTrains = 2 });
            segments.Add(new Segment { StartCity = "Boston", EndCity = "New York", NumberOfTrains = 2 });
            segments.Add(new Segment { StartCity = "New York", EndCity = "Pittsburgh", NumberOfTrains = 2 });
            segments.Add(new Segment { StartCity = "Washington", EndCity = "Pittsburgh", NumberOfTrains = 2 });
            segments.Add(new Segment { StartCity = "Nashville", EndCity = "Pittsburgh", NumberOfTrains = 4 });
            segments.Add(new Segment { StartCity = "Raleigh", EndCity = "Pittsburgh", NumberOfTrains = 2 });
            segments.Add(new Segment { StartCity = "Saint Louis", EndCity = "Pittsburgh", NumberOfTrains = 5 });

            segments.Add(new Segment { StartCity = "New York", EndCity = "Washington", NumberOfTrains = 2 });
            segments.Add(new Segment { StartCity = "Raleigh", EndCity = "Washington", NumberOfTrains = 2 });
            segments.Add(new Segment { StartCity = "Raleigh", EndCity = "Nashville", NumberOfTrains = 3 });
            segments.Add(new Segment { StartCity = "Raleigh", EndCity = "Atlanta", NumberOfTrains = 2 });
            segments.Add(new Segment { StartCity = "Raleigh", EndCity = "Charleston", NumberOfTrains = 2 });

            segments.Add(new Segment { StartCity = "Atlanta", EndCity = "Charleston", NumberOfTrains = 2 });
            segments.Add(new Segment { StartCity = "Atlanta", EndCity = "Nashville", NumberOfTrains = 1 });
            segments.Add(new Segment { StartCity = "Atlanta", EndCity = "New Orleans", NumberOfTrains = 4 });
            segments.Add(new Segment { StartCity = "Atlanta", EndCity = "Miami", NumberOfTrains = 5 });
            segments.Add(new Segment { StartCity = "Charleston", EndCity = "Miami", NumberOfTrains = 4 });
            segments.Add(new Segment { StartCity = "New Orleans", EndCity = "Miami", NumberOfTrains = 6 });
        }

        private static void AddReverseSegments(List<Segment> segments)
        {
            var reverseSegmentList = segments.Select(route => new Segment
            {
                StartCity = route.EndCity,
                EndCity = route.StartCity,
                NumberOfTrains = route.NumberOfTrains
            }).ToList();

            segments.AddRange(reverseSegmentList);
        }

        public static SegmentManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SegmentManager();
                }

                return instance;
            }
        }
    }
}
