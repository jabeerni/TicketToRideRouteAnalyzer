using System;
using RouteAnalyzer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace TestRouteAnalyzer
{
    [TestClass]
    public class SegmentManagerTest
    {
        [TestMethod]
        public void VerifySegmentManagerIsNotNull()
        {
            var segmentManager = SegmentManager.Instance;

            Assert.IsNotNull(segmentManager);
        }

        [TestMethod]
        public void VerifySegmentManagerSegmentsPopulated()
        {
            var segmentManager = SegmentManager.Instance;

            Assert.IsNotNull(segmentManager.Segments);
            Assert.IsTrue(segmentManager.Segments.Any());
        }

        [TestMethod]
        public void VerifySegmentManagerReverseSegmentsPopulated()
        {
            var segmentManager = SegmentManager.Instance;

            Assert.IsNotNull(segmentManager.Segments);
            Assert.IsTrue(segmentManager.Segments.Any(s => s.StartCity == "Vancouver" && s.EndCity == "Seattle" && s.NumberOfTrains == 1));
        }

    }
}
