using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Circle:_2D
    {
        public double Radius,Area;
        public Circle(double radius,double area)
        {
            this.Radius = radius;
            this.Area = area;
        }
        public override double get_Area(double area)
        {
            Area = Math.PI * Math.pow(Radius,2);
            return Area;
        }
    }
}
