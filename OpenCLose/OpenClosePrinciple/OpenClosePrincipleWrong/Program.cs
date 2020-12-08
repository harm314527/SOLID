using System;
using System.Collections.Generic;

namespace OpenClosePrincipleWrong
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Random random = new Random();
            List<object> objects = new List<object>();
            for (int i = 0; i < 5; i++)
            {
                int height = random.Next(1, 50);
                int width = random.Next(1, 50);
                Rectangle rect = new Rectangle(height,width);
                objects.Add(rect);
            }
            for (int i = 0; i < 5; i++)
            {
                int radius = random.Next(1, 50);
                Circle Circ = new Circle(radius);
                objects.Add(Circ);
            }
            AreaCalculator calculator = new AreaCalculator();
           double area = calculator.TotalArea(objects);
            Console.WriteLine("the Rea of the shapes in the list is " + area);
        }
    }
}
