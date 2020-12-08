using System;
using System.Collections.Generic;
using System.Text;

namespace OpenCLosePrincipleRight
{
    class Rectangle : Schape
    {
       public double Height { get; set; }
       public double Width { get; set; }
     
        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public override double Area()
        {
            double area = Height * Width;
            return area;
        }
    }
}
