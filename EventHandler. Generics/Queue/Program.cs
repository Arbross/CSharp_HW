using System;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>(5);
            queue.Add(1123);
            queue.Add(5);
            queue.Add(10);
            queue.Add(20);
            queue.Add(54);
            queue.Extract();
            Console.WriteLine($"Top : {queue.Top()}");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }
    }
}
