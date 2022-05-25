using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee employee = new Employee();
            //employee.FirstName = "Sample";
            //employee.LastName = "Student";
            //employee.SayName();

            //IQuittable employeeQuit = new Employee();
            //employee.Quit(employee);

            //Employee employee1 = new Employee();
            //employee1.ID = 0001;

            //Employee employee2 = new Employee();
            //employee2.ID = 0001;

            //bool compare = employee1 == employee2;
            //Console.WriteLine(compare);
            Employee<string> employee1 = new Employee<string>();
            employee1.Things = new List<string>() { "apple", "orange", "grape" };
            Employee<int> employee2 = new Employee<int>();
            employee2.Things = new List<int>() { 1, 2, 3 };
            
            for (int i = 0; i < employee1.Things.Count; i++)
            {
                Console.WriteLine(employee1.Things[i]);
            }

            for (int i = 0; i < employee2.Things.Count; i++)
            {
                Console.WriteLine(employee2.Things[i]);
            }

            Console.ReadLine();
        }
    }
}
