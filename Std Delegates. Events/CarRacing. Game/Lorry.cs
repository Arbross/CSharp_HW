using System;
using System.Collections.Generic;
using System.Text;

namespace CarRacing._Game
{
    class Lorry : Car
    {
        new public uint Speed
        {
            get
            {
                Random rnd = new Random();
                return speed = (uint)rnd.Next(35, 50);
            }
        }
        public override void Drive()
        {
            Console.WriteLine($"The lorry car is driving with speed {Speed}.");
        }
        public override void FinishLine()
        {
            Console.WriteLine($"The lorry car finished first.");
        }
    }
}
