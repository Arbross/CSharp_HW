using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        class Person : IComparable
        {
            public string Name { get; set; }
            public uint Age { get; set; }
            public Person(string Name, uint Age)
            {
                this.Name = Name;
                this.Age = Age;
            }
            public Person() : this("Noname", 0) { }

            public int CompareTo(object obj)
            {
                if (obj == null) return 1;

                Person otherPerson = obj as Person;
                if (otherPerson != null)
                {
                    return this.Age.CompareTo(otherPerson.Age);
                }
                else
                {
                    throw new ArgumentException("Object is not a Age");
                }
            }
            public override string ToString()
            {
                return $"Name : {Name}, Age : {Age}";
            }
        }
        static void Main(string[] args)
        {
            HashSet<Person> hpeople = new HashSet<Person>();
            hpeople.Add(new Person());
            hpeople.Add(new Person("34", 43));
            hpeople.Add(new Person("334", 643));
            hpeople.Add(new Person("3f4", 743));
            hpeople.Add(new Person("df", 65));
            hpeople.Add(new Person("dfdf", 65));

            SortedSet<Person> speople = new SortedSet<Person>();
            speople.Add(new Person());
            speople.Add(new Person("fdsdf", 1));
            speople.Add(new Person("334", 2));
            speople.Add(new Person("3f4", 3));
            speople.Add(new Person("45", 4));
            hpeople.IntersectWith(speople);

            HashSet<Person> hashset = new HashSet<Person>();
            hashset.UnionWith(hpeople);
            hashset.UnionWith(speople);
            Console.WriteLine("Union : ");
            foreach (Person item in hashset)
            {
                Console.WriteLine($"{item.ToString()}");
            }
            
            hpeople.ExceptWith(speople);
            Console.WriteLine("ExeptWith : ");
            foreach (Person item in hpeople)
            {
                Console.WriteLine($"{item.ToString()}");
            }
            speople.RemoveWhere(x => x.Name == "Anton");
        }
    }
}
