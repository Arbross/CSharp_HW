using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_.NET_Core_HW
{
    class Departament
    {
        private List<Employee> employees;
        private ushort countOfEmployees { get; set; }
        public ushort CountOfEmployees
        {
            get => countOfEmployees;
        }
        public Departament(ushort countOfEmployees)
        {
            this.countOfEmployees = countOfEmployees;
            employees = new List<Employee>(countOfEmployees);
        }
        public Departament() : this(2) { }
        public void AddEmployee(string name, string surname, ushort salary)
        {
            Console.Write("Do u want to enter it again ? ('yes' or 'no')");
            string str = Console.ReadLine();
            if (str == "yes")
            {
                Console.Write("Name : ");
                name = Console.ReadLine();

                Console.Write("Surname : ");
                surname = Console.ReadLine();

                Console.Write("Salary : ");
                salary = ushort.Parse(Console.ReadLine());
            }

            int count = employees.Count;
            count++;
            if (count <= countOfEmployees)
            {
                employees.Add(new Employee(name, surname, salary));
            }
            else
            {
                throw new OutOfRangeEmployeeArray("Out of range employee array.");
            }
        }
        public void RemoveEmployee(string name, string surname, ushort salary)
        {
            Console.Write("Do u want to enter it again ? ('yes' or 'no')");
            string str = Console.ReadLine();
            if (str == "yes")
            {
                Console.Write("Name : ");
                name = Console.ReadLine();

                Console.Write("Surname : ");
                surname = Console.ReadLine();

                Console.Write("Salary : ");
                salary = ushort.Parse(Console.ReadLine());
            }

            if (employees != null)
            {
                employees.Remove(new Employee(name, surname, salary));
            }
            else
            {
                throw new EmptyArrayEmployees("It is no employees in array.");
            }
        }
    }
}
