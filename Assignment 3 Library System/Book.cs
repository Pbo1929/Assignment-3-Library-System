using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_3_Library_System
{
    class Book
    {
        private string Title;
        private string Author;
        private int Pages;
        private bool Borrowed;

        public static int NumberOfBooks = 0;

        public Book(string Title, string Author, int Pages)
        {
            this.Title = Title;
            this.Author = Author;
            this.Pages = Pages;
            this.Borrowed = false;

            NumberOfBooks = NumberOfBooks + 1;
        }

        public string GetTitle()
        {
            return Title;
        }

        public string GetAuthor()
        {
            return Author;
        }

        public int GetPages()
        {
            return Pages;
        }

        public bool isBorrowed()
        {
            return Borrowed;
        }

        public void BorrowBook()
        {
            if (Borrowed == false)
            {
                Borrowed = true;
            }
            else
            {
                Console.WriteLine(Title + "is not available.");
            }
        }

        public void ReturnBook()
        {
            if(Borrowed == true)
            {
                Borrowed = false;
            }
            else
            {
                Console.WriteLine(Title + "is available.");
            }
        }
    }
}
