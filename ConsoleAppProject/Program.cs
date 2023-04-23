using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using ConsoleAppProject.App04;
using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start App01 to App05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Muneef Mumthas - 22206529
    /// </summary>
    public static class Program
    {
        public static void Main(string[] args)
        {

            /// General Heading
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine(" =================================================");
            Console.WriteLine("    BNU CO453 Applications Programming 2022-2023! ");
            Console.WriteLine("                App01 & App04                     ");
            Console.WriteLine("        By: Muneef Mumthas - 22206529             ");
            Console.WriteLine(" =================================================");
            Console.WriteLine();

            /// Prompt to choose the apps
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Which application would you like to run? (1-4)");
            Console.WriteLine("1. Distance Converter");
            Console.WriteLine("2. BMI Calculator");
            Console.WriteLine("3. Student Grades");
            Console.WriteLine("4. Social Network");
            Console.WriteLine();
            Console.Write("Answer: ");

    /// Error message for entering invalid input  
            int appNumber = 0;
            while (appNumber == 0)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out int result) && (result == 1 || result == 2 || result == 3 || result == 4))
                {
                    appNumber = result;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Please enter a valid input (1-4).");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
            }

    /// Run App01 with a subheading  
            if (appNumber == 1)
            {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine("=========================================");
            Console.WriteLine("       App01 - Distance Converter        ");
            Console.WriteLine("      By: Muneef Mumthas - 22206529      ");
            Console.WriteLine("=========================================");
            Console.WriteLine();

                DistanceConverter converter = new DistanceConverter();
                converter.Run();
            }
            
    /// Run App02 with a subheading  
            else if (appNumber == 2)
            {  
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine("==================================================");
            Console.WriteLine("     App02 - Body Mass Index (BMI) Calculator     ");
            Console.WriteLine("          By: Muneef Mumthas - 22206529           ");
            Console.WriteLine("==================================================");
            Console.WriteLine();

                BMI bmiCalculator = new BMI();
                bmiCalculator.Run();
            }
    
    /// Run App03 with a subheading  
            else if (appNumber == 3)
            {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine("=========================================");
            Console.WriteLine("         App03 - Student Grades          ");
            Console.WriteLine("      By: Muneef Mumthas - 22206529      ");
            Console.WriteLine("=========================================");
            Console.WriteLine();

                StudentGrades studentGrades = new StudentGrades();
                studentGrades.Run();
            }

    /// Run App04 with a subheading  
            else if (appNumber == 4)
            {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine("=========================================");
            Console.WriteLine("         App04 - Social Network          ");
            Console.WriteLine("      By: Muneef Mumthas - 22206529      ");
            Console.WriteLine("=========================================");
            Console.WriteLine();

                SocialNetwork socialNetwork = new SocialNetwork();
                socialNetwork.Run();
            }
        }
    }
}
