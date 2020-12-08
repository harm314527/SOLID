using System;
using System.Collections.Generic;

namespace OpenCLosePrincipleRight
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<Schape> schapes = new List<Schape>();
            for (int i = 0; i < 5; i++)
            {
                int height = random.Next(1, 50);
                int width = random.Next(1, 50);
                Schape rect = new Rectangle(height, width);
                schapes.Add(rect);
            }
            for (int i = 0; i < 5; i++)
            {
                int radius = random.Next(1, 50);
                Schape Circ = new Circle(radius);
                schapes.Add(Circ);
            }
            AreaCalculator calculator = new AreaCalculator();
            double area = calculator.TotalArea(schapes);
            Console.WriteLine("the Rea of the shapes in the list is " + area);
        }
    }
}
