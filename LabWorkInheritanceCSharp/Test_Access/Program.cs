using LabWorkInheritanceCSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Access
{
    class Program
    {
        public static void Print(ref List<Shape> shapes)
        {
            foreach (var item in shapes)
            {
                item.Print();
            }
        }
        public static void Add(ref List<Shape> shapes)
        {
            shapes.Add(new Paralelepiped() { Length = 50, Width = 30, Height = 50 });
            shapes.Add(new Square() { Side = 5 });
        }
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();

            Console.WriteLine("Adding.");
            Add(ref shapes);

            Console.WriteLine("Printing.");
            Print(ref shapes);

            Console.ReadKey();
        }
    }
}
