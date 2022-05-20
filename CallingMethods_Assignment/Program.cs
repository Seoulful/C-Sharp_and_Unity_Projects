using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input an integer.");
            int input = Convert.ToInt32(Console.ReadLine());
            var result = new Methods();

            Console.WriteLine("Your number multiplied by 2 is: " + result.Method1(input));
            Console.WriteLine("Your number added by 2 is: " + result.Method2(input));
            Console.WriteLine("Your number divided by 2 is: " + result.Method3(input));

            Console.ReadLine();
        }
    }
}
