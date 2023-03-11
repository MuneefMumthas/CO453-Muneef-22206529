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
        public const int NumStudents = 10;
        public const int MinMark = 0;
        public const int MaxMark = 100;

        public int[] marks;

        public StudentGrades()
        {
            marks = new int[NumStudents];
        }

        // Runs the application
        public void Run()
        {
           prompt();
        }
        
        // The prompt to choose different options
        public void prompt()
        {

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("1. Input Marks");
            Console.WriteLine("2. Output Grades");
            Console.WriteLine("3. Output Statistics");
            Console.WriteLine("4. Output Grade Profile");
            Console.WriteLine("5. Quit");
            Console.WriteLine();
            Console.Write("Answer: ");


        int ChoiceNumber = 0;
            while (ChoiceNumber == 0)
        {
                string input = Console.ReadLine();
                if (int.TryParse(input, out int choice) && (choice == 1 || choice == 2 || choice == 3 || choice == 4 || choice == 5))
                {
                    ChoiceNumber = choice;
                }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Please enter a valid input (1-5).");
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
        }
        
        if (ChoiceNumber == 1)
        {
            InputMarks();
        }

        if (ChoiceNumber == 2)
        {
            OutputMarks();
        }

        if (ChoiceNumber == 3)
        {
            OutputStatistics();
        }

        if (ChoiceNumber == 4)
        {
            OutputGradeProfile();
        }

        if (ChoiceNumber == 5)
        {
            Environment.Exit(0);
        }

        }
        
        // Prompt to input marks for each student
        public void InputMarks()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Please enter a mark between {MinMark} and {MaxMark} for each of the {NumStudents} students:");
            for (int i = 0; i < NumStudents; i++)
            {
                marks[i] = InputMark($"Enter mark for student {i + 1}: ");
            }
            
            Console.WriteLine();
            prompt();
        }

        public int InputMark(string prompt)
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
                    Console.WriteLine($"Invalid input: {input}. Please enter a valid whole number between {MinMark} and {MaxMark} (inclusive).");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
            } while (!isValidInput);

            return mark;
        }

        // Method to Output the students' marks with their respective grades
        public void OutputMarks()
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

            Console.WriteLine();
            prompt();
        }

        // Method to output the statistics of the grades
        public void OutputStatistics()
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

            Console.WriteLine();
            prompt();
        }

        // Method to output the grade profile
        public void OutputGradeProfile()
        {        
            int[] gradeCounts = new int[5];
            int totalMarks = marks.Length;
            
            foreach (int mark in marks)
            {
                if (mark >= 70)
                {
                    gradeCounts[0]++;
                }
                else if (mark >= 60)
                {
                    gradeCounts[1]++;
                }
                else if (mark >= 50)
                {
                    gradeCounts[2]++;
                }
                else if (mark >= 40)
                {
                    gradeCounts[3]++;
                }
                else
                {
                    gradeCounts[4]++;
                }
            }
        
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n\nGrade Profile\n");
            
            // Calculate and display percentage of each grade and number of students
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"A (First Class): {(double)gradeCounts[0]/totalMarks*100}%, {gradeCounts[0]} student{(gradeCounts[0] == 1 ? "" : "s")}");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"B (Upper Second Class): {(double)gradeCounts[1]/totalMarks*100}%, {gradeCounts[1]} student{(gradeCounts[1] == 1 ? "" : "s")}");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"C (Lower Second Class): {(double)gradeCounts[2]/totalMarks*100}%, {gradeCounts[2]} student{(gradeCounts[2] == 1 ? "" : "s")}");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"D (Third Class): {(double)gradeCounts[3]/totalMarks*100}%, {gradeCounts[3]} student{(gradeCounts[3] == 1 ? "" : "s")}");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"F (Fail): {(double)gradeCounts[4]/totalMarks*100}%, {gradeCounts[4]} student{(gradeCounts[4] == 1 ? "" : "s")}");
        
            Console.WriteLine();
            prompt();
        }

        

        // Classifying Grades
        public string ClassifyGrade(int mark)
        {
            if (mark >= 70) 
            {
                Console.ForegroundColor = ConsoleColor.Green;
                return "- A (First Class)";
            }
            else if (mark >= 60) 
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
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
