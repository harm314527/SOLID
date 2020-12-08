using System;

namespace SingleResponsibilityRight
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = "Harminium";
            DateTime release = new DateTime(2020, 5, 12);
            string name = "Harm van Veen";
            string birthplace = "Eindhoven";
            int age = 24;
            Author me = new Author(name, age, birthplace);
            Book Harminium = new Book(title, release,me);

            Console.WriteLine(Harminium.ToString());
        }
    }
}
