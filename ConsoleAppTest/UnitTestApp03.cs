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
        private int[] mar;

        public App03Test()
        {
            mar = new int[] { 
                10,20,30,40,50,60,70,80,90,100
            };
        }

        [TestMethod]//Testing Valid Input
        public void Test_InputMark_With_Valid_Input()
        {
            using (StringReader stringReader = new StringReader("75\n"))
            {
                Console.SetIn(stringReader);

                int mark = studentGrades.InputMark("Enter mark for student 1: ");

                Assert.AreEqual(75, mark);
            }
        }

        [TestMethod]//Testing Invalid Input
        public void Test_InputMark_With_Invalid_Input()
        {
            using (StringReader stringReader = new StringReader("abc\n50\n"))
            {
                Console.SetIn(stringReader);

                int mark = studentGrades.InputMark("Enter mark for student 1: ");

                Assert.AreEqual(50, mark);
            }
        }

        [TestMethod]//Testing Grade A
        public void Test_ClassifyGrade_With_Mark_Above_70()
        {
            string grade = studentGrades.ClassifyGrade(85);

            Assert.AreEqual("- A (First Class)", grade);
        }

        [TestMethod]//Testing Grade B
        public void Test_ClassifyGrade_With_Mark_Between_60_And_69()
        {
            string grade = studentGrades.ClassifyGrade(65);

            Assert.AreEqual("- B (Upper Second Class)", grade);
        }

        [TestMethod]//Testing Grade C
        public void Test_ClassifyGrade_With_Mark_Between_50_And_59()
        {
            string grade = studentGrades.ClassifyGrade(55);

            Assert.AreEqual("- C (Lower Second Class)", grade);
        }

        [TestMethod]//Testing Grade D
        public void Test_ClassifyGrade_With_Mark_Between_40_And_49()
        {
            string grade = studentGrades.ClassifyGrade(45);

            Assert.AreEqual("- D (Third Class)", grade);
        }

        [TestMethod]//Testing Grade F
        public void Test_ClassifyGrade_With_Mark_Bellow_40()
        {
            string grade = studentGrades.ClassifyGrade(10);

            Assert.AreEqual("- F (Fail)", grade);
        }

        [TestMethod]//Testing Mean Mark
        public void TestMean()
        {
            studentGrades.marks = mar;
            double expectedMean = 55.0;

            studentGrades.CalculateMean();

            Assert.AreEqual(expectedMean, studentGrades.mean);
        }

        [TestMethod]//Testing Minimum Mark
        public void TestMinimum()
        {
            studentGrades.marks = mar;
            int expectedMin = 10;

            studentGrades.CalculateMinimum();

            Assert.AreEqual(expectedMin, studentGrades.min);
        }

        [TestMethod]//Testing Maximum Mark
        public void TestMaximum()
        {
            studentGrades.marks = mar;
            int expectedMax = 100;

            studentGrades.CalculateMaximum();

            Assert.AreEqual(expectedMax, studentGrades.max);
        }

        [TestMethod]//Testing Grade Profile
        public void TestGradeProfile()
        {
            studentGrades.marks = mar;

            studentGrades.CalculateGradeProfile();

            bool expectedGradeProfile;
            expectedGradeProfile = ((studentGrades.gradeCounts[0] == 4) && 
                                    (studentGrades.gradeCounts[1] == 1) && 
                                    (studentGrades.gradeCounts[2] == 1) &&
                                    (studentGrades.gradeCounts[3] == 1) && 
                                    (studentGrades.gradeCounts[4] == 3));

            Assert.IsTrue(expectedGradeProfile);
        }
    }
}
