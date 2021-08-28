using System;
using System.Collections.Generic;

namespace Task_Exam_2
{
    class Program
    {
        // Dictionary
        static void Main(string[] args)
        {
            List<string> lsecond = new List<string>();
            lsecond.Add("qwe");

            Diction diction = new Diction("qwe", lsecond, IDictionary.Type.EnUa);

            while (true)
            {
                Console.WriteLine($"0 - Add");
                Console.WriteLine($"1 - Edit");
                Console.WriteLine($"2 - Remove");
                Console.WriteLine($"3 - Save");
                Console.WriteLine($"4 - Exit");
                int keyy = int.Parse(Console.ReadLine());

                switch (keyy)
                {
                    case 0:
                        {
                            Console.Write("Enter first : "); string first = Console.ReadLine();
                            Console.Write("Enter count of second : "); int countSecond = int.Parse(Console.ReadLine());

                            List<string> list = new List<string>();
                            for (int i = 0; i < countSecond; i++)
                            {
                                Console.Write("Enter second : "); string second = Console.ReadLine();
                                list.Add(second);
                            }

                            diction.Add(first, list);
                        }
                        break;
                    case 1:
                        {
                            Console.Write("Enter key : "); string key = Console.ReadLine();
                            Console.Write("Enter new_key : "); string new_key = Console.ReadLine();
                            Console.Write("Enter old_value : "); string old_value = Console.ReadLine();
                            Console.Write("Enter new_value : "); string new_value = Console.ReadLine();

                            diction.Edit(key, new_key);
                            diction.Edit(key, old_value, new_value);
                        }
                        break;
                    case 2:
                        {
                            Console.Write("Enter key : "); string key = Console.ReadLine();
                            diction.Remove(key);
                        }
                        break;
                    case 3:
                        {
                            Console.Write("Enter key : "); string key = Console.ReadLine();
                            Console.Write("Enter file name : "); string fname = Console.ReadLine();
                            diction.Save(key, fname + ".txt");
                        }
                        break;
                    case 4:
                        {
                            Environment.Exit(0);
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
