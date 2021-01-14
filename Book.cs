using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3_LibrarySystem
{
    class Book
    {
        private string title;
        private string author;
        private int pages;
        private bool borrowed;

        private static int NumberOfBooks = 0;
        public Book(string title, string author, int pages)
        {
            this.title = title;
            this.author = author;
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
            }
            else
            {
                Console.WriteLine(title + " is not available");
            }
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
    }

}
