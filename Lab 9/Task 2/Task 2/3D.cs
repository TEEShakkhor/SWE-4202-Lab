using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class _3D:Shape
    {
        public double SurfaceArea,Volume;
        public _3D(double surfacearea, double volume)
        {
            this.SurfaceArea = surfacearea;
            this.Volume = volume;
        }
        public override string get_info()
        {
            string info = this.Name + this.SurfaceArea + this.Volume;
            return info;
        }
        public double get_SurfaceArea()
        {

        }
        public double get_volume()
        {

        }
    }
}
