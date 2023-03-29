using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App04;
using System;

namespace ConsoleAppTest
{
    [TestClass]
    public class App04Test
    {
        SocialNetwork socialNetwork;

        [TestInitialize]
        public void SetUp()
        {
            socialNetwork = new SocialNetwork();
        }

        [TestMethod]
        public void TestPostMessage()
        {
            var author = "Muneef";
            var message = "Hello, world!";
            socialNetwork.PostMessage();


        }
    }
}
