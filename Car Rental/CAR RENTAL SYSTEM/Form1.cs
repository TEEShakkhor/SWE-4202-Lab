using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRental;

namespace CAR_RENTAL_SYSTEM
{
    public partial class Form1 : Form
    {
        List <CAR>cars = new List <CAR> ();
        List<USER> users = new List<USER>();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveUser_Click(object sender, EventArgs e)
        {
            int USERID = Convert.ToInt32(UserIdInputTextBox.Text);
            string USERNAME = UserNameInputTextBox.Text;
            string USERADDRESS = UserAddressInputTextBox.Text;
            string USERDESTINATION = UserDestinationInputTextBox.Text;

            USER dummy = new USER (USERID,USERNAME,USERADDRESS,USERDESTINATION);
            users.Add(dummy);
            MessageBox.Show("User has been saved successfully.");
        }

        private void SaveCar_Click(object sender, EventArgs e)
        {
            string CARNAME = CarNameInputTextBox.Text;
            string CARMODEL= CarModelInputTextbox.Text;
            int CARNUMBER= Convert.ToInt32(CarNumberInputTextBox.Text);

            if(CARNUMBER<0)
            {
                MessageBox.Show("Number of Cars Can't be Negative.");
                return;
            }

            CAR dummy = new CAR(CARNAME, CARMODEL, CARNUMBER);
            cars.Add(dummy);
            MessageBox.Show("Car has been saved successfully.");
        }

        private void UserHistory_Click(object sender, EventArgs e)
        {
            int HistoryUserId = Convert.ToInt32(UserIdOutputTextbox.Text);
            bool flag= false;
            foreach (USER user in users)
            {
                if(user.UserId == HistoryUserId)
                {
                    flag = true;
                    UserNameOutputTextbox.Text = user.UserName;
                    UserAddressOutputTextbox.Text = user.Address;
                    CarRentedOutputTextbox.Text = user.CarRented;
                    UserDestinationOutputTextbox.Text= user.Destination;
                }
                if(flag==false)
                {
                    MessageBox.Show("User Could Not be Found.");
                }
            }

        }

        private void CarHistory_Click(object sender, EventArgs e)
        {
            string HistoryCarName = CarNameOutputTextbox.Text;
            bool flag = false;
            foreach (CAR car in cars)
            {
                if (car.CarName == HistoryCarName)
                {
                    flag = true;
                    string NumberCar = Convert.ToString(car.CarNumber);
                    CarModelOutputTextbox.Text = car.CarModel;
                    CarUnitOutputTextbox.Text = NumberCar;
                }
                if (flag == false)
                {
                    MessageBox.Show("Car Could Not be Found.");
                }
            }
        }

        private void RentCar_Click(object sender, EventArgs e)
        {
            bool flagCar = false;
            bool flagUser = false;
            int userid = Convert.ToInt32(UserIdUpdateTextbox.Text);
            string carname = CarNameUpdateTextbox.Text;
            foreach (USER user in users)
            {
                if (user.UserId == userid)
                {
                    flagUser = true;
                    user.CarRented = carname;
                }
                if (flagUser == false)
                {
                    MessageBox.Show("User Could Not be Found.");
                }
            }
            foreach (CAR car in cars)
            {
                if (car.CarName == carname)
                {
                    flagCar = true;
                    if (flagUser == true)
                    {
                        car.CarNumber = car.CarNumber - 1;
                        if (car.CarNumber > 0)
                        {
                            MessageBox.Show("Car Rented Successfully");
                        }
                        if (car.CarNumber < 0)
                        {
                            MessageBox.Show("Car Can't be Negative");
                            car.CarNumber++;
                        }

                    }
                }
                if (flagCar == false)
                {
                    MessageBox.Show("Car Could Not be Found.");
                }
            }
        }
    }
}
