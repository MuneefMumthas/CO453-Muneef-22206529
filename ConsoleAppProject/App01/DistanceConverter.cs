using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Distance Converter that converts user inputs into preferred units
    /// </summary>
    /// <author>
    /// Muneef Mumthas - 22206529
    /// </author>
    public class DistanceConverter
    {
        const int MILES_IN_FEET = 5280;
        const double FEET_IN_METERS = 0.3048;
        string input;
        double distance;
        double result;

        public void Run()
        {
            // Prompts user to select unit to convert from
            Console.WriteLine("Please select the unit to convert from:");
            Console.WriteLine("1. Miles");
            Console.WriteLine("2. Feet");
            Console.WriteLine("3. Meters");
            Console.WriteLine();
            Console.Write("Answer: ");
            int fromUnit = Convert.ToInt32(GetValidOption());
            Console.WriteLine();

            // Prompts user to select unit to convert to
            Console.WriteLine("Please select the unit to convert to:");
            Console.WriteLine("1. Miles");
            Console.WriteLine("2. Feet");
            Console.WriteLine("3. Meters");
            Console.WriteLine();
            Console.Write("Answer: ");
            int toUnit = Convert.ToInt32(GetValidOption());
            Console.WriteLine();
            
            // Error message for selecting same units

            if (fromUnit == toUnit)
            {
                Console.WriteLine("Error: You cannot convert the same unit.");
                Console.WriteLine();
                return;
            }

            // Prompts user to input distance
            Console.Write("Please enter the distance: ");
            input = Console.ReadLine();

            while (true)
            {
                try
                {
                    distance = Convert.ToDouble(input);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Invalid distance entered. Please enter a valid numerical value.");
                    input = Console.ReadLine();
                }
            }

            // Conversion process and output
            switch (fromUnit)
            {
                case 1: // Converting From Miles
                    if (toUnit == 2)
                    {
                        result = distance * MILES_IN_FEET;
                        Console.WriteLine();
                        Console.WriteLine(distance + " miles is " + result + " feet.");
                        Console.WriteLine();
                    }
                    else if (toUnit == 3)
                    {
                        result = distance * MILES_IN_FEET * FEET_IN_METERS;
                        Console.WriteLine();
                        Console.WriteLine(distance + " miles is " + result + " meters.");
                        Console.WriteLine();
                    }
                    break;
                case 2: // Converting From Feet
                    if (toUnit == 1)
                    {
                        result = distance / MILES_IN_FEET;
                        Console.WriteLine();
                        Console.WriteLine(distance + " feet is " + result + " miles.");
                        Console.WriteLine();
                    }
                    else if (toUnit == 3)
                    {
                        result = distance * FEET_IN_METERS;
                        Console.WriteLine();
                        Console.WriteLine(distance + " feet is " + result + " meters.");
                        Console.WriteLine();
                    }
                    break;
                case 3: // Converting From Meters
                    if (toUnit == 1)
                    {
                        result = distance / MILES_IN_FEET / FEET_IN_METERS;
                        Console.WriteLine();
                        Console.WriteLine(distance + " meters is " + result + " miles.");
                        Console.WriteLine();
                    }
                    else if (toUnit == 2)
                    {
                        result = distance / FEET_IN_METERS;
                        Console.WriteLine();
                        Console.WriteLine(distance + " meters is " + result + " feet.");
                        Console.WriteLine();
                    }
                    break;
            }
                    
        }
        // validating/restricting user inputs
        private int GetValidOption()
        {
            int option;
            string input = Console.ReadLine();
            try
            {
            option = Convert.ToInt32(input);
            if (option < 1 || option > 3)
            {
            throw new Exception();
            }
            }
            catch (Exception)
            {
            Console.WriteLine("Error: Invalid option entered. Please enter a number between 1 and 3.");
            option = GetValidOption();
            }
            return option;
        }

    }
}