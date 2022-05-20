using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod_Assignment
{
    public class Method
    {
        public int mainMethod(int input)
        {
            return input * 2;
        }

        public decimal mainMethod(decimal input)
        {
            return input / 5;
        }

        public int mainMethod(string input)
        {
            int inputInt = Convert.ToInt32(input);
            return inputInt + 3;
        }
    }
}
