using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Task
{
    class Program
    {
        static void Main()
        {
            Drink f1 = new Drink("Coffee", Drink.Type.Warm, "Yakobs", 55, 65);
            Console.WriteLine(f1);

            List<Drink> dr = new List<Drink>
            {
                f1,
                new Drink("Juice", Drink.Type.Cold, "Sandora", 125, 45)
            };
            // dr.Sort();
            dr.Sort(new CompareByDeveloper());
            Console.WriteLine();
            Console.WriteLine("------------------------------------------");
            foreach (Drink p in dr)
            {
                Console.WriteLine(p);
            }

            dr.Sort(new CompareByPrice());
            Console.WriteLine();
            Console.WriteLine("------------------------------------------");
            foreach (Drink p in dr)
            {
                Console.WriteLine(p);
            }

            dr.Sort(new CompareByKal());
            Console.WriteLine();
            Console.WriteLine("------------------------------------------");
            foreach (Drink p in dr)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine();
            Console.WriteLine("------------------ArrayList---------------");

            ArrayList list = new ArrayList();
            list.Add(new Drink("Pepsi", Drink.Type.Cold, "Coca-Cola Company", 150, 14));
            list.Add(new Drink("Tea", Drink.Type.Warm, "China", 80, 45));
            list.Sort();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
