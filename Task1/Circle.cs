using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class Circle
    {

        public static double CalculateLength(double radius)
        {
            return 2*Math.PI*radius;
        }

        public static double CalculateArea(double radius)
        {
            return Math.PI * radius*radius;
        }

        public static bool IsPointInCircle(double x, double y, double r, double x0, double y0)
        {    
            return Math.Sqrt((x0 - x) * (x0 - x) + (y0 - y) * (y0 - y)) <= r;
        }
    }
}
