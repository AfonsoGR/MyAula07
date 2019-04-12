using System;

namespace BookManager
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            string books;
            int booksN;
            Book [] parchments;

            //asks for number of books and converts the input
            Console.WriteLine("How many books?");
            books = Console.ReadLine();
            booksN = Convert.ToInt32(books);

            //initialize array
            parchments = new Book [booksN];

            //loop that asks for titles and 
            for (int i = 0; i < booksN, i++)
            {
                //variables
                string author, title;
                Book obra;

                //asks for title and author
                Console.WriteLine("What is it called?");
                title = Console.ReadLine();
                Console.WriteLine("who wrote it?");
                author = Console.ReadLine();

                //object book
                obra = new Book(title, author);
                //save it on an array
                parchments[i] = obra;
            }

            for (int i = 0; i < booksN, i++)
            {
                //variables
                string title = parchments[i].GetTitle();
                string author = parchments[i].GetAuthor();

                //prints title and its length and prints author
                Console.WriteLine($"The book is called: {title} (It has a length of{title.Length} caracters)");
                Console.WriteLine($"The author is called: {author}");
            }
        }
    }
}
