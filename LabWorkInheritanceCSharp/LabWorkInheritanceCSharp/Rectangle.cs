using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWorkInheritanceCSharp
{
    public class Rectangle : Shape
    {
        private double width;
        private double length;
        public double Width
        {
            get => width;
            set => width = value;
        }
        public double Length
        {
            get => length;
            set => length = value;
        }
        public override double Area
        {
            get => width * length;
        }
        public override void Print()
        {
            Console.WriteLine($"Name : {nameof(Rectangle)}, Area : {Area}");
        }
    }
}
