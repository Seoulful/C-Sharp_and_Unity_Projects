using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentTime = DateTime.Now;
            Console.WriteLine("It is currently {0}.", currentTime);

            Console.WriteLine("Please input a number.");
            int input = Convert.ToInt32(Console.ReadLine());

            DateTime userTime = currentTime.AddHours(input);
            Console.WriteLine("It will be {0} in {1} hours.", userTime, input);

            Console.ReadLine();
        }
    }
}
