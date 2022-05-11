using System;

namespace Branching_Assignment_Project
{
    class Program
    {
        static void Main()
        {
            int maxWeight = 50;

            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("Please enter the package weight: ");
            int packageWeight = Convert.ToInt32(Console.ReadLine());

            if (packageWeight > maxWeight)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Please enter the package width: ");
                int packageWidth = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the package height: ");
                int packageHeight = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the package length: ");
                int packageLength = Convert.ToInt32(Console.ReadLine());

                if (packageWidth + packageHeight + packageLength > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
                    Console.ReadLine();
                }

                else
                {
                    decimal packageQuote = packageWidth * packageHeight * packageLength * packageWeight / 100;

                    Console.WriteLine("Your estimated total for shipping this package is: $" + packageQuote);
                    Console.WriteLine("Thank you!");
                    Console.ReadLine();
                }
            }
        }
    }
}
