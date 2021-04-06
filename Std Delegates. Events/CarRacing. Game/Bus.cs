using System;
using System.Collections.Generic;
using System.Text;

namespace CarRacing._Game
{
    class Bus : Car
    {
        new public uint Speed
        {
            get
            {
                Random rnd = new Random();
                return speed = (uint)rnd.Next(30, 55);
            }
        }
        public override void Drive()
        {
            Console.WriteLine($"The bus car is driving with speed {Speed}.");
        }
        public override void FinishLine()
        {
            Console.WriteLine($"The bus car finished first.");
        }
    }
}
