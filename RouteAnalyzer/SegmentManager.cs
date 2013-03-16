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
            segments.Add(new Segment { StartCity = "Los Angeles", EndCity = "Portland", NumberOfTrains = 5 });
            segments.Add(new Segment { StartCity = "Los Angeles", EndCity = "El Paso", NumberOfTrains = 6 });
            segments.Add(new Segment { StartCity = "Los Angeles", EndCity = "Las Vegas", NumberOfTrains = 2 });
            segments.Add(new Segment { StartCity = "Los Angeles", EndCity = "Phoenix", NumberOfTrains = 3 });
            segments.Add(new Segment { StartCity = "Portland", EndCity = "Seattle", NumberOfTrains = 1 });
            segments.Add(new Segment { StartCity = "Seattle", EndCity = "Vancouver", NumberOfTrains = 1 });
            segments.Add(new Segment { StartCity = "Seattle", EndCity = "Calgary", NumberOfTrains = 4 });
            segments.Add(new Segment { StartCity = "Vancouver", EndCity = "Calgary", NumberOfTrains = 3 });

            // todo: Add the rest of the Segments
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
