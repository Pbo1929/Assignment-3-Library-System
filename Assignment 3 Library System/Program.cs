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

        }
    }
}
