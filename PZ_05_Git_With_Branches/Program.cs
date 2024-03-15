using System;

namespace PZ_05_Git_With_Branches
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Завдання 3.1 ускладнене

            Console.Write("Write text: ");

            String dataInput = Console.ReadLine();

            Console.Write("What symbol do you want to find? ");

            char charInput = Char.Parse(Console.ReadLine());

            int counter = 0;

            foreach (char simbol in dataInput)
            {
                if (simbol == charInput)
                {
                    counter++;
                }
            }

            Console.WriteLine($"Text \"{dataInput}\" include {dataInput.Length} symbols.");

            if (counter > 0)
                Console.WriteLine($"Your symbol \"{charInput}\" appears in the text {counter} times!");
            else
                Console.WriteLine($"There's no symbol \"{charInput}\" in your text.");
        }
    }
}
