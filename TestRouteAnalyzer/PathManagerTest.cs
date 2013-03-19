using System;
using RouteAnalyzer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;

namespace TestRouteAnalyzer
{
    [TestClass]
    public class PathManagerTest
    {
        [TestMethod]
        public void VerifyPathManagerIsNotNull()
        {
            var pathManager = new PathManager();

            Assert.IsNotNull(pathManager);
        }

        [TestMethod]
        public void VerifyRouteManagerRoutesPopulated()
        {
            var pathManager = new PathManager();

            Assert.IsNotNull(pathManager.Path);
        }

        [TestMethod]
        public void FindRouteCalgaryToLosAngeles()
        {
            var pathManager = new PathManager();

            var startCity = City.Calgary;
            var endCity = City.LosAngeles;

            var route = pathManager.GetRoute(startCity, endCity);

            Console.WriteLine("Route from {0} to {1} is as follows:", startCity, endCity);

            if (route != null && route.Any())
            {
                foreach (var segment in route)
                {
                    Console.WriteLine("{0} - {1} ({2} Trains)", segment.StartCity, segment.EndCity, segment.NumberOfTrains);
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
            var pathManager = new PathManager();

            var startCity = City.Calgary;
            var endCity = City.LosAngeles;
            var expected = 12;

            var route = pathManager.GetRoute(startCity, endCity);
            var actual = pathManager.BestCost;

            Console.WriteLine("Cost of Route from {0} to {1} is {2}", startCity, endCity, actual);

            Assert.AreEqual(expected, actual);
        }
    }
}
