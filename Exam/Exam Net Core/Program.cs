using System;
using System.Collections.Generic;
using System.Text;

namespace Exam_Net_Core
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string text = "Ось будинок, який побудував Джек. А це пшениця, Яка в темній комірці зберігається У будинку, Який побудував Джек. А це весела птиця-синиця, Яка часто краде пшеницю, Яка в темній комірці зберігається У будинку, Який побудував Джек.";
            string new_text = text;
            new_text.Trim(new char[] {'.', ','});

            int counter = 0, unique_counter = 0;
            Dictionary<string, int> dictionary = new Dictionary<string, int>(50);
            string tmp = null;
            for (int i = 0; i < new_text.Length; i++)
            {
                if (new_text[i] == ' ')
                {
                    int value = 0;
                    foreach (var item in dictionary)
                    {
                        if (item.Key == tmp)
                        {
                            value = item.Value;
                            ++value;
                        }
                    }
                    if (value != 0)
                    {
                        dictionary[tmp] = value;
                    }
                    else
                    {
                        dictionary.Add(tmp, 1);
                        ++unique_counter;
                    }
                    tmp = null;
                }
                else
                {
                    tmp += new_text[i];
                }
            }

            foreach (var item in dictionary)
            {
                counter += item.Value;
            }

            int nums = 1;
            Console.WriteLine($"{"Слово : ",20} {"Кілк. : ",20}");
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{nums}. {item.Key,20} {item.Value,20}");
                ++nums;
            }
            Console.WriteLine($"Всього слів : {counter}.\t\tВсього унікальних слів : {unique_counter}.");
        }
    }
}
