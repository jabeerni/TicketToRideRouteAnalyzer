using System;
using RouteAnalyzer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;

namespace TestRouteAnalyzer
{
    [TestClass]
    public class RouteManagerTest
    {
        [TestMethod]
        public void VerifyRouteManagerIsNotNull()
        {
            var routeManager = RouteManager.Instance;

            Assert.IsNotNull(routeManager);
        }

        [TestMethod]
        public void VerifyRouteManagerRoutesPopulated()
        {
            var routeManager = RouteManager.Instance;

            Assert.IsNotNull(routeManager.Routes);
            Assert.IsTrue(routeManager.Routes.Any());
        }

        [TestMethod]
        public void FindRouteCalgaryToLosAngeles()
        {
            var routeManager = RouteManager.Instance;

            var startCity = "Calgary";
            var endCity = "Los Angeles";
            var citiesReached = new List<string>(){ startCity };

            var route = routeManager.GetRoute(startCity, endCity, citiesReached);

            Console.WriteLine("Route from {0} to {1} is as follows:", startCity, endCity);

            if (route != null && route.Any())
            {
                foreach (var segment in route)
                {
                    Console.WriteLine("{0} - {1}", segment.StartCity, segment.EndCity);
                }
            }
            else
            {
                Console.WriteLine("Route not found");
            }
        }

        [TestMethod]
        public void FindRouteCostCalgaryToLosAngeles()
        {
            var routeManager = RouteManager.Instance;

            var startCity = "Calgary";
            var endCity = "Los Angeles";
            var expected = 13;

            var actual = routeManager.GetCostForRoute(startCity, endCity);

            Console.WriteLine("Cost of Route from {0} to {1} is {2}", startCity, endCity, expected);

            Assert.AreEqual(expected, actual);
        }
    }
}
