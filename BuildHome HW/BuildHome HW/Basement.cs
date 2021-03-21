using System;
using System.Collections.Generic;
using System.Text;

namespace BuildHome_HW
{
    class Basement : IPart
    {
        private uint width;
        private uint length;
        public enum Type : byte { Strichkovii = 0, Zbirnii, Stovpchastii, Sysilnii, Zvarnii }
        private Type type;
        public Basement(uint width, uint length, Type type)
        {
            this.type = type;
            Width = width;
            Length = length;
        }
        public Basement() : this(0, 0, 0) { }
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
            Console.WriteLine($"Length : {Length},\nWidth : {Width},\nType : {type}");
            Console.WriteLine();
        }
    }
}
