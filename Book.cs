using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3_LibrarySystem
{
    class Book
    {
        private string title;
        private string author;
        private string coauthor;
        private int pages;
        private bool borrowed;
        private DateTime dueDate;

        private static int NumberOfBooks = 0;
        public Book(string title, string author, int pages)
        {
            this.title = title;
            this.author = author;
            this.pages = pages;
            this.borrowed = false;

            NumberOfBooks = NumberOfBooks + 1;
        }
        public Book(string title,int pages)
        {
            this.title = title;
            this.pages = pages;
            this.borrowed = false;

            NumberOfBooks = NumberOfBooks + 1;
        }
        public Book(string title, string author, string coauthor, int pages)
        {
            this.title = title;
            this.author = author;
            this.coauthor = coauthor;
            this.pages = pages;
            this.borrowed = false;

            NumberOfBooks = NumberOfBooks + 1;
        }

        public static int GetNumberOfBooks()
        {
            return NumberOfBooks;
        }
        public string GetTitle()
        {
            return title;
        }
        public string GetAuthor()
        {
            return author;

        }
        public string GetBothAuthor()
        {
            return author + " " + coauthor;
            
        }
        public int GetPages()
        {
            return pages;
        }

        public bool IsBorrowed()
        {
            return borrowed;
        }
        public void BorrowBook()
        {
            if(borrowed == false)
            {
                borrowed = true;
                dueDate = DateTime.Now.AddDays(7);
            }
            else
            {
                Console.WriteLine(title + " is not available");
            }
        }
        public DateTime getDueDate()
        {
            return dueDate;
        }
        public void ReturnBook()
        {
            if(borrowed == true)
            {
                borrowed = false;
            }
            else
            {
                Console.WriteLine(title + " hasn't been borrowed");
            }

        }
        public bool IsOverDue()
        {
            DateTime today = DateTime.Now;
            int overdue = DateTime.Compare(today, dueDate);
            if(overdue == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }


}
