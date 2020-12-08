using System;
using System.Collections.Generic;
using System.Text;

namespace OpenCLosePrincipleRight
{
    class AreaCalculator
    {
        public AreaCalculator()
        {

        }
        public double TotalArea(List<Schape> Schapes)
        {
            double area = 0;
            
            foreach (Schape schape in Schapes)
            {

              area += schape.Area();
                
            }
            return area;
        }
    }
}
