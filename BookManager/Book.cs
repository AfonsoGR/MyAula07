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

        //constructor
        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
        }

        //method that returns the title
        public string GetTitle()
        {
            return title;
        }

        //method that sets the title
        public void SetTitle(string title)
        {
            this.title = title;
        }

        //method dat counts words
        public void AssignWordCountFromText(string text)
        {
            wordCount = text.Split(' ').Length;
        }
    }
}
