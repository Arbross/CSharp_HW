using System;
using System.Collections.Generic;
using System.Text;

namespace CarRacing._Game
{
    class Light : Car
    {
        new public uint Speed
        {
            get
            {
                Random rnd = new Random();
                return speed = (uint)rnd.Next(35, 60);
            }
        }
        public override void Drive()
        {
            Console.WriteLine($"The light car is driving with speed {Speed}.");
        }
        public override void FinishLine()
        {
            Console.WriteLine($"The light car finished first.");
        }
    }
}
