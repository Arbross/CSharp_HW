using LabWorkInheritanceCSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Access
{
    public class Square : Shape
    {
        private double side;
        public double Side
        {
            get => side;
            set => side = value;
        }
        public override double Area
        {
            get => Side * Side;
        }
        public override void Print()
        {
            Console.WriteLine($"Name : {nameof(Square)}, Area : {Area}");
        }
    }
}
