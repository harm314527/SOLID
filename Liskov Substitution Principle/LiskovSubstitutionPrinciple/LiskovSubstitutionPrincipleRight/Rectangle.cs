using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitutionPrincipleRight
{
    public class Rectangle : Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public override int Area()
        {
            return Height * Width;
        }
    }
}
