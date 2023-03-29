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
        public void PostMessage_ShouldAddMessageToNewsFeed()
        {
            var author = "John Doe";
            var message = "Hello, world!";

        }
    }
}
