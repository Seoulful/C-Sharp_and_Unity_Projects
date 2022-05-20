using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods_Assignment
{
    public class Methods
    {
        public static void Method1(int input)
        {
            int result = input * 2;
            Console.WriteLine("Your number multiplied by two is: " + result);
        }

        public static void Method2(int input)
        {
            int result = input + 3;
            Console.WriteLine("Your number added by 3 is: " + result);
        }

        public static void Method3(int input)
        {
            int result = input / 2;
            Console.WriteLine("Your number divided by 2 is: " + result);
        }
    }
}
