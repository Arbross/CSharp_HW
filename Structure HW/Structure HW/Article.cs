using System;
using System.Collections.Generic;
using System.Text;

namespace Structure_HW
{
    struct Article
    {
        private ushort code;
        private string name;
        private ushort price;
        public enum Type : byte { }
        private Type type;
        public Article(ushort code, string name, ushort price, Type type)
            : this()
        {
            Code = code;
            Name = name;
            Price = price;
            nType = type;
        }
        public ushort Code
        {
            get => code;
            set => code = value;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public ushort Price
        {
            get => price;
            set => price = value;
        }
        public Type nType
        {
            get => type;
            set => type = value;
        }
    }
}
