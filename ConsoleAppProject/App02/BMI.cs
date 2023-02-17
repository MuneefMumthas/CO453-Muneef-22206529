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

        public void Run()
        {

            InputWeight();
            InputHeight();

            CalculateBMI();
            OutputResult();
        }

        // Prompts user to enter their weight
        private void InputWeight()
        {
            Console.Write("Enter your weight in kilograms: ");
            weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
        }

        // Prompts user to enter their height
        private void InputHeight()
        {
            Console.Write("Enter your height in meters: ");
            height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
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