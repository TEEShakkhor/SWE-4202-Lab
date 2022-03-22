using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab_final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Student> students = new List<Student>();


        public double calculatebestofQuiz(string Quiz1, string Quiz2, string Quiz3, string Quiz4)
        {
            double quiz1 = Convert.ToDouble(Quiz1);
            double quiz2 = Convert.ToDouble(Quiz2);
            double quiz3 = Convert.ToDouble(Quiz3);
            double quiz4 = Convert.ToDouble(Quiz4);
            double[] quizmark = { quiz1, quiz2, quiz3, quiz4 };
            Array.Sort(quizmark);
            double quiztotal = quizmark[1] + quizmark[2] + quizmark[3];
            return quiztotal;

        }

        public double calculatetotalMark(string Attend, double  Quiztotal, string Mid, string Final, string Viva)
        {
            double attend = Convert.ToDouble(Attend);
            double mid = Convert.ToDouble(Mid);
            double final = Convert.ToDouble(Final);
            double viva = Convert.ToDouble(Viva);
            double totalmark = attend + Quiztotal + mid + final + viva;
            return totalmark;

        }

        public double calculatepercentage(double totalMark)
        {
            double percentage = (totalMark * 100) / 300;
            return percentage;
        }

        public string calculateGrade(double result)
        {
            string grade;
            if (result >= 80 && result <= 100)
            { grade = "A+"; }
            else if (result >= 75 && result < 80)
            { grade = "A"; }
            else if (result >= 70 && result < 75)
            { grade = "A-"; }
            else if (result >= 65 && result < 70)
            { grade = "B+"; }
            else if (result >= 60 && result < 65)
            { grade = "B"; }
            else if (result >= 55 && result < 60)
            { grade = "B-"; }
            else if (result >= 50 && result < 55)
            { grade = "C+"; }
            else if (result >= 45 && result < 50)
            { grade = "C"; }
            else if (result >= 40 && result < 45)
            { grade = "D"; }
            else if (result >= 0 && result < 40)
            { grade = "F"; }
            else { grade = "Illegal grade"; }

            return grade;
        }

        private void SearchIDButton_Click(object sender, EventArgs e)
        {
            string searchID = searchIDTB.Text;
            bool flag = false;

            var List = from student in students
                       where student.ID == searchID
                       select student;

            foreach (var student in List)
            {
                    attendanceLabel.Text = student.ATTEND;
                    quiz1Label.Text = student.QUIZ1;
                    quiz2Label.Text = student.QUIZ2;
                    quiz3Label.Text = student.QUIZ3;
                    quiz4Label.Text = student.QUIZ4;
                    quiztotalLabel.Text = student.QUIZTOTAL;
                    midLabel.Text = student.MID;
                    finalLabel.Text = student.FINAL;
                    vivaLabel.Text = student.VIVA;
                    totalLabel.Text = student.TOTAL;
                percentLabel.Text = student.PERCENTAGE + "%";
                gradeLabel.Text = student.GRADE;
                flag = true;
                MessageBox.Show("Student info updated");
            }
            if(flag==false)
            {
                MessageBox.Show("Student not found");
                return;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var reader = new StreamReader(@"D:\SWE4201MarkSheet1.csv"))
            {
                listBox1.Items.Add("ID \t\t Name \t\t\t Percentage \t Grade");
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    Student student = new Student();
                    student.ID = values[0];
                    student.NAME = values[1];
                    if (values[2] != "")
                    {
                        student.ATTEND = values[2];
                    }
                    if (values[3] != "")
                    {
                        student.QUIZ1 = values[3];
                    }
                    if (values[4] != "")
                    {
                        student.QUIZ2 = values[4];
                    }
                    if (values[5] != "")
                    {
                        student.QUIZ3 = values[5];
                    }
                    if (values[6] != "")
                    {
                        student.QUIZ4 = values[6];
                    }
                    if (values[7] != "")
                    {
                        student.MID = values[7];
                    }
                    if (values[8] != "")
                    {
                        student.FINAL = values[8];
                    }
                    if (values[9] != "")
                    {
                        student.VIVA = values[9];
                    }

                    if(student.ID != "ID")
                    {
                        double quizSum = Math.Round(calculatebestofQuiz(student.QUIZ1, student.QUIZ2, student.QUIZ3, student.QUIZ4), 2);
                        double totalMark = Math.Round(calculatetotalMark(student.ATTEND, quizSum, student.MID, student.FINAL, student.VIVA), 2);
                        double percentage = Math.Round(calculatepercentage(totalMark), 2);
                        string grade = calculateGrade(percentage);

                        student.TOTAL = Convert.ToString(totalMark);
                        student.QUIZTOTAL = Convert.ToString(quizSum);
                        student.PERCENTAGE = Convert.ToString(percentage);  
                        student.GRADE = Convert.ToString(grade);

                        students.Add(student);
                        listBox1.Items.Add(student.ID + "\t" + student.NAME + "\t\t" + student.PERCENTAGE +"%" + "\t\t" + student.GRADE);

                    }

                }
            }
        }
    }
}
