using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethod_Assignment
{
    class Method
    {
        public void mainMethod(int input)
        {
            int result = input / 2;
            Console.WriteLine(result);
        }

        public static string mainMethod(string input, out string output)
        {
            input = "Hello, World!";
            output = "Goodbye.";
            return input;
        }
    }
}
