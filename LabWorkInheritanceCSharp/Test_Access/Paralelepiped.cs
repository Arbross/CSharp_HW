using LabWorkInheritanceCSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Access
{
    public class Paralelepiped : Rectangle
    {
        private double height;
        public double Height
        {
            get => height;
            set => height = value;
        }
        public override double Area
        {
            get => Width * Length * Height;
        }
        public override void Print()
        {
            Console.WriteLine($"Name : {nameof(Paralelepiped)}, Area : {Area}");
        }
    }
}
