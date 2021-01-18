using System;

namespace Assignment_3_Library_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Book harryPotter = new Book("Harry Potter", "JK Rowling", 399);
            Console.WriteLine(Book.NumberOfBooks);
            Console.WriteLine(harryPotter.GetTitle());
            Console.WriteLine(harryPotter.GetAuthor());
            Console.WriteLine(harryPotter.GetPages());
            Console.WriteLine(harryPotter.isBorrowed());

            harryPotter.BorrowBook();
            Console.WriteLine(harryPotter.isBorrowed());
            harryPotter.BorrowBook();

            harryPotter.ReturnBook();
            harryPotter.ReturnBook();

            Book Bible = new Book("Bible", 105);
            Console.WriteLine(Bible.GetTitle());
            Console.WriteLine(Bible.GetAuthor());
            Console.WriteLine(Bible.GetPages());

            Book DoubleAuthor = new Book("Double Author", "Bob", "James", 111);
            Console.WriteLine(DoubleAuthor.GetTitle());
            Console.WriteLine(DoubleAuthor.GetAuthor());
            Console.Write(DoubleAuthor.GetCoAuthor());
            Console.WriteLine(DoubleAuthor.GetPages());

            Console.WriteLine(harryPotter.isOverdue());

                                               //train wreck
            Console.WriteLine(harryPotter.GetDueDate().ToShortDateString());
        }
    }
}
