using System;
using System.Collections.Generic;

namespace StringIterate
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = { "Hello", "Hi", "Goodbye", "Farewell" };

            Console.WriteLine("Please input your name.");
            string name = Console.ReadLine();

            //Part 1
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i] + " " + name);
            }

            for (int x = 0; x < stringArray.Length; x++)
            {
                Console.WriteLine(stringArray[x]);
            }

            //Part 2
            for (int y = 0; y < 3; y++)
            {
                Console.WriteLine("Hello, World!");
            }

            //Part 3
            for (int a = 0; a < 2; a++)
            {
                Console.WriteLine("This string loops until the variable is < 2!");
            }

            for (int b = 0; b <= 2; b++)
            {
                Console.WriteLine("This stringl oops until the variable is <= 2!");
            }

            //Part 4
            List<string> stringList = new List<string>();
            stringList.Add("apple");
            stringList.Add("banana");
            stringList.Add("grape");
            stringList.Add("strawberry");
            stringList.Add("pear");

            Console.WriteLine("Please select a fruit.");
            string userFruit = Console.ReadLine();
            int fruitIndex = stringList.IndexOf(userFruit);

            for (int i = 0; i < stringList.Count; i++)
            {
                if (userFruit == stringList[i])
                {
                    Console.WriteLine(fruitIndex);
                }
                else if (!stringList.Contains(userFruit))
                {
                    Console.WriteLine("That fruit is not in our index.");
                }
            }

            //Part 5
            List<string> stringListIdentical = new List<string>();
            stringListIdentical.Add("Google");
            stringListIdentical.Add("Microsoft");
            stringListIdentical.Add("Google");
            stringListIdentical.Add("Apple");

            Console.WriteLine("Please select a tech company.");
            string userTech = Console.ReadLine();
            int techIndex = stringListIdentical.IndexOf(userTech);

            for (int i = 0; i < stringListIdentical.Count; i++)
            {
                if (userTech == stringListIdentical[i])
                {
                    Console.WriteLine(techIndex);
                }
                else if (!stringListIdentical.Contains(userTech))
                {
                    Console.WriteLine("That tech company is not in our index.");
                }
            }

            //Part 6
            List<string> stringListForeach = new List<string>();
            stringListForeach.Add("Audi");
            stringListForeach.Add("Mercedes");
            stringListForeach.Add("BMW");
            stringListForeach.Add("Audi");

            foreach (string car in stringListForeach)
            {
                Console.WriteLine(car);
            }
        }
    }
}
