using System;
using System.Collections.Generic;
using System.Text;

namespace CarRacing._Game
{
    class Sport : Car
    {
        new public uint Speed
        {
            get
            {
                Random rnd = new Random();
                return speed = (uint)rnd.Next(40, 75);
            }
        }
        public override void Drive()
        {
            Console.WriteLine($"The sport car is driving with speed {Speed}.");
        }
        public override void FinishLine()
        {
            Console.WriteLine($"The sport car finished first.");
        }
    }
}
