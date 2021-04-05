using System;
using System.Linq;
using System.Collections.Generic;

namespace Task_2
{
    /*Завдання 2.
    Ознайомитися самостійно з колекціями LinkedList<>, SortedSet<>, HashSet<>. Створити програму для демонстрації роботи з колекціями.*/
    class Program
    {
        static void Main()
        {
            {
                // LinkedList<> (Task 1)
                string[] words = { "It", "is", "the", "long", "way", "to", "place", "it", "on" };
                LinkedList<string> list = new LinkedList<string>();
                list.AddLast(words[1]);
                list.AddFirst(words[0]);
                for (int i = 2; i < words.Count(); i++)
                {
                    list.AddLast(words[i]);
                }
                list.RemoveFirst();
                list.RemoveLast();
                Console.WriteLine(list.FindLast("on"));
                Console.WriteLine(list.Find("It"));
                Console.WriteLine(list.Contains("the"));
                string[] strArray = new string[list.Count];
                list.CopyTo(strArray, 0);
                foreach (var item in strArray)
                { 
                    Console.WriteLine(item);
                }
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
            }
            {
                SortedSet<int> sortedSet = new SortedSet<int>();
                sortedSet.Add(5);
                sortedSet.Add(4);
                sortedSet.Add(23);
                sortedSet.Add(7);
                sortedSet.Add(76);
                foreach (var item in sortedSet)
                {
                    Console.WriteLine(item); // Sort all items that was added to 'Set'
                    // sortedSet[0].... // no index
                }
                SortedSet<int> sortedSet_ = new SortedSet<int>();
                sortedSet_.Add(454);
                sortedSet.UnionWith(sortedSet_);
                // sortedSet_.UnionWith(sortedSet);
                foreach (var item in sortedSet_)
                {
                    Console.WriteLine(item);
                }
                sortedSet.ExceptWith(sortedSet_);
                Console.WriteLine();
                foreach (var item in sortedSet)
                {
                    Console.WriteLine(item);
                }
                sortedSet.Remove(5);
                sortedSet.Reverse();
                Console.WriteLine(sortedSet.First());
                Console.WriteLine(sortedSet.Last());
                Console.WriteLine(sortedSet.Max());
                Console.WriteLine(sortedSet.Min());
                Console.WriteLine(sortedSet.Sum());
                sortedSet.Clear();
            }
            {
                HashSet<int> hashSet = new HashSet<int>();
                hashSet.Add(125);
                hashSet.Add(65);
                hashSet.Add(78);
                hashSet.Add(23);
                hashSet.Add(34);
              
                Console.WriteLine();
                Console.WriteLine();
                foreach (var item in hashSet)
                {
                    Console.WriteLine(item);
                }
                HashSet<int> hashSet_ = new HashSet<int>();
                hashSet_.Add(454);
                hashSet.UnionWith(hashSet_);
                // sortedSet_.UnionWith(sortedSet);
                foreach (var item in hashSet_)
                {
                    Console.WriteLine(item);
                }
                hashSet.ExceptWith(hashSet_);
                Console.WriteLine();
                foreach (var item in hashSet_)
                {
                    Console.WriteLine(item);
                }
                hashSet.Remove(5);
                hashSet.Reverse();
                Console.WriteLine(hashSet.First());
                Console.WriteLine(hashSet.Last());
                Console.WriteLine(hashSet.Max());
                Console.WriteLine(hashSet.Min());
                Console.WriteLine(hashSet.Sum());
                hashSet.Clear();
            }
        }
    }
}
