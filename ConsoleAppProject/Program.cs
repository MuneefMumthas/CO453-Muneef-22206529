using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
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
    /// [Your Name Here]
    /// </summary>
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine();
            Console.WriteLine(" =================================================");
            Console.WriteLine("    BNU CO453 Applications Programming 2022-2023! ");
            Console.WriteLine("                App01 & App02                     ");
            Console.WriteLine("        By: Muneef Mumthas - 22206529             ");
            Console.WriteLine(" =================================================");
            Console.WriteLine();

            Console.WriteLine("Which application would you like to run? (1-2)");
            Console.WriteLine("1. Distance Converter");
            Console.WriteLine("2. BMI Calculator");
            Console.WriteLine();
            Console.Write("Answer: ");

            int appNumber = 0;
            while (appNumber == 0)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out int result) && (result == 1 || result == 2))
                {
                    appNumber = result;
                }
                else
                {
                    Console.WriteLine("Please enter a valid input (1-2).");
                }
            }

            if (appNumber == 1)
            {

            Console.WriteLine();
            Console.WriteLine("=========================================");
            Console.WriteLine("       App01 - Distance Converter        ");
            Console.WriteLine("      By: Muneef Mumthas - 22206529      ");
            Console.WriteLine("=========================================");
            Console.WriteLine();

                DistanceConverter converter = new DistanceConverter();
                converter.Run();
            }
            else if (appNumber == 2)
            {
            
            Console.WriteLine();
            Console.WriteLine("==================================================");
            Console.WriteLine("     App02 - Body Mass Index (BMI) Calculator     ");
            Console.WriteLine("          By: Muneef Mumthas - 22206529           ");
            Console.WriteLine("==================================================");
            Console.WriteLine();

                BMI bmiCalculator = new BMI();
                bmiCalculator.Run();
            }
            else
            {
                Console.WriteLine("Invalid input. Press any key to exit.");
                Console.ReadKey();
            }
        }
    }
}
