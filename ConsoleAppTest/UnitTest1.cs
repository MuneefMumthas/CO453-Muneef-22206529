using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App01;
using System;
using ConsoleAppProject;

namespace ConsoleAppTest
{
    [TestClass]
    public class App01Test
    {
        DistanceConverter distanceConverter = new DistanceConverter();
        [TestMethod]
        public void TestMilesToFeet()
        {
            // Testing conversion between miles to feet
            distanceConverter.FromUnit = 1;
            distanceConverter.ToUnit = 2;
            distanceConverter.Distance = 5;
            distanceConverter.Run();
            Assert.AreEqual(26400, distanceConverter.Result);
        }
    }
}