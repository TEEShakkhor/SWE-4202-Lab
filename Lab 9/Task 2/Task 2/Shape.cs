using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Shape
    {
        public string Name;
        public Shape(string name)
        {
            this.Name = name;
        }
        public string get_info()
        {
            string info= this.Name;
            return info;
        }
    }
}
