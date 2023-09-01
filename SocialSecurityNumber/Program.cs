using System;

namespace AgeGenderCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Personnummer (YYYYMMDD-XXXX): ");
            string input = Console.ReadLine();

            if (IsValidInput(input))
            {
                int birthYear = int.Parse(input.Substring(0, 4));
                int currentYear = DateTime.Now.Year;
                int age = currentYear - birthYear;

                char genderIndicator = input[input.Length - 2];
                string gender = (genderIndicator % 2 == 0) ? "Kvinna" : "Man";

                Console.Clear();
                Console.WriteLine($"{gender}, {age} år");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Ogiltigt personnummer!");
            }
        }

        static bool IsValidInput(string input)
        {
            if (input.Length != 13)
            {
                return false;
            }

            foreach (char c in input)
            {
                if (!char.IsDigit(c) && c != '-')
                {
                    return false;
                }
            }

            // You can implement more specific validation here, but this is a basic example.
            return true;
        }
    }
}
