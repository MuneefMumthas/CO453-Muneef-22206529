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
        public const int MILES_IN_FEET = 5280;
        public const double FEET_IN_METERS = 0.3048;
        public int FromUnit { get; private set; }
        public int ToUnit { get; private set; }
        public double Distance { get; private set; }
        public double Result { get; private set; }

        public void Run()
        {
            // Prompts user to select unit to convert from
            Console.WriteLine("Please select the unit to convert from:");
            Console.WriteLine("1. Miles");
            Console.WriteLine("2. Feet");
            Console.WriteLine("3. Meters");
            Console.WriteLine();
            Console.Write("Answer: ");
            FromUnit = Convert.ToInt32(GetValidOption());
            Console.WriteLine();

            // Prompts user to select unit to convert to
            Console.WriteLine("Please select the unit to convert to:");
            Console.WriteLine("1. Miles");
            Console.WriteLine("2. Feet");
            Console.WriteLine("3. Meters");
            Console.WriteLine();
            Console.Write("Answer: ");
            ToUnit = Convert.ToInt32(GetValidOption());
            Console.WriteLine();
            
            // Error message for selecting the same unit and a prompt to select a different unit to convert to
            while (FromUnit == ToUnit)
            {
            Console.WriteLine("Error: You cannot convert the same unit.");    
            Console.WriteLine("Please select a different unit to convert to:");
            Console.WriteLine("1. Miles");
            Console.WriteLine("2. Feet");
            Console.WriteLine("3. Meters");
            Console.WriteLine();
            Console.Write("Answer: ");
            ToUnit = Convert.ToInt32(GetValidOption());
            Console.WriteLine();
            }


            // Prompts user to input Distance
            Console.Write("Please enter the Distance: ");
            string input = Console.ReadLine();

            while (true)
            {
                try
                {
                    Distance = Convert.ToDouble(input);
                    if (Distance < 0)
                    {
                     throw new Exception("Distance cannot be negative.");
                    }
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Invalid input. Please enter a valid numerical value.");
                    input = Console.ReadLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message + " Please enter a positive number: ");
                    input = Console.ReadLine();
                }
            }

            // Conversion process and output
            switch (FromUnit)
            {
                case 1: // Converting From Miles
                    if (ToUnit == 2)
                    {
                        Result = Distance * MILES_IN_FEET;
                        Console.WriteLine();
                        Console.WriteLine(Distance + (Distance == 1 ? " mile" : " miles") + " is " + Result + (Result == 1 ? " foot" : " feet") + ".");
                        Console.WriteLine();
                    }
                    else if (ToUnit == 3)
                    {
                        Result = Distance * MILES_IN_FEET * FEET_IN_METERS;
                        Console.WriteLine();
                        Console.WriteLine(Distance + (Distance == 1 ? " mile" : " miles") + " is " + Result + (Result == 1 ? " meter" : " meters") + ".");
                        Console.WriteLine();
                    }
                    break;
                case 2: // Converting From Feet
                    if (ToUnit == 1)
                    {
                        Result = Distance / MILES_IN_FEET;
                        Console.WriteLine();
                        Console.WriteLine(Distance + (Distance == 1 ? " foot" : " feet") + " is " + Result + (Result == 1 ? " mile" : " miles") + ".");
                        Console.WriteLine();
                    }
                    else if (ToUnit == 3)
                    {
                        Result = Distance * FEET_IN_METERS;
                        Console.WriteLine();
                        Console.WriteLine(Distance + (Distance == 1 ? " foot" : " feet") + " is " + Result + (Result == 1 ? " meter" : " meters") + ".");
                        Console.WriteLine();
                    }
                    break;
                case 3: // Converting From Meters
                    if (ToUnit == 1)
                    {
                        Result = Distance / MILES_IN_FEET / FEET_IN_METERS;
                        Console.WriteLine();
                        Console.WriteLine(Distance + (Distance == 1 ? " meter" : " meters") + " is " + Result + (Result == 1 ? " mile" : " miles") + ".");
                        Console.WriteLine();
                    }
                    else if (ToUnit == 2)
                    {
                        Result = Distance / FEET_IN_METERS;
                        Console.WriteLine();
                        Console.WriteLine(Distance + (Distance == 1 ? " meter" : " meters") + " is " + Result + (Result == 1 ? " foot" : " feet") + ".");
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