using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosePrincipleWrong
{
    class Rectangle
    {
       public double Height { get; set; }
       public double Width { get; set; }
     
        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }
    }
}
