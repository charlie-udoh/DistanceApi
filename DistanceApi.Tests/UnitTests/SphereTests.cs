using DistanceApi.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DistanceApi.Tests.UnitTests
{
    [TestClass]
    public class SphereTests
    {
        [TestMethod]
        public void CalculateDistance_ReturnsCorrectValue_InKilometers()
        {
            var coordinates1 = new Coordinates(53.297975, -6.372663);
            var coordinates2 = new Coordinates(41.385101, -81.440440);
            var unitOfLength = "Kilometers";
            var expected = 5536.34;
            var sphere = new Sphere(coordinates1, coordinates2, unitOfLength);

            var actual = sphere.CalculateDistance();

            Assert.AreEqual(expected, actual, "Distance not correct");
        }

        [TestMethod]
        public void CalculateDistance_ReturnsCorrectValue_InMiles()
        {
            var coordinates1 = new Coordinates(53.297975, -6.372663);
            var coordinates2 = new Coordinates(41.385101, -81.440440);
            var unitOfLength = "Miles";
            var expected = 3440.16;
            var sphere = new Sphere(coordinates1, coordinates2, unitOfLength);

            var actual = sphere.CalculateDistance();

            Assert.AreEqual(expected, actual, "Distance not correct");
        }
    }
}
