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
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.SayName();

            IQuittable employeeQuit = new Employee();
            employee.Quit(employee);

            Employee employee1 = new Employee();
            employee1.ID = 0001;

            Employee employee2 = new Employee();
            employee2.ID = 0001;

            bool compare = employee1 == employee2;
            Console.WriteLine(compare);

            Console.ReadLine();
        }
    }
}
