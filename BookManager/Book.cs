using System;
using System.Collections.Generic;
using System.Text;

namespace BookManager
{
    class Book
    {
        //private variables
        private string title;
        private string author;
        private int pages;
        private int wordCount;
        private static int BookCount;

        //constructor
        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
            BookCount++;
        }

        //method that returns the title
        public string GetTitle()
        {
            return title;
        }

        //method that sets the title => altered to check if title is null and >0, then saves
        public void SetTitle(string title)
        {
            if (title != null && title.Length > 0)
            {
                this.title = title;
            }
        }

        //method that counts words
        public void AssignWordCountFromText(string text)
        {
            wordCount = text.Split(' ').Length;
        }

        //method that returns the length of the title
        public int GetTitleLength()
        {
            return title.Length;
        }

        //method that returns bookCount's value
        public static int GetBookCount() => BookCount;

        //constructor static
        static Book()
        {
            BookCount = 0;
        }
    }
}
