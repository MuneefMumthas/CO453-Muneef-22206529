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
        public void Test_InputMark_With_Valid_Input()
        {
            using (StringReader stringReader = new StringReader("75\n"))
            {
                Console.SetIn(stringReader);

                int mark = studentGrades.InputMark("Enter mark for student 1: ");

                Assert.AreEqual(75, mark);
            }
        }

        [TestMethod]
        public void Test_InputMark_With_Invalid_Input()
        {
            using (StringReader stringReader = new StringReader("abc\n50\n"))
            {
                Console.SetIn(stringReader);

                int mark = studentGrades.InputMark("Enter mark for student 1: ");

                Assert.AreEqual(50, mark);
            }
        }

        [TestMethod]
        public void Test_ClassifyGrade_With_Mark_Above_70()
        {
            string grade = studentGrades.ClassifyGrade(85);

            Assert.AreEqual("- A (First Class)", grade);
        }

        [TestMethod]
        public void Test_ClassifyGrade_With_Mark_Between_60_And_69()
        {
            string grade = studentGrades.ClassifyGrade(65);

            Assert.AreEqual("- B (Upper Second Class)", grade);
        }

        [TestMethod]
        public void Test_ClassifyGrade_With_Mark_Between_50_And_59()
        {
            string grade = studentGrades.ClassifyGrade(55);

            Assert.AreEqual("- C (Lower Second Class)", grade);
        }

        [TestMethod]
        public void Test_ClassifyGrade_With_Mark_Between_40_And_49()
        {
            string grade = studentGrades.ClassifyGrade(45);

            Assert.AreEqual("- D (Third Class)", grade);
        }

        [TestMethod]
        public void Test_ClassifyGrade_With_Mark_Bellow_40()
        {
            string grade = studentGrades.ClassifyGrade(10);

            Assert.AreEqual("- F (Fail)", grade);
        }
    }
}
