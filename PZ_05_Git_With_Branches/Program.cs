using System;

namespace PZ_05_Git_With_Branches
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Завдання 4

            int asciiCode = 97;

            char[] sheet = new char[26];

            for (int i = 0; i < sheet.Length; i++)
            {
                sheet[i] = (char)asciiCode;

                Console.WriteLine($"{sheet[i]} - {asciiCode}");

                asciiCode++;
            }
        }
    }
}
