using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input an integer.");
            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input another integer.");
            int input2 = Convert.ToInt32(Console.ReadLine());
            var result = new Method();

            result.mainMethod(input1: input1, input2: input2);
            Console.ReadLine();
        }
    }
}
