using System;
using System.Collections.Generic;


namespace library
{
    public class Book
    {
        public string title { get; set; }
        public string author { get; set; }
        public int ISBN { get; set; }
        public Book(string title, string author, int ISBN)
        {
            this.author = author;
            this.title = title;
            this.ISBN = ISBN;
        }
    }

    public class Library
    {
        public List<Book> books = new List<Book>();

        public void addBook(Book b)
        {
            books.Add(b);
        }

        public Book find(string input)
        {
            return books.Find(x => x.author.Contains(input));
        }

        public void show()
        {
            for (int i = 0; i < books.Count; i++)
            {
                Console.WriteLine("Book title:" + books[i].title + " \nBook author: " + books[i].author);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Learn Python the hard way", "Zed A. Shaw", 1);
            Book book2 = new Book("Introduction to algorithms", "Thomas H. Cormen", 2);
            Library l = new Library();
            l.addBook(book1);
            l.addBook(book2);
            l.show();
            Console.Write("Enter author: ");
            string searchInput = Console.ReadLine();
            if (l.find(searchInput) != null)
            {
                Console.WriteLine("Found. The title of the book is " + l.find(searchInput).title);
            }
            else
            {
                Console.WriteLine("Author is wrong or doesn't exist in the library");
            }
        }
    }
}
