using System;

namespace LiskovSubstitutionPrincipleWrong
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle { Height = 3, Width = 5 };
           
            int rectarea =AreaCalculator.CalculateArea(rect);
            Console.WriteLine("Rectangle area should be 15 and it is: " + rectarea);

          
            Square square = new Square { Height = 3 };

            int squararea = AreaCalculator.CalculateArea(square);
            Console.WriteLine("Square area should be 9 and it is: " + squararea);
        }
    }
}
