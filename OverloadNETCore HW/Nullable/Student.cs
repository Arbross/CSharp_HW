using System;
using System.Collections.Generic;
using System.Text;

namespace Nullable
{
    class Student
    {
        private string name;
        private List<Mark> marks;
        public string Name
        {
            get => name;
            set => name = value;
        }
        public Student(string name)
        {
            Name = name;
            marks = new List<Mark>();
        }
        public void AddMark(DateTime date, int mark)
        {
            marks.Add(new Mark(date, mark));
        }
        public int? CountAvarageMark()
        {
            int? sum = 0;
            for (int i = 0; i < marks.Count; i++)
            {
                if (marks[i].IsMark == null)
                {
                    sum += 0;
                }
                else
                {
                    sum += marks[i].IsMark;
                }
            }

            return sum / marks.Count;
        }
        public void CancelMark(DateTime date, int mark)
        {
            for (int i = 0; i < marks.Count; i++)
            {
                if (marks[i].DateOfMark == date && marks[i].IsMark == mark)
                {
                    marks[i].IsMark = 0;
                    Console.WriteLine($"Succsessful deleted mark. {marks[i].IsMark}");
                }
            }
        }
        public void ChangeMarkByDate(DateTime date, int mark)
        {
            for (int i = 0; i < marks.Count; i++)
            {
                if (marks[i].DateOfMark == date)
                {
                    marks[i].IsMark = mark;
                }
            }
        }
        public void ChangeMarkByID(int id, int mark)
        {
            for (int i = 0; i < marks.Count; i++)
            {
                if (marks[i].ISID == id)
                {
                    marks[i].IsMark = mark;
                    break;
                }
            }
        }
        public void Print()
        {
            Console.WriteLine($"Name : {Name},\t");
            foreach (Mark elem in marks)
            {
                Console.WriteLine(elem.ToString());
            }
        }
    }
}
