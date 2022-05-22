using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleParameterMethod_Assignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            var addTogether = new Method();
            Console.WriteLine("Please input an integer.");
            int input1 = Convert.ToInt32(Console.ReadLine());
            try
            {
                Console.WriteLine("Please input another integer. (optional, will default to 0)");
                int input2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Your two integers added together are: " + addTogether.mainMethod(input1, input2));
            }
            catch (FormatException)
            {
                int input2 = 0;
                Console.WriteLine("No number was chosen, the second integer will default to 0.");
                Console.WriteLine("Your two integers added together are: " + addTogether.mainMethod(input1, input2));
            }

            Console.ReadLine();
        }
    }
}
