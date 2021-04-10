using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Student_
{
    class Student
    {
        private string name;
        private int course;
        private List<byte> marks;
        private string prof;
        public override string ToString()
        {
            return $"Course : {Course}, Name : {Name}, Marks : {PrintMarks()}, Prof : {Prof}";
        }
        private string PrintMarks()
        {
            string tmp = null;
            for (int i = 0; i < marks.Count; i++)
            {
                tmp = tmp + marks[i] + " ";
            }
            return tmp;
        }
        public Student(int course, string name, List<byte> marks, string prof)
        {
            Course = course;
            Name = name;
            Marks = marks;
            Prof = prof;
        }
        public Student() : this(1, "Noname", null, "Noprof") { }
        public string Prof
        {
            get => prof;
            set => prof = value;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public int Course
        {
            get => course;
            set
            {
                if (value >= 1 && value <= 3)
                {
                    course = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Out of course range exception (from 1 to 3 course).");
                }
            }
        }
        public List<byte> Marks
        {
            get => marks;
            set => marks = value;
        }
    }
    static class StudentFS
    {
        public static void StudentWrite(Student student, string fname)
        {
            using (FileStream fs = new FileStream(fname, FileMode.OpenOrCreate, FileAccess.Write))
            {
                // Mark
                byte[] mark = new byte[student.Marks.Count];
                for (int i = 0; i < student.Marks.Count; i++)
                {
                    mark[i] = student.Marks[i];
                }
                fs.Write(mark);

                // Course
                byte[] course = BitConverter.GetBytes(student.Course);
                fs.Write(course);

                // Name
                byte[] name = Encoding.UTF8.GetBytes(student.Name);
                byte name_length = (byte)name.Length;
                fs.WriteByte(name_length);
                fs.Write(name);

                // Prof
                byte[] prof = Encoding.UTF8.GetBytes(student.Prof);
                byte prof_len = (byte)prof.Length;
                fs.WriteByte(prof_len);
                fs.Write(prof);
            }
        }
        public static Student StudentRead(Student student, string fname)
        {
            student = new Student();
            using (FileStream fs = new FileStream(fname, FileMode.Open, FileAccess.Read))
            {
                // Marks
                byte[] tmp = new byte[sizeof(byte)];
                List<byte> list = new List<byte>();
                for (int i = 0; i < 3; i++)
                {
                    fs.Read(tmp);
                    for (int j = 0; j < tmp.Length; j++)
                    {
                        list.Add(tmp[j]);
                    }
                }
                student.Marks = list;

                // Course
                byte[] course = new byte[sizeof(int)];
                fs.Read(course);
                student.Course = BitConverter.ToInt32(course);

                // Name
                byte name_length = (byte)fs.ReadByte();
                byte[] name = new byte[name_length];
                fs.Read(name);
                student.Name = Encoding.UTF8.GetString(name);

                // Prof
                byte prof = (byte)fs.ReadByte();
                byte[] bytes_ = new byte[prof];
                fs.Read(bytes_);
                student.Prof = Encoding.UTF8.GetString(bytes_);

                return student;
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                List<byte> list = new List<byte>() { 6, 5, 10 };
                Student student = new Student(2, "Mark", list, "IT");
                Student student_ = new Student();
                StudentFS.StudentWrite(student, "note.dat");
                Console.WriteLine(StudentFS.StudentRead(student_, "note.dat"));
            }
        }
    }
}
