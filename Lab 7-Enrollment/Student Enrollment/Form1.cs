using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Enrollment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        List<Student> StudentList = new List<Student>();
        List<Professional> ProfessionalList = new List<Professional>();
        List<Course> CourseList = new List<Course>();

        string type, level, Level;
        double fee;
        string studentLevel, courseLevel;

        private void EnrollCourseButton_Click(object sender, EventArgs e)
        {
            string course = SelectCourseCB.Text;
            string studentReg = SelectParticipantCB.Text;
            

            for (int i = 0; i < StudentList.Count; i++)
            {
                if (studentReg == StudentList[i].RegNo)
                {
                    studentLevel = StudentList[i].Level;
                }
            }

            for (int i = 0; i < ProfessionalList.Count; i++)
            {
                if (studentReg == ProfessionalList[i].RegNo)
                {
                    studentLevel = ProfessionalList[i].Level;
                }
            }

            for (int i = 0; i < CourseList.Count; i++)
            {
                if (course == CourseList[i].Title)
                {
                    courseLevel = CourseList[i].Level;
                }
            }

            if (courseLevel == studentLevel)
            {
                for (int i = 0; i < CourseList.Count; i++)
                {
                    if (course == CourseList[i].Title)
                    {
                        fee = CourseList[i].Fee;
                     

                    }
                }
                for (int i = 0; i < StudentList.Count; i++)
                {
                    if (studentReg == StudentList[i].RegNo)
                    {
                        StudentList[i].Course = course;
                        label19.Text = Convert.ToString(StudentList[i].GetCourseFee(fee));
                    }
                }
                for (int i = 0; i < ProfessionalList.Count; i++)
                {
                    if (studentReg == ProfessionalList[i].RegNo)
                    {
                        ProfessionalList[i].Course = course;
                        label19.Text = Convert.ToString(ProfessionalList[i].GetCourseFee(fee));
                    }
                }
                SelectStudentCB.Items.Add(studentReg);

                MessageBox.Show("Enrolled");
            }
            else
            {
                label19.Text = "";
                MessageBox.Show("Course is on " + courseLevel + " Level but Participant is on " + studentLevel + " Level!");
            }
        }

        private void ShowEnrolledCourseButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Name \t Level \t Fee");
            string studentReg = SelectStudentCB.Text;

            for (int i = 0; i < StudentList.Count; i++)
            {
                if (studentReg == StudentList[i].RegNo)
                {
                    string course = StudentList[i].Course;

                    for (int j = 0; j < CourseList.Count; j++)
                    {
                        if (course == CourseList[j].Title)
                        {
                            listBox1.Items.Add(CourseList[j].GetCourseInfo() + StudentList[i].GetCourseFee(CourseList[j].Fee));
                        }
                    }
                }
            }

            for (int i = 0; i < ProfessionalList.Count; i++)
            {
                if (studentReg == ProfessionalList[i].RegNo)
                {
                    string course = ProfessionalList[i].Course;

                    for (int j = 0; j < CourseList.Count; j++)
                    {
                        if (course == CourseList[j].Title)
                        {
                            listBox1.Items.Add(CourseList[j].GetCourseInfo() + "\t" + ProfessionalList[i].GetCourseFee(CourseList[j].Fee));
                        }
                    }
                }
            }
        }

        private void CourseAddButton_Click(object sender, EventArgs e)
        {
            string title = CourseTitleTB.Text;
            int fee = Convert.ToInt32(CourseFeeTB.Text);
            
            if(CourseBeginnerRB.Checked == true)
            {
                Level = "Beginner";
            }
            else if (CourseIntermediateRB.Checked == true)
            {
                Level = "Intermediate";
            }
            else if (CourseAdvancedRB.Checked == true)
            {
                Level = "Advanced";
            }
            Course course = new Course(title, Level, fee);
            CourseList.Add(course);
            SelectCourseCB.Items.Add(title);

            MessageBox.Show("Course Added");      
        }

        

        private void ParticipantAddButton_Click(object sender, EventArgs e)
        {
            string name = nameTB.Text;
            string regno = regnoTB.Text;
            string contact = contactTB.Text;
            string mail = emailTB.Text;


            if (ParticipantStudentRB.Checked == true)
            {
                type = "Student";
            }
            else if (ParticipantProfessionalRB.Checked == true)
            {
                type = "Professional";
            }

            if (ParticipantBeginnerRB.Checked == true)
            {
                level = "Beginner";
            }
            else if (ParticipantIntermediateRB.Checked == true)
            {
                level = "Intermediate";
            }
            else if (ParticipantAdvancedRB.Checked == true)
            {
                level = "Advanced";
            }
            else if (ParticipantBeginnerRB.Checked == false && ParticipantIntermediateRB.Checked == false && ParticipantAdvancedRB.Checked == false && type == "student")
            {
                Student student = new Student(name, regno, contact, mail);
                level = "Beginner";
                student.Level = level;
                StudentList.Add(student);
            }
            else if (ParticipantBeginnerRB.Checked == false && ParticipantIntermediateRB.Checked == false && ParticipantAdvancedRB.Checked == false && type == "professional")
            {
                Professional professional = new Professional(name, regno, contact, mail);
                level = "Beginner";
                professional.Level = level;
                ProfessionalList.Add(professional);
            }

            if (type == "Student" && level != "")
            {
                Student student = new Student(name, regno, contact, mail, level);
                StudentList.Add(student);
            }
            else if (type == "Professional" && level != "")
            {
                Professional professional = new Professional(name, regno, contact, mail, level);
                ProfessionalList.Add(professional);
            }

            SelectParticipantCB.Items.Add(regno);

            MessageBox.Show("Participant Added");
        }

        
    }
}
