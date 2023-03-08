using System;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// Calculates grades for students as per input marks
    /// </summary>
    /// <author>
    /// Muneef Mumthas - 22206529
    /// </author>
    public class StudentGrades
    {
        private const int NumStudents = 10;
        private const int MinMark = 0;
        private const int MaxMark = 100;

        private int[] marks;

        public StudentGrades()
        {
            marks = new int[NumStudents];
        }

        public void Run()
        {
            InputMarks();
            OutputMarks();
        }

        private void InputMarks()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Please enter a mark between {MinMark} and {MaxMark} for each of the {NumStudents} students:");
            for (int i = 0; i < NumStudents; i++)
            {
                marks[i] = InputMark($"Enter mark for student {i + 1}: ");
            }
        }

        private int InputMark(string prompt)
        {
            int mark;
            bool isValidInput;

            do
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                isValidInput = int.TryParse(input, out mark) && mark >= MinMark && mark <= MaxMark;

                if (!isValidInput)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"Invalid input: {input}. Please enter a valid mark between {MinMark} and {MaxMark}.");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
            } while (!isValidInput);

            return mark;
        }

        private void OutputMarks()
        {
            Console.WriteLine("\n\nStudent Marks\n");
        
            for (int i = 0; i < NumStudents; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($"Student {i + 1}: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{marks[i],3} {ClassifyGrade(marks[i])}");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine();
            }
        }


        private Grades ClassifyGrade(int mark)
        {
            if (mark >= 70) return Grades.A;
            else if (mark >= 60) return Grades.B;
            else if (mark >= 50) return Grades.C;
            else if (mark >= 40) return Grades.D;
            else return Grades.F;
        }
    }
}
