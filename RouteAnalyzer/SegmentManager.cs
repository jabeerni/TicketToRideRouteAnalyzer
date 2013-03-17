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
            segments.Add(new Segment { StartCity = City.LosAngeles, EndCity = City.SanFrancisco, NumberOfTrains = 3 });
            segments.Add(new Segment { StartCity = City.SanFrancisco, EndCity = City.Portland, NumberOfTrains = 5 });
            segments.Add(new Segment { StartCity = City.LosAngeles, EndCity = City.ElPaso, NumberOfTrains = 6 });
            segments.Add(new Segment { StartCity = City.LosAngeles, EndCity = City.LasVegas, NumberOfTrains = 2 });
            segments.Add(new Segment { StartCity = City.LosAngeles, EndCity = City.Phoenix, NumberOfTrains = 3 });
            segments.Add(new Segment { StartCity = City.Portland, EndCity = City.Seattle, NumberOfTrains = 1 });
            segments.Add(new Segment { StartCity = City.Seattle, EndCity = City.Vancouver, NumberOfTrains = 1 });
            segments.Add(new Segment { StartCity = City.Seattle, EndCity = City.Calgary, NumberOfTrains = 4 });
            segments.Add(new Segment { StartCity = City.Vancouver, EndCity = City.Calgary, NumberOfTrains = 3 });

            segments.Add(new Segment { StartCity = City.LasVegas, EndCity = City.SaltLakeCity, NumberOfTrains = 3 });
            segments.Add(new Segment { StartCity = City.Portland, EndCity = City.SaltLakeCity, NumberOfTrains = 6 });
            segments.Add(new Segment { StartCity = City.Seattle, EndCity = City.Helena, NumberOfTrains = 6 });
            segments.Add(new Segment { StartCity = City.Calgary, EndCity = City.Helena, NumberOfTrains = 4 });
            segments.Add(new Segment { StartCity = City.Calgary, EndCity = City.Winnipeg, NumberOfTrains = 6 });

            segments.Add(new Segment { StartCity = City.Helena, EndCity = City.Winnipeg, NumberOfTrains = 4 });
            segments.Add(new Segment { StartCity = City.Helena, EndCity = City.SaltLakeCity, NumberOfTrains = 3 });
            segments.Add(new Segment { StartCity = City.Helena, EndCity = City.Omaha, NumberOfTrains = 5 });
            segments.Add(new Segment { StartCity = City.Helena, EndCity = City.Duluth, NumberOfTrains = 6 });
            segments.Add(new Segment { StartCity = City.Winnipeg, EndCity = City.Duluth, NumberOfTrains = 4 });
            segments.Add(new Segment { StartCity = City.Winnipeg, EndCity = City.SaultStMarie, NumberOfTrains = 6 });
            segments.Add(new Segment { StartCity = City.Phoenix, EndCity = City.ElPaso, NumberOfTrains = 3 });
            segments.Add(new Segment { StartCity = City.Denver, EndCity = City.Phoenix, NumberOfTrains = 5 });
            segments.Add(new Segment { StartCity = City.Denver, EndCity = City.SaltLakeCity, NumberOfTrains = 3 });
            segments.Add(new Segment { StartCity = City.Denver, EndCity = City.Helena, NumberOfTrains = 4 });

            segments.Add(new Segment { StartCity = City.Denver, EndCity = City.Omaha, NumberOfTrains = 4 });
            segments.Add(new Segment { StartCity = City.Denver, EndCity = City.KansasCity, NumberOfTrains = 4 });
            segments.Add(new Segment { StartCity = City.Denver, EndCity = City.OklahomaCity, NumberOfTrains = 4 });
            segments.Add(new Segment { StartCity = City.Denver, EndCity = City.SantaFe, NumberOfTrains = 2 });
            segments.Add(new Segment { StartCity = City.SantaFe, EndCity = City.ElPaso, NumberOfTrains = 2 });
            segments.Add(new Segment { StartCity = City.SantaFe, EndCity = City.OklahomaCity, NumberOfTrains = 3 });
            segments.Add(new Segment { StartCity = City.ElPaso, EndCity = City.OklahomaCity, NumberOfTrains = 5 });
            segments.Add(new Segment { StartCity = City.ElPaso, EndCity = City.Dallas, NumberOfTrains = 4 });
            segments.Add(new Segment { StartCity = City.ElPaso, EndCity = City.Houston, NumberOfTrains = 6 });

            segments.Add(new Segment { StartCity = City.Duluth, EndCity = City.SaultStMarie, NumberOfTrains = 3 });
            segments.Add(new Segment { StartCity = City.Duluth, EndCity = City.Omaha, NumberOfTrains = 2 });
            segments.Add(new Segment { StartCity = City.Duluth, EndCity = City.Chicago, NumberOfTrains = 3 });
            segments.Add(new Segment { StartCity = City.Duluth, EndCity = City.Toronto, NumberOfTrains = 6 });
            segments.Add(new Segment { StartCity = City.Omaha, EndCity = City.KansasCity, NumberOfTrains = 1 });
            segments.Add(new Segment { StartCity = City.Omaha, EndCity = City.Chicago, NumberOfTrains = 4 });
            segments.Add(new Segment { StartCity = City.KansasCity, EndCity = City.OklahomaCity, NumberOfTrains = 2 });
            segments.Add(new Segment { StartCity = City.KansasCity, EndCity = City.SaintLouis, NumberOfTrains = 2 });
            segments.Add(new Segment { StartCity = City.OklahomaCity, EndCity = City.Dallas, NumberOfTrains = 2 });
            segments.Add(new Segment { StartCity = City.OklahomaCity, EndCity = City.LittleRock, NumberOfTrains = 2 });
            segments.Add(new Segment { StartCity = City.Dallas, EndCity = City.Houston, NumberOfTrains = 1 });
            segments.Add(new Segment { StartCity = City.Dallas, EndCity = City.LittleRock, NumberOfTrains = 2 });
            segments.Add(new Segment { StartCity = City.Houston, EndCity = City.NewOrleans, NumberOfTrains = 2 });

            segments.Add(new Segment { StartCity = City.LittleRock, EndCity = City.NewOrleans, NumberOfTrains = 3 });
            segments.Add(new Segment { StartCity = City.LittleRock, EndCity = City.Nashville, NumberOfTrains = 3 });
            segments.Add(new Segment { StartCity = City.LittleRock, EndCity = City.SaintLouis, NumberOfTrains = 2 });

            segments.Add(new Segment { StartCity = City.SaultStMarie, EndCity = City.Montreal, NumberOfTrains = 5 });
            segments.Add(new Segment { StartCity = City.SaultStMarie, EndCity = City.Toronto, NumberOfTrains = 2 });
            segments.Add(new Segment { StartCity = City.Toronto, EndCity = City.Montreal, NumberOfTrains = 3 });
            segments.Add(new Segment { StartCity = City.Toronto, EndCity = City.Pittsburgh, NumberOfTrains = 2 });
            segments.Add(new Segment { StartCity = City.Chicago, EndCity = City.Toronto, NumberOfTrains = 4 });
            segments.Add(new Segment { StartCity = City.Chicago, EndCity = City.SaintLouis, NumberOfTrains = 2 });
            segments.Add(new Segment { StartCity = City.Chicago, EndCity = City.Pittsburgh, NumberOfTrains = 3 });

            segments.Add(new Segment { StartCity = City.Montreal, EndCity = City.NewYork, NumberOfTrains = 3 });
            segments.Add(new Segment { StartCity = City.Montreal, EndCity = City.Boston, NumberOfTrains = 2 });
            segments.Add(new Segment { StartCity = City.Boston, EndCity = City.NewYork, NumberOfTrains = 2 });
            segments.Add(new Segment { StartCity = City.NewYork, EndCity = City.Pittsburgh, NumberOfTrains = 2 });
            segments.Add(new Segment { StartCity = City.Washington, EndCity = City.Pittsburgh, NumberOfTrains = 2 });
            segments.Add(new Segment { StartCity = City.Nashville, EndCity = City.Pittsburgh, NumberOfTrains = 4 });
            segments.Add(new Segment { StartCity = City.Raleigh, EndCity = City.Pittsburgh, NumberOfTrains = 2 });
            segments.Add(new Segment { StartCity = City.SaintLouis, EndCity = City.Pittsburgh, NumberOfTrains = 5 });

            segments.Add(new Segment { StartCity = City.NewYork, EndCity = City.Washington, NumberOfTrains = 2 });
            segments.Add(new Segment { StartCity = City.Raleigh, EndCity = City.Washington, NumberOfTrains = 2 });
            segments.Add(new Segment { StartCity = City.Raleigh, EndCity = City.Nashville, NumberOfTrains = 3 });
            segments.Add(new Segment { StartCity = City.Raleigh, EndCity = City.Atlanta, NumberOfTrains = 2 });
            segments.Add(new Segment { StartCity = City.Raleigh, EndCity = City.Charleston, NumberOfTrains = 2 });

            segments.Add(new Segment { StartCity = City.Atlanta, EndCity = City.Charleston, NumberOfTrains = 2 });
            segments.Add(new Segment { StartCity = City.Atlanta, EndCity = City.Nashville, NumberOfTrains = 1 });
            segments.Add(new Segment { StartCity = City.Atlanta, EndCity = City.NewOrleans, NumberOfTrains = 4 });
            segments.Add(new Segment { StartCity = City.Atlanta, EndCity = City.Miami, NumberOfTrains = 5 });
            segments.Add(new Segment { StartCity = City.Charleston, EndCity = City.Miami, NumberOfTrains = 4 });
            segments.Add(new Segment { StartCity = City.NewOrleans, EndCity = City.Miami, NumberOfTrains = 6 });
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
