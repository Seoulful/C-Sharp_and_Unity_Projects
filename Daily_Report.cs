using System;

namespace Daily_Report_Project
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            Console.WriteLine("What is your name?");
            string Name = Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string Course = Console.ReadLine();

            Console.WriteLine("What page number?");
            string Page_Number = Console.ReadLine();
            int pg_num = Convert.ToInt32(Page_Number);

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string Help = Console.ReadLine();
            bool help = Convert.ToBoolean(Help);

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string Positive_Experiences = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string Other_Feedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string Hours_Studied = Console.ReadLine();
            int hrs_studied = Convert.ToInt32(Hours_Studied);

            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
