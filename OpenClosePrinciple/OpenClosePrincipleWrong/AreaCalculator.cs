using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosePrincipleWrong
{
    class AreaCalculator
    {
        public AreaCalculator()
        {

        }
        public double TotalArea(List<object> arrObjects)
        {
            double area = 0;
            Rectangle objRectangle;
            Circle objCircle;
            foreach (var obj in arrObjects)
            {
                if (obj is Rectangle)
                {
                    objRectangle = (Rectangle)obj;
                    area += objRectangle.Height * objRectangle.Width;
                }
                else
                {
                    objCircle = (Circle)obj;
                    area += objCircle.Radius * objCircle.Radius * Math.PI;
                }
            }
            return area;
        }
    }
}
