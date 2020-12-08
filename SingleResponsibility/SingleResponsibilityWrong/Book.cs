using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibilityWrong
{
    class Book
    {
        private string Title { get; set; }
        private DateTime Release { get; set; }
        private string Writer { get; set; }
        private int AgeOfWriter { get; set; }
        private string BirthplaceOfWriter { get; set; }

        public Book(string title, DateTime release,string writer, string birthplaceOfWriter, int ageOfWriter)
        {
            Title = title;
            Release = release;
            Writer = writer;
            AgeOfWriter = ageOfWriter;
            BirthplaceOfWriter = birthplaceOfWriter;
        }

        public string ToString()
        {
            return "The title of the book is " + Title + ".\n" +
                   "The Release date of the book is " + Release + ".\n" +
                   "The name of the author of the book is " + Writer + ".\n" +
                   "The age of the author of the book is " + AgeOfWriter + ".\n" +
                   "The birthplace of the author of the book is " + BirthplaceOfWriter + ".";
                  
        }
    }
}
