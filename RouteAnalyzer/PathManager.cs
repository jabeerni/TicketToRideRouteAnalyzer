using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteAnalyzer
{
    public class PathManager
    {
        public Path Path { get; private set; }
        private Stack<Segment> BestRoute { get; set; }
        public int BestCost { get; private set; }

        public PathManager()
        {
            Path = new Path();
            BestRoute = new Stack<Segment>();
            BestCost = 999;
        }

        public Stack<Segment> GetRoute(City startCity, City endCity)
        {
            var route = new Stack<Segment>();
            

            Path.CitiesReached.Add(startCity);
            AddValidSegmentsToPath(startCity, endCity, Path);

            foreach (var seg in BestRoute)
            {
                route.Push(seg);
            }
            return route;
        }

        public int GetCostForRoute(City startCity, City endCity)
        {
            var cost = 0;

            return cost;
        }

        // Add all segments to collection of path where
        // the endCity is not in the Path.CitiesReached already
        private void AddValidSegmentsToPath(City startCity, City endCity, Path path)
        {
            var segments = SegmentManager.Instance.Segments.Where(s => s.StartCity == startCity && !path.CitiesReached.Any(cr => cr == s.EndCity));

            foreach (var segment in segments)
            {
                var newPath = new Path();
                newPath.CurrentSegment = segment;
                newPath.Cost = segment.NumberOfTrains + path.Cost;
                newPath.CitiesReached.AddRange(path.CitiesReached);
                newPath.CitiesReached.Add(segment.EndCity);
                
                foreach (var seg in path.SegmentsTraversed.Reverse())
                {
                    newPath.SegmentsTraversed.Push(new Segment { EndCity = seg.EndCity, NumberOfTrains = seg.NumberOfTrains, StartCity = seg.StartCity });
                }
                newPath.SegmentsTraversed.Push(segment);
                
                path.DownlinePaths.Add(newPath);

                if (segment.EndCity == endCity && newPath.Cost < this.BestCost)
                {
                    this.BestCost = newPath.Cost;
                    this.BestRoute.Clear();

                    foreach (var newPathSeg in newPath.SegmentsTraversed.Reverse())
                    {
                        this.BestRoute.Push(new Segment { EndCity = newPathSeg.EndCity, NumberOfTrains = newPathSeg.NumberOfTrains, StartCity = newPathSeg.StartCity });
                    }
                }
                else if (segment.EndCity != endCity && newPath.Cost < this.BestCost)
                {
                    AddValidSegmentsToPath(segment.EndCity, endCity, newPath);
                }
            }
        }
    }
}
