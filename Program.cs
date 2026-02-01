using System;

namespace _4NumbersFindingAverage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the 1st number:");
            int num1 = ValidateInt();

            Console.WriteLine("Enter the 2nd number:");
            int num2 = ValidateInt();

            Console.WriteLine("Enter the 3rd number:");
            int num3 = ValidateInt();

            Console.WriteLine("Enter the 4th number:");
            int num4 = ValidateInt();

            int total;
            double average;

            // the method 
            CalculateTotalAndAverage(out total, out average, num1, num2, num3, num4);

            Console.WriteLine($"The total of the numbers provided is {total}");
            Console.WriteLine($"The average of the numbers provided is {average}");

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        static void CalculateTotalAndAverage(out int total, out double average, params int[] numbers)
        {
            total = 0;

            foreach (int num in numbers)
            {
                total += num;
            }

            average = (double)total / numbers.Length;
        }

        static int ValidateInt()
        {
            int x;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out x))
                    return x;

                Console.WriteLine("Invalid input please enter a number!");
            }
        }
    }
}














