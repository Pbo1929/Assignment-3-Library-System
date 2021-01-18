using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_3_Library_System
{
    class Book
    {
        private string Title;
        private string Author;
        private string CoAuthor;
        private int Pages;
        private bool Borrowed;
        private DateTime dueDate;

        public static int NumberOfBooks = 0;

        public Book(string Title, string Author, int Pages)
        {
            this.Title = Title;
            this.Author = Author;
            this.Pages = Pages;
            this.Borrowed = false;

            NumberOfBooks = NumberOfBooks + 1;
        }

        public Book(string Title, int Pages)
        {
            this.Title = Title;
            this.Pages = Pages;
            this.Borrowed = false;

            NumberOfBooks = NumberOfBooks + 1;
        }

        public Book(string Title, string Author, string CoAuthor, int Pages)
        {
            this.Title = Title;
            this.Author = Author;
            this.CoAuthor = CoAuthor;
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

        public string GetCoAuthor()
        {
            return CoAuthor;
        }

        public int GetPages()
        {
            return Pages;
        }

        public DateTime GetDueDate()
        {
            return dueDate;
        }

        public bool isBorrowed()
        {
            return Borrowed;
        }

        public bool isOverdue()
        {
            //return true if overdue
            //return false if not overdue

            DateTime Today = DateTime.Now;
            int Overdue = DateTime.Compare(Today, dueDate);
            //-1 is book is not overdue
            //0 is book on time
            //+1 is book is overdue
            
            if(Overdue == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void BorrowBook()
        {
            if (Borrowed == false)
            {
                Borrowed = true;
                dueDate = DateTime.Now.AddDays(7);
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
