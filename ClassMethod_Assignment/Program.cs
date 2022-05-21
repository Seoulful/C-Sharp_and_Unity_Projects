using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethod_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new Method();
            Console.WriteLine("Please input an integer.");
            int input = Convert.ToInt32(Console.ReadLine());

            result.mainMethod(input);
            Console.ReadLine();
        }
    }
}
