using System;
using System.Collections.Generic;
using System.Text;

namespace BuildHome_HW
{
    class Roof : IPart
    {
        private uint height;
        private uint width;
        private uint length;
        public Roof(uint height, uint width, uint length)
        {
            Height = height;
            Width = width;
            Length = length;
        }
        public Roof() : this(0, 0, 0) { }
        public uint Height
        {
            get => height;
            set => height = value;
        }
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
            Console.WriteLine($"Length : {Length},\nWidth : {Width},\nHeight : {Height}");
            Console.WriteLine();
        }
    }
}
