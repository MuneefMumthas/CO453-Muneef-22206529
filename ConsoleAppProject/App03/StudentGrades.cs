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
            OutputStatistics();
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
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\nStudents' Marks With Grades\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
        
            for (int i = 0; i < NumStudents; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($"Student {i + 1}: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{marks[i],3} {ClassifyGrade(marks[i])}");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("");
                Console.WriteLine();
            }
        }

        private void OutputStatistics()
        {
            int total = 0;
            int min = MaxMark;
            int max = MinMark;

            foreach (int mark in marks)
            {
                total += mark;
                if (mark < min) min = mark;
                if (mark > max) max = mark;
            }

            double mean = (double)total / NumStudents;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n\nStatistics\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"Mean Mark: ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write($"{mean,6:F2}");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"Minimum Mark: ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write($"{min,3}");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"Maximum Mark: ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write($"{max,3}");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Cyan;
        }

        private string ClassifyGrade(int mark)
        {
            if (mark >= 70) 
            {
                Console.ForegroundColor = ConsoleColor.Green;
                return "- A (First Class)";
            }
            else if (mark >= 60) 
            {
                Console.ForegroundColor = ConsoleColor.Green;
                return "- B (Upper Second Class)";
            }
            else if (mark >= 50) 
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                return "- C (Lower Second Class)";
            }
            else if (mark >= 40) 
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                return "- D (Third Class)";
            }
            else 
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                return "- F (Fail)";
            }

        }

    }
}
