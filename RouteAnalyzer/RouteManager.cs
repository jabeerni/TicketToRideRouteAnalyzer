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

        private void AddRoutes(List<Route> routes)
        {
            routes.Add(new Route { StartCity = "Los Angeles", EndCity = "Seattle", NumberOfPoints = 9 });
            routes.Add(new Route { StartCity = "Calgary", EndCity = "Phoenix", NumberOfPoints = 8 });
            routes.Add(new Route { StartCity = "Helena", EndCity = "Los Angeles", NumberOfPoints = 7 });
            routes.Add(new Route { StartCity = "Vancouver", EndCity = "Portland", NumberOfPoints = 2 });

            // todo: Add the rest of the Routes
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
    }
}
