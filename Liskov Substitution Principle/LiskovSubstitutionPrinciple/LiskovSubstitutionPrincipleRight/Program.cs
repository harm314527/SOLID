using System;

namespace LiskovSubstitutionPrincipleRight
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle { Height = 3, Width = 5 };

            int rectarea = rect.Area();
            Console.WriteLine("Rectangle area should be 15 and it is: " + rectarea);


            Shape square = new Square { Sidelength = 3};

            int squararea = square.Area();
            Console.WriteLine("Square area should be 9 and it is: " + squararea);
        }
    }
    }

