using System;
using System.Collections.Generic;

namespace Arrays_Assignment
{
    class Program
    {
        static void Main()
        {
            string[] stringArray = { "Mary", "John", "Ben", "Chris", "Sarah" };
            Console.WriteLine("Select a string in the array. (0 - 4)");
            int selectedStringIndex = Convert.ToInt32(Console.ReadLine());
            if (selectedStringIndex > 4)
            {
                Console.WriteLine("Please select a valid index.");
            }
            else
            {
                string stringIndex = stringArray[selectedStringIndex];
                Console.WriteLine(stringIndex);
            }
            

            int[] intArray = { 5, 10, 20, 40, 80, 160, 320 };
            Console.WriteLine("Select an integer in the array. (0 - 6)");
            int selectedIntIndex = Convert.ToInt32(Console.ReadLine());
            if (selectedIntIndex > 6)
            {
                Console.WriteLine("Please select a valid index.");
            }
            else
            {
                int intIndex = intArray[selectedIntIndex];
                Console.WriteLine(intIndex);
            }

            List<string> stringList = new List<string>();
            stringList.Add("Microsoft");
            stringList.Add("Apple");
            stringList.Add("Google");
            stringList.Add("IBM");
            Console.WriteLine("Select a string in the list. (0 - 3)");
            int selectedListIndex = Convert.ToInt32(Console.ReadLine());
            if (selectedListIndex > 3)
            {
                Console.WriteLine("Please select a valid index.");
            }
            else
            {
                string stringListIndex = stringList[selectedListIndex];
                Console.WriteLine(stringListIndex);
            }

        }
    }
}
