using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Enrollment
{
    public class Course
    {
        public string Title, Level;
        public double Fee;

        public Course(string title, string level, double fee)
        {
            this.Title = title;
            this.Level = level;
            this.Fee = fee;
        }

        public string GetCourseInfo()
        {
            string info = Title + "\t" + Level;
            return info;
        }
    }
}
