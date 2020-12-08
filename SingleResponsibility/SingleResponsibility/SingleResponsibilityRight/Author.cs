using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibilityRight
{
  
    class Author
    {
        private string Writer { get; set; }
        private int AgeOfWriter { get; set; }
        private string BirthplaceOfWriter { get; set; }

        public Author(string writer, int ageOfWriter, string birthplaceOfWriter)
        {
            Writer = writer;
            AgeOfWriter = ageOfWriter;
            BirthplaceOfWriter = birthplaceOfWriter;
        }

        public string ToString()
        {
            return "The name of the author of the book is " + Writer + ".\n" +
                   "The age of the author of the book is " + AgeOfWriter + ".\n" +
                   "The birthplace of the author of the book is " + BirthplaceOfWriter + ".";

        }
    }
}
