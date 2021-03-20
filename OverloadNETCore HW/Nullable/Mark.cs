using System;
using System.Collections.Generic;
using System.Text;

namespace Nullable
{
    class Mark
    {
        private DateTime dateOfMark;
        private int? mark;
        private static int counter;
        private int ID;
        public override string ToString()
        {
            return $"Date of mark : {DateOfMark}, Mark : {IsMark}, ID : {ID}";
        }
        public Mark(DateTime date, int mark)
        {
            DateOfMark = date;
            this.mark = mark;
            ID = ++counter;
        }
        public Mark() : this(default(DateTime), 0) { }
        public DateTime DateOfMark
        {
            get => dateOfMark;
            set => dateOfMark = value;
        }
        public int ISID
        {
            get => ID;
        }
        public int? IsMark
        {
            get => mark;
            set
            {
                if (mark >= 0 && mark <= 12)
                {
                    mark = value;
                }
                else if(mark == null)
                {
                    mark = value;
                }
                else
                {
                    throw new Exception();
                }
            }
        }
    }
}
