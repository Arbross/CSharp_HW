using System;
using System.Collections.Generic;
using System.Text;

namespace BuildHome_HW
{
    class Walls : IPart
    {
        private uint width;
        private uint length;
        public Walls(uint width, uint length)
        {
            Width = width;
            Length = length;
        }
        public Walls() : this(0, 0) { }
        public uint Width
        {
            get => width;
            set => width = value;
        }
        public uint Length
        {
            get => length;
            set => length = value;
        }
        public void PrintInfoAbout(string message = "No message")
        {
            Console.WriteLine();
            Console.WriteLine($"Message : {message}");
            Console.WriteLine($"Length : {Length},\nWidth : {Width}");
            Console.WriteLine();
        }
    }
}
