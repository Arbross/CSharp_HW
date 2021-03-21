using System;
using System.Collections.Generic;
using System.Text;

namespace BuildHome_HW
{
    class TeamLeader : IWorker
    {
        private string name;
        private uint age;

        public TeamLeader(string name, uint age)
        {
            Name = name;
            Age = age;
        }
        public TeamLeader() : this("Noname", 0) { }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public uint Age
        {
            get => age;
            set
            {
                if (age >= 0 && age <= 120)
                {
                    age = value;
                }
                else
                {
                    throw new Exception();
                }
            }
        }
        public void Zvit()
        {
            House house;
            // house.Zvit();
        }
        public void PrintInfoAbout(string message = "No message")
        {
            Console.WriteLine($"Message : {message}");
            Console.WriteLine($"Name : {Name},\nAge : {age}");
        }
    }
}
