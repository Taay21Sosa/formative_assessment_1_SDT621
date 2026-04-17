using System;
using System.Collections.Generic;
using System.Text;

namespace MunicipalitySystem.Utilities
{
    public class ValidationUtility
    {
        public int GetValidInteger(string prompt, int min, int max)
        {
            int value;
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out value) && value >= min && value <= max)
                {
                    return value;
                }

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Invalid input. Please enter a number between {min} and {max}.");
                Console.ResetColor();
            }
        }

        public double GetValidDouble(string prompt)
        {
            double value;
            while (true)
            {
                Console.Write(prompt);
                if (double.TryParse(Console.ReadLine(), out value) && value >= 0)
                {
                    return value;
                }

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input. Please enter a valid positive number.");
                Console.ResetColor();
            }
        }
    }
}
