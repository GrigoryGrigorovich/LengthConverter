using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LengthConverter
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please enter your length in format like 10ft, 10m, 10in");
            string input = Console.ReadLine();

            // Split the input into two parts 
            string[] parts = input.Split(' ');

            // Check if the first part is a number 
            double number;
            if (!double.TryParse(parts[0], out number))
            {
                Console.WriteLine("Invalid input!");
                return;
            }

            // Get the unit from the second part of the input 
            string unit = parts[1];

            // Convert to meters 
            double resultInMeters;

            //Check for unit type and convert accordingly             
            switch (unit)
            {
                case "ft": resultInMeters = number * 0.3048; break;  // Feet to meter conversion factor is 0.3048                            

                case "in": resultInMeters = number * 0.0254; break; // Inch to meter conversion factor is 0.0254  

                case "m": resultInMeters = number; break;          // Meter to meter conversion factor is 1  

                default: Console.WriteLine("Invalid unit!"); return;    // Invalid unit entered  

            }

            Console.WriteLine($"{number} {unit} is equal to {resultInMeters} m");     // Prints the converted value in meters  
            
            Console.ReadLine();
        }            
    }       
}
