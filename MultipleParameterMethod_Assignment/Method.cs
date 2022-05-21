using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleParameterMethod_Assignment
{
    class Method
    {
        public int mainMethod(int input1, int input2 = 0)
        {
            return input1 + input2;
        }
    }
}
