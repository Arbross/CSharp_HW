using System;

namespace Nullable
{
    class Program
    {
        static void Main()
        {
            Student student = new Student("James");
            student.AddMark(default(DateTime), 12);
            student.AddMark(default(DateTime), 11);
            student.AddMark(default(DateTime), 10);
            student.AddMark(default(DateTime), 9);
            student.AddMark(default(DateTime), 5);
            student.AddMark(default(DateTime), 1);
            student.AddMark(default(DateTime), 6);
            student.Print();
            Console.WriteLine(student.CountAvarageMark());
            student.CancelMark(default(DateTime), 1);
            // student.ChangeMarkByDate(default(DateTime), 5);
            student.ChangeMarkByID(1, 12);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            student.Print();
        }
    }
}
