using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Assignment
{
    public class Employee : Person, IQuittable
    {
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }

        public void Quit(Employee employee)
        {
            Console.WriteLine(FirstName + " " + LastName + " has quit.");
        }

        public static bool operator== (Employee employee1, Employee employee2)
        {
            return (employee1.ID == employee2.ID);
        }
        public static bool operator!= (Employee employee1, Employee employee2)
        {
            return (employee1.ID == employee2.ID);
        }
    }
}
