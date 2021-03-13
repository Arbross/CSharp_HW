using System;

namespace Arrays__Books_
{
    class Book
    {
        private string author;
        private string code;
        private string name;
        private int year;
        public Book(string author, string code, string name, int year)
        {
            Author = author;
            Code = code;
            Name = name;
            Year = year;
        }
        public Book() : this("No author", "No code", "Noname", 0) { }
        public string Author
        {
            get => author;
            set => author = value;
        }

        public string Code
        {
            get => code;
            set => code = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Year
        {
            get => year;
            set => year = value;
        }

        public void setValues(string author, string code, string name, int year)
        {
            this.author = author;
            this.code = code;
            this.name = name;
            this.year = year;
        }

        public override string ToString()
        {
            return ($"Author : {author}, Code : {code}, Name : {name}, Year : {year}");
        }
    }
    class Library
    {
        private Book[] books = new Book[0];

        public void Add(Book book)
        {
            if (books == null)
            {
                throw new Exception("Library is empty.");
            }

            Array.Resize(ref books, books.Length + 1);
            books[books.Length - 1] = book;
        }
        public void Remove(string code)
        {
            if (books == null)
            {
                throw new Exception("Library is empty.");
            }

            Book[] bb = null;
            int j = 0;
            Array.Resize(ref bb, books.Length);
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i].Code != code)
                {
                    bb[j] = books[i];
                    j++;
                }
            }

            Array.Resize(ref books, books.Length - 1);
            for (int i = 0; i < books.Length; i++)
            {
                books[i] = bb[i];
            }
        }

        public void Print()
        {
            foreach (var elem in books)
            {
                Console.WriteLine(elem.ToString());
            }
        }

        public void SortByAuthor()
        {
            Array.Sort(books, (x, y) => String.Compare(x.Author, y.Author));
        }
        public void SortByAuthorAndName()
        {
            SortByAuthor(); Array.Sort(books, (x, y) => String.Compare(x.Name, y.Name));
        }

        public int SearchName(string name)
        {
            int index = Array.FindIndex(books, x => x.Name == name); return index;
        }
        public int SearchAuthor(string author)
        {
            int index = Array.FindIndex(books, x => x.Author == author); return index;
        }
    }
    class Program
    {
        static void Main()
        {
            Library lib = new Library();
            Book b = new Book("Shildt", "C#", "Arial Middle", 2000);
            Book a = new Book("Shildt1", "C#1", "Arial Middle1", 2001);
            lib.Add(b);
            lib.Add(a);
            lib.Print();
            Console.WriteLine();
            lib.Remove("Arial Middle1");
            lib.Print();
        }
    }
}
