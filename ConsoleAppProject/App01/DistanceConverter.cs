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
        const int MILES_TO_FEET = 5280;
        const double FEET_TO_METERS = 0.3048;
        string input;
        double distance;
        double result;

        public void Run()
        {
            // Prompt user to select unit to convert from
            Console.WriteLine("Please select the unit to convert from:");
            Console.WriteLine("1. Miles");
            Console.WriteLine("2. Feet");
            Console.WriteLine("3. Meters");

            int fromUnit = Convert.ToInt32(Console.ReadLine());

            // Prompt user to select unit to convert to
            Console.WriteLine("Please select the unit to convert to:");
            Console.WriteLine("1. Miles");
            Console.WriteLine("2. Feet");
            Console.WriteLine("3. Meters");

            int toUnit = Convert.ToInt32(Console.ReadLine());

            if (fromUnit == toUnit)
            {
                Console.WriteLine("Error: You cannot convert the same unit.");
                return;
            }

            // Step 1: Input distance
            Console.WriteLine("Please enter the distance: ");
            input = Console.ReadLine();

            try
            {
                distance = Convert.ToDouble(input);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid distance entered. Please enter a valid numerical value.");
                return;
            }

            // Step 2: Conversion process
            switch (fromUnit)
            {
                case 1: // Miles
                    if (toUnit == 2)
                    {
                        result = distance * MILES_TO_FEET;
                        Console.WriteLine(distance + " miles is " + result + " feet.");
                    }
                    else if (toUnit == 3)
                    {
                        result = distance * MILES_TO_FEET * FEET_TO_METERS;
                        Console.WriteLine(distance + " miles is " + result + " meters.");
                    }
                    break;
                case 2: // Feet
                    if (toUnit == 1)
                    {
                        result = distance / MILES_TO_FEET;
                        Console.WriteLine(distance + " feet is " + result + " miles.");
                    }
                    else if (toUnit == 3)
                    {
                        result = distance * FEET_TO_METERS;
                        Console.WriteLine(distance + " feet is " + result + " meters.");
                    }
                    break;
                case 3: // Meters
                    if (toUnit == 1)
                    {
                        result = distance / MILES_TO_FEET / FEET_TO_METERS;
                        Console.WriteLine(distance + " meters is " + result + " miles.");
                    }
                    else if (toUnit == 2)
                    {
                        result = distance / FEET_TO_METERS;
                        Console.WriteLine(distance + " meters is " + result + " feet.");
                    }
                    break;
            }
        }
    }
}
