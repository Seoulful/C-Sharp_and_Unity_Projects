using System;

namespace Income_Comparison_Project
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            int Person_1_Rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int Person_1_Hours_per_Week = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            int Person_2_Rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int Person_2_Hours_per_Week = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Annual Salary of Person 1:");
            int Person_1_Salary = Person_1_Rate * Person_1_Hours_per_Week * 52;
            Console.WriteLine(Person_1_Salary);

            Console.WriteLine("Annual Salary of Person 2:");
            int Person_2_Salary = Person_2_Rate * Person_2_Hours_per_Week * 52;
            Console.WriteLine(Person_2_Salary);

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool greaterthan = Person_1_Salary > Person_2_Salary;
            Console.WriteLine(greaterthan);

            Console.ReadLine();
        }
    }
}
