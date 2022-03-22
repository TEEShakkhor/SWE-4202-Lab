using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class _2D:Shape
    {
        public double Area, Perimeter;
        public _2D(double area,double perimeter)
        {
            this.Area = area;
            this.Perimeter = perimeter;
        }
        public override string get_info()
        {
            string info = this.Name + this.Area + this.Perimeter;
            return info;
        }
        public double get_Area()
        { 

        }
        public double get_perimeter()
        {

        }

    }
}
