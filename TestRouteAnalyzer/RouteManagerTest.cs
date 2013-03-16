using System;
using RouteAnalyzer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

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
    }
}
