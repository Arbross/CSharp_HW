using System;
using System.Collections.Generic;
using System.Text;

namespace BuildHome_HW
{
    class Worker : IWorker
    {
        TeamLeader tl;
        private string name;
        private uint age;
        public Worker(string name, uint age, TeamLeader tl)
        {
            this.tl = tl;
            Name = name;
            Age = age;
        }
        public Worker() : this("Noname", 0, default(TeamLeader)) { }
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
        public void PrintInfoAbout(string message = "No message")
        {
            Console.WriteLine($"Message : {message}");
            Console.WriteLine($"Name : {Name},\nAge : {age},\nTeam leader : {tl.Name}");
        }
    }
}
