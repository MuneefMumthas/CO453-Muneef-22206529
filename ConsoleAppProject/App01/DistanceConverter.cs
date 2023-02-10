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
        string input;
        double distance;
        double result;

        public void Run()
        {
            // Prompt user to select unit to convert from
            Console.WriteLine("Please select the unit to convert from:");
            Console.WriteLine("1. Miles");
            Console.WriteLine("2. Feet");

            int fromUnit = Convert.ToInt32(Console.ReadLine());

            // Prompt user to select unit to convert to
            Console.WriteLine("Please select the unit to convert to:");
            Console.WriteLine("1. Miles");
            Console.WriteLine("2. Feet");

            int toUnit = Convert.ToInt32(Console.ReadLine());

            if (fromUnit == toUnit)
            {
                Console.WriteLine("Error: You cannot convert the same unit.");
                return;
            }

            // Step 1: Input distance
            Console.WriteLine("Please enter the distance: ");
            input = Console.ReadLine();
            distance = Convert.ToDouble(input);

            // Step 2: Conversion process
            switch (fromUnit)
            {
                case 1: // Miles
                    if (toUnit == 2)
                    {
                        result = distance * MILES_TO_FEET;
                        Console.WriteLine(distance + " miles is " + result + " feet.");
                    }
                    break;
                case 2: // Feet
                    if (toUnit == 1)
                    {
                        result = distance / MILES_TO_FEET;
                        Console.WriteLine(distance + " feet is " + result + " miles.");
                    }
                    break;
            }
        }
    }
}
