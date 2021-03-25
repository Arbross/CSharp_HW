using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Task
{
    public class Drink : IComparable, IComparable<Drink>, IEquatable<Drink>
    {
        private string name;
        public enum Type : byte { Cold = 0, Warm }
        public Type main_type { get; set; }
        private string developer;
        private uint countOfKal;
        private uint price;

        public string Name
        {
            get => name;
            set => name = value;
        }
        public string Developer
        {
            get => developer;
            set => developer = value;
        }
        public uint CountOfKal
        {
            get => countOfKal;
            set => countOfKal = value;
        }
        public uint Price
        {
            get => price;
            set => price = value;
        }
        public Drink(string name, Type type, string developer, uint countOfKal, uint price)
        {
            Name = name;
            main_type = type;
            Developer = developer;
            CountOfKal = countOfKal;
            Price = price;
        }
        public Drink() : this("Noname", 0, "No developer", 0, 0) { }
        public override string ToString()
        {
            Console.WriteLine();
            return $"Name : {Name},\n Type : {main_type},\n Developer : {Developer},\n Count of kal : {CountOfKal},\n Price : {Price}";
        }

        public int CompareTo(object obj)
        {
            if (this.main_type == ((Drink)obj).main_type)
            {
                return this.Name.CompareTo(((Drink)(obj)).Name);
            }
            return this.main_type < ((Drink)(obj)).main_type ? 1 : -1;
        }

        public int CompareTo([AllowNull] Drink other)
        {
            return this.Name.CompareTo(other.Name);
        }

        public bool Equals([AllowNull] Drink other)
        {
            if (other == null)
            {
                return false;
            }

            Drink tmp = other as Drink;
            if (tmp == null)
            {
                return false;
            }
            else
            {
                return Equals(tmp);
            }
        }
    }
    public class CompareByPrice : IComparer, IComparer<Drink>
    {
        public int Compare(object x, object y)
        {
            string s1 = x as string;
            string s2 = y as string;
            return String.Compare(s1, s2);
        }

        public int Compare([AllowNull] Drink x, [AllowNull] Drink y)
        {
            return -x.Price.CompareTo(y.Price);
        }
    }
    public class CompareByKal : IComparer, IComparer<Drink>
    {
        public int Compare(object x, object y)
        {
            string s1 = x as string;
            string s2 = y as string;
            return -String.Compare(s1, s2);
        }

        public int Compare([AllowNull] Drink x, [AllowNull] Drink y)
        {
            return x.CountOfKal.CompareTo(y.CountOfKal);
        }
    }
    public class CompareByDeveloper : IComparer, IComparer<Drink>
    {
        public int Compare(object x, object y)
        {
            string s1 = x as string;
            string s2 = y as string;
            return String.Compare(s1, s2);
        }

        public int Compare([AllowNull] Drink x, [AllowNull] Drink y)
        {
            return x.Developer.CompareTo(y.Developer);
        }
    }
}
