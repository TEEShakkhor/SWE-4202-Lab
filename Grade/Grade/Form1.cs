using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = student_name.Text;
            int attendance_marks_28 = Convert.ToInt32(no_of_attended_classes.Text);
            int Mid_marks = Convert.ToInt32(mid_marks.Text);
            int Final_marks = Convert.ToInt32(final_marks.Text);
            int quiz_marks_1 = Convert.ToInt32(quiz1_marks.Text);
            int quiz_marks_2 = Convert.ToInt32(quiz2_marks.Text);
            int quiz_marks_3 = Convert.ToInt32(quiz3_marks.Text);
            int quiz_marks_4 = Convert.ToInt32(quiz4_marks.Text);
            int[] quiz_marks = {quiz_marks_1, quiz_marks_2, quiz_marks_3, quiz_marks_4}; 
            Array.Sort(quiz_marks);
            Array.Reverse(quiz_marks);
            int total_quiz_marks = quiz_marks[0] + quiz_marks[1] + quiz_marks[2];
            double attendance_marks_30 = attendance_marks_28 * 30.0 / 28.0;
            attendance_marks_30 = Math.Round(attendance_marks_30, 0, MidpointRounding.AwayFromZero);
            int total_marks = Mid_marks + Final_marks + total_quiz_marks + Convert.ToInt32(attendance_marks_30);
            double percent_marks = total_marks / 3.0;
            percent_marks = Math.Round(percent_marks, 0, MidpointRounding.AwayFromZero);
            attendance_marks_output.Text = Convert.ToString(attendance_marks_30) + "/30";
            mid_marks_output.Text = Convert.ToString(Mid_marks) + "/75";
            final_marks_output.Text = Convert.ToString(Final_marks) + "/150"; 
            quiz_marks_output.Text = Convert.ToString(total_quiz_marks) + "/45"; 
            total_marks_output.Text = Convert.ToString(total_marks) + "/300";
            comment.Text = name + " obtained " + Convert.ToString(percent_marks) + "% marks";

            //grades
            if (percent_marks >= 80)
                grade_output.Text = "A+";
            else if (percent_marks >= 75 && percent_marks<80)
                grade_output.Text = "A";
            else if (percent_marks >= 70 && percent_marks < 75)
                grade_output.Text = "A-";
            else if (percent_marks >= 65 && percent_marks < 70)
                grade_output.Text = "B+";
            else if (percent_marks >= 60 && percent_marks < 65)
                grade_output.Text = "B";
            else if (percent_marks >= 55 && percent_marks < 60)
                grade_output.Text = "B-";
            else if (percent_marks >= 50 && percent_marks < 55)
                grade_output.Text = "C+";
            else if (percent_marks >= 45 && percent_marks < 50)
                grade_output.Text = "C";
            else if (percent_marks >= 40 && percent_marks < 45)
                grade_output.Text = "D";
            else if (percent_marks <40)
                grade_output.Text = "F";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
