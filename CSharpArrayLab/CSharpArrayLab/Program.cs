using System;
using System.Linq;

namespace CSharpArrayLab
{
    class Program
    {
        static void PrintArray(int[] arr, string prompt = "")
        {
            // Console.WriteLine(prompt);
            foreach (var elem in arr)
            {
                Console.Write(elem + "\t");
            }
        }
        static void ChangePlaceOn(int[] arr)
        {
            int[] less = Array.FindAll(arr, e => e < 0);
            int[] top = Array.FindAll(arr, e => e > 0);

            less.CopyTo(arr, 0);
            top.CopyTo(arr, less.Length);
        }
        static int FillRandomAndCount(int first, int second, int count, ref int[] array)
        {
            Random rnd = new Random();
            int counter = 0;
            Array.Resize(ref array, count);
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(first, second);
                counter++;
            }
            return counter;
        }
        static int SumBehindElements(int[] array)
        {
            int first = Array.IndexOf(array, array.Max());
            int second = Array.IndexOf(array, array.Min());

            int sum = 0;
            for (int i = second; i <= first; i++)
            {
                sum += array[i];
            }
            return sum;
        }
        static int FindSumOfOneNumberElement(int[] array)
        {
            int counter = 0;
            foreach (var item in array)
            {
                if (item % 2 == 0 && item > 0 && item < 10)
                {
                    counter += item;
                }
            }

            return counter;
        }
        static void SortByPrice(string[] strArray, int[] array)
        {
            Array.Sort(strArray, array);
        }
        static void Main(string[] args)
        {
            int[] array = { 1, 20, -4, -6, -7, 10, 100 };
            string[] strArray = { "One", "Twenty", "Minus Four", "Minus Six", "Minus seven", "Ten", "One hundred" };
            Array.Sort(strArray, array);

            // ChangePlaceOn(array);
            // Console.WriteLine(FillRandomAndCount(5, 10, 10, ref array)); 
            // Console.WriteLine(SumBehindElements(array));
            // Console.WriteLine(FindSumOfOneNumberElement(array));
            // SortByPrice(strArray, array);
            PrintArray(array);
        }
    }
}
