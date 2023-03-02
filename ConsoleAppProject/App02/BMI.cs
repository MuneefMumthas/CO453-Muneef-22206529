using System;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// This app calculates the Body Mass Index (BMI)
    /// According to the user inputs
    /// </summary>
    /// <author>
    /// Muneef Mumthas - 22206529
    /// </author>
    public class BMI
    {
        public double weight;
        public double height;
        public double bmi;
        public string units;

        public void Run()
        {
            InputUnits();
            InputWeight();
            InputHeight();

            CalculateBMI();
            OutputResult();
        }

        // Prompts user to select units
        private void InputUnits()
        {
            bool validInput = false;
            while (!validInput)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Select your preferred unit system:");
                Console.WriteLine("1. Metric");
                Console.WriteLine("2. Imperial");
                Console.WriteLine();
                Console.Write("Answer: ");
                string choice = Console.ReadLine();
        
                if (choice == "1")
                {
                    units = "metric";
                    validInput = true;
                }
                else if (choice == "2")
                {
                    units = "imperial";
                    validInput = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Error: Invalid input. Please enter 1 or 2.");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.WriteLine();
            }
        }


        // Prompts user to enter their weight
        private void InputWeight()
        {
            bool validInput = false;
            while (!validInput)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($"Enter your weight in {(units == "metric" ? "kilograms" : "stones, pounds")}: ");
        
                if (units == "metric")
                {
                    if (double.TryParse(Console.ReadLine(), out double result) && result > 0)
                    {
                        weight = result;
                        validInput = true;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Error: Invalid input. Please enter a positive number.");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }
                }
                else // imperial
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("Enter your weight in stones: ");
                    if (double.TryParse(Console.ReadLine(), out double stones) && stones >= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("Enter your weight in pounds: ");
                        if (double.TryParse(Console.ReadLine(), out double pounds) && pounds >= 0)
                        {
                            weight = stones * 14 + pounds;
                            validInput = true;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Error: Invalid input. Please enter a positive integer.");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Error: Invalid input. Please enter a positive integer.");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }
                }
        
                Console.WriteLine();
            }
        
            if (units == "imperial")
            {
                // Convert pounds to kilograms
                weight *= 0.45359237;
            }
        }

        // Prompts user to enter their height
        private void InputHeight()
        {
            bool validInput = false;
            while (!validInput)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($"Enter your height in {(units == "metric" ? "meters" : "feet, inches")}: ");

                if (units == "metric")
                {
                    if (double.TryParse(Console.ReadLine(), out double result) && result > 0)
                    {
                        height = result;
                        validInput = true;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Error: Invalid input. Please enter a positive number.");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }
                }
                else // imperial
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("Enter your height in feet: ");
                    if (double.TryParse(Console.ReadLine(), out double feet) && feet >= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("Enter your height in inches: ");
                        if (double.TryParse(Console.ReadLine(), out double inches) && inches >= 0)
                        {
                            height = feet * 12 + inches;
                            validInput = true;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Error: Invalid input. Please enter a positive integer.");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Error: Invalid input. Please enter a positive integer.");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }
                }

                Console.WriteLine();
            }
        
            if (units == "imperial")
            {
                // Convert inches to meters
                height *= 0.0254;
            }
        }


        // conversion process
        private void CalculateBMI()
        {
            bmi = weight / (height * height);
        }

        // Outputs WHO (World Health Organisation) weight status
        private void OutputResult()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"Your BMI is {bmi:f2}, ");

            if (bmi < 18.5)
            {
                Console.Write("You are underweight");
            }
            else if (bmi < 25)
            {
                Console.Write("You have a normal weight");
            }
            else if (bmi < 30)
            {
                Console.Write("You are overweight");
            }
            else if (bmi < 35)
            {
                Console.Write("You are Obese Class I");
            }
            else if (bmi < 40)
            {
                Console.Write("You are Obese Class II");
            }
            else if (bmi >= 40)
            {
                Console.Write("You are Obese Class III");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("If you are Black, Asian and Minority Ethnic (BAME) group,");
            Console.WriteLine("You may have a higher risk!");
            Console.WriteLine();
            Console.WriteLine("Adults 23.0 or more are at increased risk");
            Console.WriteLine("Adults 27.5 or more are at high risk");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
        }
    }
}