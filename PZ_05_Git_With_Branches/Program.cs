using System;

namespace PZ_05_Git_With_Branches
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Завдання 3

            Console.Write("Write text: ");

            String dataInput = Console.ReadLine();

            Console.WriteLine($"Text \"{dataInput}\" include {dataInput.Length} symbols.");
        }
    }
}
