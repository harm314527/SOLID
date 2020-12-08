using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibilityRight
{
    class Book
    {
        private string Title { get; set; }
        private DateTime Release { get; set; }
        private Author Author { get; set; }

        public Book(string title, DateTime release, Author author)
        {
            Title = title;
            Release = release;
            Author = author;
        }

  

        public string ToString()
        {
            return "The title of the book is " + Title + ".\n" +
                   "The Release date of the book is " + Release + ".\n" +
                    Author.ToString() + "\n";                  
        }
    }
}
