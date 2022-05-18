using System;
using System.Collections.Generic;

namespace TryCatch_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Integers = new List<int>();
            Integers.Add(10);
            Integers.Add(20);
            Integers.Add(40);
            Integers.Add(80);
            Integers.Add(160);

            try
            {
                Console.WriteLine("Select a number to divide the integers by.");
                int divideBy = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < Integers.Count; i++)
                {
                    int result = Integers[i] / divideBy;
                    Console.WriteLine(result);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number.");
            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't attempt to add by zero.");
            }
        }
    }
}
