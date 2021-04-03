using System;
using System.Linq;

namespace EventHandler._Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock cl = new Clock(23, 59);
            cl.Tick();
            Console.WriteLine(cl.ToString());
        }
    }
}
