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
        private double weight;
        private double height;
        private double bmi;
        private string units;

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
                    Console.WriteLine("Error: Invalid input. Please enter 1 or 2.");
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
                Console.Write($"Enter your weight in {(units == "metric" ? "kilograms" : "pounds")}: ");
                if (double.TryParse(Console.ReadLine(), out double result) && result > 0)
                {
                    weight = result;
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Error: Invalid input. Please enter a positive number.");
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
                Console.Write($"Enter your height in {(units == "metric" ? "meters" : "inches")}: ");
                if (double.TryParse(Console.ReadLine(), out double result) && result > 0)
                {
                    height = result;
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Error: Invalid input. Please enter a positive number.");
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
            Console.WriteLine($"Your BMI is {bmi:f2}");

            if (bmi < 18.5)
            {
                Console.WriteLine("You are underweight");
            }
            else if (bmi < 25)
            {
                Console.WriteLine("You have a normal weight");
            }
            else if (bmi < 30)
            {
                Console.WriteLine("You are overweight");
            }
            else if (bmi < 35)
            {
                Console.WriteLine("You are Obese Class I");
            }
            else if (bmi < 40)
            {
                Console.WriteLine("You are Obese Class II");
            }
            else if (bmi >= 40)
            {
                Console.WriteLine("You are Obese Class III");
            }
            Console.WriteLine();
        }
    }
}