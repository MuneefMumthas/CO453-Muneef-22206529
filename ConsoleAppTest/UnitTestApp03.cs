using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App03;
using System;
using ConsoleAppProject;

namespace ConsoleAppTest
{
    [TestClass]
    public class App03Test
    {
        StudentGrades studentGrades = new StudentGrades();

        [TestMethod]
        public void TestInputMark()
        {
            using (StringReader stringReader = new StringReader("75\n"))
            {
                Console.SetIn(stringReader);

                int mark = studentGrades.InputMark("Enter mark for student 1: ");

                Assert.AreEqual(75, mark);
            }
        }
    }
}
