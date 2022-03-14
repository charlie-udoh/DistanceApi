using Microsoft.VisualStudio.TestTools.UnitTesting;
using DistanceApi.Models;

namespace DistanceApi.Tests.UnitTests
{
    [TestClass]
    public class PlaneTests
    {
        [TestMethod]
        public void CalculateDistance_ReturnsCorrectValue()
        {
            var coordinates1 = new Coordinates(53.297975, -6.372663);
            var coordinates2 = new Coordinates(41.385101, -81.440440);
            var expected = 76.01;
            var plane = new Plane(coordinates1, coordinates2, "");

            var actual = plane.CalculateDistance();

            Assert.AreEqual(expected, actual, "Distance not correct");
        }
    }
}