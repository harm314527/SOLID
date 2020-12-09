using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitutionPrincipleRight
{
    public class Square : Shape
    {
        public int Sidelength { get; set; }
        public override int Area()
        {
            return Sidelength * Sidelength;
        }

    }
}
