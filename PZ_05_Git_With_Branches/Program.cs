using System;

namespace PZ_05_Git_With_Branches
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Завдання 1

            int[] numbers = new int[50];

            int a = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                a += 2;
                numbers[i] = a;
                Console.WriteLine($"Element: {a}");
            }
        }
    }
}
