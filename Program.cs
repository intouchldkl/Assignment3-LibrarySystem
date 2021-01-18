using System;

namespace Assignment3_LibrarySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Book harryPotter = new Book("Harry Potter", "JK Rowling", 500);

            Book TheBible = new Book("The Bible", 500);
            Book Hopkinson = new Book("Hopkinson", "David Hopkinson", 500);
            Book Football = new Book("Football", "Cristiano Ronaldo", "Lionel Messi", 900);

            Console.WriteLine(Hopkinson.GetAuthor());
            Console.WriteLine(TheBible.GetTitle());
            Console.WriteLine(harryPotter.GetPages());
            Console.WriteLine(Football.GetBothAuthor());

            TheBible.BorrowBook();

            //train wreck
            Console.WriteLine(TheBible.getDueDate().ToShortDateString());

           Hopkinson = null;




        }
    }
}
