using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Assignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Employees> employees = new List<Employees>();
            employees.Add(new Employees() { fname = "Joe", lname = "Hill", id = 1 });
            employees.Add(new Employees() { fname = "Joe", lname = "Sanchez", id = 2 });
            employees.Add(new Employees() { fname = "Mary", lname = "Sue", id = 3 });
            employees.Add(new Employees() { fname = "John", lname = "Doe", id = 4 });
            employees.Add(new Employees() { fname = "Jane", lname = "Doe", id = 5 });
            employees.Add(new Employees() { fname = "Frank", lname = "Lee", id = 6 });
            employees.Add(new Employees() { fname = "Sam", lname = "Kim", id = 7 });
            employees.Add(new Employees() { fname = "Michelle", lname = "Robin", id = 8 });
            employees.Add(new Employees() { fname = "Sarah", lname = "Park", id = 9 });
            employees.Add(new Employees() { fname = "James", lname = "Frank", id = 10 });

            List<Employees> joes = new List<Employees>();
            foreach (Employees allemployees in employees)
            {
                if (allemployees.fname == "Joe")
                {
                    joes.Add(new Employees() { fname = allemployees.fname, lname = allemployees.lname, id = allemployees.id });
                }
            }
            List<Employees> joesLambda = employees.Where(x => x.fname == "Joe").ToList();
            List<Employees> idsLambda = employees.Where(x => x.id > 5).ToList();
        }
    }
}
