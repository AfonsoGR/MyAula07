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
    }
}
