using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp.Tests
{
    [TestClass]
    public class App01Test
    {
        [TestMethod]
        public void TestMilesToFeetConversion()
        {
            // Arrange
            DistanceConverter converter = new DistanceConverter();
            converter.FromUnit = 1; // miles
            converter.ToUnit = 2; // feet
            converter.Distance = 1.5;

            // Act
            converter.Run();

            // Assert
            Assert.AreEqual(7920, converter.Result);
        }
    }
}
