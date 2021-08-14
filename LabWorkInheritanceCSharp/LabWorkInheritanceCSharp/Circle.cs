using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWorkInheritanceCSharp
{
    public class Circle : Shape
    {
        public const double PI = 3.14;
        private double radius;
        public double Radius
        {
            get => radius;
            set => radius = value;
        }
        public override double Area
        {
            get => PI * Radius * Radius;
        }
        public override void Print()
        {
            Console.WriteLine($"Name : {nameof(Circle)}, Area : {Area}");
        }
    }
}
