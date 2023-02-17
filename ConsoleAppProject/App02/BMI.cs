using System;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Student Name version 0.1
    /// </author>
    public class BMI
    {private double weight;
        private double height;
        private double bmi;

        public void Run()
        {
            Console.WriteLine("BMI Calculator\n");

            InputWeight();
            InputHeight();


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


        }
    }

