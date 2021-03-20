using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Employee_.NET_Core_HW
{
    class Employee
    {
        private string name;
        private string surname;
        private ushort salary;
        private readonly int ID;
        private static int counter;
        public Employee(string name, string surname, ushort salary)
        {
            Name = name;
            Surname = surname;
            Salary = salary;
            ID = ++counter;
        }
        public string Name
        {
            get => name;
            set
            {
                if (name == null)
                {
                    if (value.All(x => char.IsLetter(x)))
                    {
                        name = value;
                    }
                    else
                    {
                        throw new LoginLetterException("The name has bad value type, it may has numbers or different other bad symbol.");
                    }
                }
                else
                {
                    throw new NullException("Name is empty. (null)");
                }
            }
        }
        public string Surname
        {
            get => surname;
            set
            {
                if (surname == null)
                {
                    if (value.All(x => char.IsLetter(x)))
                    {
                        surname = value;
                    }
                    else
                    {
                        throw new LoginLetterException("The surname has bad value type, it may has numbers or different other bad symbol.");
                    }
                }
                else
                {
                    throw new NullException("Surname is empty. (null)");
                }
            }
        }
        public ushort Salary
        {
            get => salary;
            set
            {
                string tmp = Convert.ToString(value);
                if (tmp.All(x => char.IsSymbol(x)))
                {
                    throw new SalarySymbolException("Salary contains symbol. (only 'ushort')");
                }
                else
                {
                    checked
                    {
                        salary = value;
                    }
                }
            }
        }
        public void EnterNameAndSurname(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
        public void PlusSalary(ushort salary)
        {
            Console.Write("Do u want to enter it again ? ('yes' or 'no')");
            string str = Console.ReadLine();
            if (str == "yes")
            {
                Console.Write("Enter the number to plus to the salary : ");
                checked
                {
                    salary = ushort.Parse(Console.ReadLine());
                }
            }
            checked
            {
                Salary += salary;
            }
        }
    }
}
