using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class FreelanceJobs
    {
        private ObservableCollection<Freelancer> obcollection;
        public FreelanceJobs(string Name, string Skill, string Info, Task task)
        {
            obcollection = new ObservableCollection<Freelancer>() { };
            obcollection.Add(new Freelancer(Name, Skill, Info, task));
        }
        public void Add(string Name, string Skill, string Info, Task task)
        {
            obcollection.Add(new Freelancer(Name, Skill, Info, task));
        }
        public ObservableCollection<Freelancer> GetFreelancers()
        {
            return obcollection;
        }
    }
    class Task
    {
        public string NameOfATask { get; set; }
        public string NeedSkill { get; set; }
        public Task(string NameOfATask, string NeedSkill)
        {
            this.NameOfATask = NameOfATask;
            this.NeedSkill = NeedSkill;
        }
        public override string ToString()
        {
            return $"Name of a task : {NameOfATask},\n Need skill : {NeedSkill}.";
        }
    }
    class Freelancer
    {
        public string Name { get; set; }
        public string Skill { get; set; }
        public string Info { get; set; }
        public Task task;
        public Freelancer(string Name, string Skill, string Info, Task task)
        {
            this.Name = Name;
            this.Skill = Skill;
            this.Info = Info;
            this.task = task;
            if (this.task.NeedSkill != this.Skill)
            {
                Console.WriteLine($"The skill isn't equeal need skill.");
                return;
            }
        }
        public override string ToString()
        {
            return $"Name : {Name},\n Skill : {Skill},\n Info : {Info}.\n Task : \n {task.ToString()}.";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            FreelanceJobs freelanceJobs = new FreelanceJobs("Nazar", "Noskill", ":)", new Task("Lie", "Noskill"));
            foreach (var item in freelanceJobs.GetFreelancers())
            {
                Console.WriteLine(item);
            }
        }
    }
}
