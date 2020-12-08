using System;

namespace SingleResponsibilityWrong
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
            
            Book Harminium = new Book(title, release, name, birthplace, age);

            Console.WriteLine(Harminium.ToString());
        }
    }
}
