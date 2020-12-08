using System;
using System.Collections.Generic;
using System.Text;

namespace OpenCLosePrincipleRight
{
    class Circle : Schape
    { 
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double Area()
        {
            double area = Radius * Radius * Math.PI;
            return area;
        }
    }
}
