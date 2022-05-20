using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int input1 = 10;
            decimal input2 = 22.5m;
            string input3 = "4";
            var result = new Method();

            Console.WriteLine("10 multiplied by 2 is: " + result.mainMethod(input1));
            Console.WriteLine("22.5 divided by 5 is: " + result.mainMethod(input2));
            Console.WriteLine("The string \"4\" converted to an integer, then added to 3 is: " + result.mainMethod(input3));
            Console.ReadLine();
        }
    }
}
