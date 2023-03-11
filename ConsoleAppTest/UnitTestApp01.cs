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
            distanceConverter.ConvertDistance();
            Assert.AreEqual(26400, distanceConverter.Result);
        }
        [TestMethod]
        public void TestMilesToMeters()
        {
            // Testing conversion between miles to meters
            distanceConverter.FromUnit = 1;
            distanceConverter.ToUnit = 3;
            distanceConverter.Distance = 1;
            distanceConverter.ConvertDistance();
            Assert.AreEqual(1609.344, distanceConverter.Result);
        }

        [TestMethod]
        public void TestFeetToMiles()
        {
            // Testing conversion between Feet to Miles
            distanceConverter.FromUnit = 2;
            distanceConverter.ToUnit = 1;
            distanceConverter.Distance = 10560;
            distanceConverter.ConvertDistance();
            Assert.AreEqual(2, distanceConverter.Result);
        }

        [TestMethod]
        public void TestFeetToMeters()
        {
            // Testing conversion between feet to meters
            distanceConverter.FromUnit = 2;
            distanceConverter.ToUnit = 3;
            distanceConverter.Distance = 10;
            distanceConverter.ConvertDistance();
            Assert.AreEqual(3.048, distanceConverter.Result);
        }
        [TestMethod]
        public void TestMetersToMiles()
        {
            // Testing conversion between meters to miles
            distanceConverter.FromUnit = 3;
            distanceConverter.ToUnit = 1;
            distanceConverter.Distance = 1609.344;
            distanceConverter.ConvertDistance();
            Assert.AreEqual(1, distanceConverter.Result);
        }

        [TestMethod]
        public void TestMetersToFeet()
        {
            // Testing conversion between meters to feet
            distanceConverter.FromUnit = 3;
            distanceConverter.ToUnit = 2;
            distanceConverter.Distance = 3.048;
            distanceConverter.ConvertDistance();
            Assert.AreEqual(10, distanceConverter.Result);
        }
    }
}