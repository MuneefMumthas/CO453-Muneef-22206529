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
    /// Muneef Mumthas
    /// </summary>
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine();
            Console.WriteLine(" =================================================");
            Console.WriteLine("    BNU CO453 Applications Programming 2022-2023! ");
            Console.WriteLine("                App01 to App05                    ");
            Console.WriteLine("        By: Muneef Mumthas - 22206529             ");
            Console.WriteLine(" =================================================");
            Console.WriteLine();

            Console.WriteLine("Which application would you like to run? (1-2)");
            Console.WriteLine("1. Distance Converter");
            Console.WriteLine("2. BMI Calculator");

            ConsoleKeyInfo keyPressed;
            do
            {
                keyPressed = Console.ReadKey(true);
            } while (keyPressed.Key != ConsoleKey.D1 && keyPressed.Key != ConsoleKey.D2);

            int appNumber = 0;
            switch (keyPressed.Key)
            {
                case ConsoleKey.D1:
                    appNumber = 1;
                    break;
                case ConsoleKey.D2:
                    appNumber = 2;
                    break;
            }

            if (appNumber == 1)
            {
                DistanceConverter converter = new DistanceConverter();
                converter.Run();
            }
            else if (appNumber == 2)
            {
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
