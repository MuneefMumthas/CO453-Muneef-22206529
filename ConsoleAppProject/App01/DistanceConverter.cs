using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Distance Converter that converts user inputs into prefered units
    /// </summary>
    /// <author>
    /// Muneef Mumthas - 22206529
    /// </author>
    public class DistanceConverter
    {
        const int MILES_TO_FEET = 5280;
        string input;
        int miles;
        int feet;


        public DistanceConverter()
        {
            
        }
        public void Run()
        {
            //Miles to Feet
            
            //step 1 Input Miles

            Console.WriteLine("Please enter the number of miles: ");
            input = Console.ReadLine();
            miles = Convert.ToInt32(input);
            Console.WriteLine("Miles entered is: " + miles);

            // step 2 Convertion process
            
            feet = miles * MILES_TO_FEET;

            // step 3 Output Feet
            Console.WriteLine(miles + " miles is " + feet + " feet.");

            //Feet to Miles

            //step 1 Input Feet
            Console.WriteLine("Please enter the number of feet: ");
            input = Console.ReadLine();
            feet = Convert.ToInt32(input);
            Console.WriteLine("Feet entered is: " + feet);

            // step 2 Convertion process
            miles = feet / MILES_TO_FEET;

            // step 3 Output Miles
            Console.WriteLine(feet + " feet is " + miles + " miles.");


        }

    }
}
