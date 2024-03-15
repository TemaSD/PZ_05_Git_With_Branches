using System;

namespace PZ_05_Git_With_Branches
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Завдання 2

            Random generator = new Random();

            int ammount = 0;

            int[] numbers = new int[25];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = generator.Next(0, 100);

                if (numbers[i] % 2 == 0)
                {
                    ammount++;
                }
            }

            Console.WriteLine($"Arrays include {ammount} pair numbers.");

            Console.Write("It's: ");

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                    Console.Write(numbers[i]);
                if (i == numbers.Length - 1)
                {
                    Console.Write("."); //"." in the end
                    break;
                }
                if (numbers[i] % 2 == 0)
                    Console.Write(", "); //"," between numbers
            }
        }
    }
}
