using System;

namespace InterfaceSegregationPrincipleRight
{
    class Program
    {
        static void Main(string[] args)
        {
            Programmer Tom = new Programmer();
            Tom.Work();
            Console.WriteLine("\n");

            Teamlead Mark = new Teamlead();
            Mark.Work();
            Console.WriteLine("\n");

            Manager Harm = new Manager();
            Harm.Work();
            Console.WriteLine("\n");
        }
    }
}
