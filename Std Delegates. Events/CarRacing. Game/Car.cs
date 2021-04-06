using System;
using System.Collections.Generic;
using System.Text;

namespace CarRacing._Game
{
    abstract class Car
    {
        public uint distance { get; set; }
        protected uint speed;
        public uint Speed
        {
            get
            {
                Random rnd = new Random();
                return speed = (uint)rnd.Next(5, 10);
            }
        }
        public virtual void Drive()
        {
            Console.WriteLine("The car is driving.");
        }
        public abstract void FinishLine();
    }
}
