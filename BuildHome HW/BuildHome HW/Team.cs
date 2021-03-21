using System;
using System.Collections.Generic;
using System.Text;

namespace BuildHome_HW
{
    class Team
    {
        private readonly TeamLeader tl;
        private List<Worker> workers;
        private ushort countOfWorkers { get; set; }
        public Team(string name, uint age, ushort countOfWorkers)
        {
            tl = new TeamLeader(name, age);
            this.countOfWorkers = countOfWorkers;
            workers = new List<Worker>(countOfWorkers);
        }
        public Team() : this("Noname", 0, 0) { }
        public void Add(string name, uint age)
        {
            if (CountOfWorkers <= workers.Count)
            {
                workers.Add(new Worker(name, age, tl));
            }
            else
            {
                throw new Exception();
            }
        }
        public void Remove(string name, uint age)
        {
            if (workers != null)
            {
                workers.Remove(new Worker(name, age, tl));
            }
            else
            {
                throw new Exception();
            }
        }
        public void Update()
        {
            workers.Clear();
            workers = new List<Worker>(CountOfWorkers);
        }
        public ushort CountOfWorkers
        {
            get => countOfWorkers;
            set => countOfWorkers = value;
        }
        public void PrintInfoAbout(string message = "No message")
        {
            Console.WriteLine($"Message : {message}");
            tl.PrintInfoAbout();
            foreach (var elem in workers)
            {
                elem.PrintInfoAbout();
            }
        }
    }
}
