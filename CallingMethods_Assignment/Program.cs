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

            Methods.Method1(input);
            Methods.Method2(input);
            Methods.Method3(input);
            Console.ReadLine();
        }
    }
}
