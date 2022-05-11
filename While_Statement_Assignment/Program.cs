using System;

namespace While_Statement_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input your name.");
            string name = Console.ReadLine();
            bool authorizedUser = name == "Glenn";

            //while (!authorizedUser)
            //{
            //    switch (name)
            //    {
            //        default:
            //            Console.WriteLine("You are not an authorized user.");
            //            Console.WriteLine("Please input a different name.");
            //            name = Console.ReadLine();
            //            break;
            //        case "Glenn":
            //            Console.WriteLine("Welcome, Glenn.");
            //            authorizedUser = true;
            //            break;
            //    }
            //}
            do
            {
                switch (name)
                {
                    default:
                        Console.WriteLine("You are not an authorized user.");
                        Console.WriteLine("Please input a different name.");
                        name = Console.ReadLine();
                        break;
                    case "Glenn":
                        Console.WriteLine("Welcome, Glenn.");
                        authorizedUser = true;
                        break;
                }
            }
            while (!authorizedUser);

            Console.Read();
        }
    }
}
