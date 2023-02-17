using System;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// This app calculates the Body Mass Index (BMI)
    /// </summary>
    /// <author>
    /// Student Name version 0.1
    /// </author>
    public class BMI
    {
        private double weight;
        private double height;
        private double bmi;

        public void Run()
        {
            Console.WriteLine("BMI Calculator\n");

            InputWeight();
            InputHeight();

            CalculateBMI();
            OutputResult();
        }

        private void InputWeight()
        {
            Console.Write("Enter your weight in kilograms: ");
            weight = Convert.ToDouble(Console.ReadLine());
        }

        private void InputHeight()
        {
            Console.Write("Enter your height in meters: ");
            height = Convert.ToDouble(Console.ReadLine());
        }

        private void CalculateBMI()
        {
            bmi = weight / (height * height);
        }

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
            else
            {
                Console.WriteLine("You are obese");
            }
        }
    }
}