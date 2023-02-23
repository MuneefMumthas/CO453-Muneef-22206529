using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App01;

namespace ConsoleApp.UnitTests
{
    [TestClass]
    public class TestDistanceConverter
    {
        private DistanceConverter distanceconverter;

        [TestInitialize]
        public void Setup()
        {
            distanceconverter = new DistanceConverter();
        }

        [TestMethod]
        public void TestConvertMilesToFeet()
        {
            distanceconverter.FromUnit = DistanceUnits.Miles;
            distanceconverter.ToUnit = DistanceUnits.Feet;
            distanceconverter.GetDistance = 1;
            distanceconverter.ConvertDistance();

            double expected = 5280;
            double actual = distanceconverter.OutputDistance;

            Assert.AreEqual(expected, actual, 0.1);
        }
    }
}
