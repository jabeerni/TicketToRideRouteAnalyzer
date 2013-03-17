using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteAnalyzer
{
    public class RouteManager
    {
        private static RouteManager instance;
        private static List<Route> routes;

        public IEnumerable<Route> Routes
        {
            get { return routes; }
        }

        private RouteManager()
        {
            routes = new List<Route>();

            AddRoutes(routes);
        }

        public static RouteManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RouteManager();
                }

                return instance;
            }
        }

        private void AddRoutes(List<Route> routes)
        {
            routes.Add(new Route { StartCity = "Los Angeles", EndCity = "Seattle", NumberOfPoints = 9 });
            routes.Add(new Route { StartCity = "Calgary", EndCity = "Phoenix", NumberOfPoints = 8 });
            routes.Add(new Route { StartCity = "Helena", EndCity = "Los Angeles", NumberOfPoints = 7 });
            routes.Add(new Route { StartCity = "Vancouver", EndCity = "Portland", NumberOfPoints = 2 });

            // todo: Add the rest of the Routes
        }

        public int GetCostForRoute(Stack<Segment> route)
        {
            return route.Sum(r => r.NumberOfTrains);
        }

        public int GetCostForRoute(string startCity, string endCity)
        {
            var citiesReached = new List<string>() { startCity };

            var route = GetRoute(startCity, endCity, citiesReached);
            
            return GetCostForRoute(route);
        }

        public Stack<Segment> GetRoute(string startCity, string endCity, List<string> citiesReached)
        {
            var route = new Stack<Segment>();

            var segments = SegmentManager.Instance.Segments.Where(s => s.StartCity == startCity && !citiesReached.Any(cr => cr == s.EndCity));

            if (segments.Any(s => s.EndCity == endCity))
            {
                route.Push(segments.FirstOrDefault(s => s.EndCity == endCity));
            }
            else
            {
                foreach (var segment in segments)
                {
                    citiesReached.Add(segment.EndCity);
                    var tempRoute = GetRoute(segment.EndCity, endCity, citiesReached);

                    if (tempRoute.Any(s => s.EndCity == endCity))
                    {
                        foreach (var tempSegment in tempRoute.Reverse<Segment>())
                        {
                            route.Push(tempSegment);
                        }

                        route.Push(segment);
                        break;
                    }
                }
            }
            return route;
        }
    }
}
