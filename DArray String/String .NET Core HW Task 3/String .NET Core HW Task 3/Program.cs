using System;
using System.Linq;

namespace String_.NET_Core_HW_Task_3
{
    class Program
    {
        static void MeetingOfLetters(String str)
        {
            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[][] countLetter = new char[0][];
            int index = 0;

            foreach (var letter in letters)
            {
                int count = str.Count((e) => e.Equals(letter));

                if (count != 0)
                {
                    Array.Resize(ref countLetter, countLetter.Length + 1);
                    Array.Resize(ref countLetter[index], count);
                    countLetter[index][0] = letter;
                    ++index;
                }
            }

            foreach (var let in countLetter)
            {
                int count = 0;
                for (int i = 0; i < let.Length; i++)
                {
                    count++;
                }
                Console.Write(let[0]);
                Console.Write($" [{count}] ");
                for (int i = 0; i < let.Length; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void Main()
        {
            String str = "I don’t know whether to delete this or rewrite it";
            MeetingOfLetters(str);
        }
    }
}
