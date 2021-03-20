using System;

namespace Arrays__Books_
{
    class Book
    {
        private string author;
        private int code;
        private static int counter;
        private string name;
        private uint year;
        public static explicit operator CoverBook(Book book) => new CoverBook(book.Author, book.Name, book.Year);
        public static explicit operator Book(CoverBook cover) => new Book(cover.Author, cover.Name, cover.Year);
        private bool IsValidIndex(int index) => index >= 0;
        public string this[int index]
        {
            get
            {
                if (index == Code)
                {
                    if (!IsValidIndex(index))
                    {
                        throw new Exception($"Invalid index. ({index})");
                    }
                    return $"({ToString()}) by index {index}";
                }
                else
                {
                    throw new Exception();
                }
            }
        }
        public Book(string author, string name, uint year)
        {
            code = ++counter;
            Author = author;
            Name = name;
            Year = year;
        }
        public Book() : this("No author", "Noname", 0) { }
        public string Author
        {
            get => author;
            set => author = value;
        }

        public int Code
        {
            get => code;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public uint Year
        {
            get => year;
            set => year = value;
        }

        public void setValues(string author, string name, uint year)
        {
            this.author = author;
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

        private bool IsValidIndex(int index) => index >= 0;
        public Book this[int index]
        {
            get
            {
                if (!IsValidIndex(index))
                {
                    throw new Exception($"Invalid index. ({index})");
                }
                return books[index];
            }
            set
            {
                if (!IsValidIndex(index))
                {
                    throw new Exception($"Invalid index. ({index})");
                }
                string author = Console.ReadLine();
                string name = Console.ReadLine();
                uint year = uint.Parse(Console.ReadLine());
                books[index].setValues(author, name, year);
            }
        }
        public Book this[string index]
        {
            get
            {
                int id = Convert.ToInt32(index);
                if (id == books[id].Code)
                {
                    return books[id];
                }
                else
                {
                    throw new Exception($"Invalid index. ({index ?? "null"})");
                }
            }
            set
            {
                int id = Convert.ToInt32(index);
                if (id == books[id].Code)
                {
                    string author = Console.ReadLine();
                    string name = Console.ReadLine();
                    uint year = uint.Parse(Console.ReadLine());
                    books[id].setValues(author, name, year);
                }
            }
        }
        public void Add(Book book)
        {
            if (books == null)
            {
                throw new Exception("Library is empty.");
            }

            Array.Resize(ref books, books.Length + 1);
            books[books.Length - 1] = book;
        }
        public void Remove(int code)
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
    class CoverBook
    {
        public string Author { get; set; }
        public string Name { get; set; }
        public uint Year { get; set; }
        
        public CoverBook(string author, string name, uint year)
        {
            Author = author;
            Name = name;
            Year = year;
        }
        public CoverBook() : this("No author", "Noname", 0) { }
    }
    class Program
    {
        static void Main()
        {
            Library lib = new Library();
            CoverBook cb = new CoverBook();
            Book b = new Book("Shildt", "Arial Middle", 2000);
            Book a = new Book("Shildt1", "Arial Middle1", 2001);
            lib.Add(b);
            lib.Add(a);
            lib.Print();
            Console.WriteLine();
            // lib.Remove(1);
            lib.Print();
            cb = (CoverBook)b;
            a = (Book)cb;
        }
    }
}
