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

namespace Csv_file_read_and_write
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<User> users = new List<User>();

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            using (var reader = new StreamReader(@"D:\SWE Lab\Lab 10-Csv\Csv file read and write\userInfo1.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    User user = new User();
                    user.FIRSTNAME = values[0];
                    user.LASTNAME = values[1];
                    user.ADDRESS = values[2];
                    user.CITY = values[3];
                    user.COUNTY = values[4];
                    user.STATE = values[5];
                    user.ZIP = values[6];
                    user.PHONE1 = values[7];
                    user.PHONE = values[8];
                    user.EMAIL = values[9];

                    users.Add(user);
                    ListBox.Items.Add(user.FIRSTNAME + "\t" + user.LASTNAME + "\t" + user.EMAIL);

                }
            }
        }
        string file = "searchresults.txt";
        private void SearchButton_Click(object sender, EventArgs e)
        {
            foreach (User user in users)
            {
                if (user.EMAIL == searchbox.Text)
                {
                    Name_Box.Text = user.FIRSTNAME + " " + user.LASTNAME;
                    Address_Box.Text = user.ADDRESS;
                    City_Box.Text = user.CITY;
                    County_Box.Text = user.COUNTY;
                    State_Box.Text = user.STATE;
                    Zip_Box.Text = user.ZIP;
                    Phone1_Box.Text = user.PHONE1;
                    Phone_Box.Text = user.PHONE;

                    using (System.IO.StreamWriter sr = new System.IO.StreamWriter(@file, true))
                    {
                        string s = user.FIRSTNAME + "\t" + user.LASTNAME + "\t" + user.EMAIL + "\t" + user.ADDRESS + "\t" + user.PHONE;
                        sr.WriteLine(s);
                    }
                }
                
            }
        }

    }
}
