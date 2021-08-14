using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWorkInheritanceCSharp
{
    public class Program
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
            shapes.Add(new Rectangle() { Length = 50, Width = 30 });
            shapes.Add(new Rectangle() { Length = 1000, Width = 3000 });
            shapes.Add(new Circle() { Radius = 100 });
        }
        public static void Sort(ref List<Shape> shapes)
        {
            shapes = shapes.OrderByDescending(x => x.Area).ToList();
        }
        public static void SaveCircle(ref List<Shape> shapes, ref List<Shape> shapes_another_one)
        {
            foreach (var item in shapes)
            {
                if (item.GetType() == typeof(Circle))
                {
                    shapes_another_one.Add(item);
                }
            }
        }
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            List<Shape> shapes_another_one = new List<Shape>();

            Console.WriteLine("Adding.");
            Add(ref shapes);

            Console.WriteLine("Sorting.");
            Sort(ref shapes);

            Console.WriteLine("Printing.");
            Print(ref shapes);

            Console.WriteLine("Circle finding.");
            SaveCircle(ref shapes, ref shapes_another_one);

            Console.WriteLine("Printing.");
            Print(ref shapes_another_one);

            Console.ReadKey();
        }
    }
}
