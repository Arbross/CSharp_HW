using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWorkInheritanceCSharp
{
    // First Type Of The Task
    //public class Shape
    //{
    //    public virtual double Area
    //    {
    //        get => 0;
    //    }
    //    public virtual void Print()
    //    {
    //        Console.WriteLine("Name : *name of figure*, Area : *area value*");
    //    }
    //}

    // Second Type Of The Task
    public abstract class Shape
    {
        public abstract double Area { get; }
        public abstract void Print();
    }
}
