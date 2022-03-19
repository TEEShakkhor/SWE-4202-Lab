using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System
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
        List<Medicine> Medicines = new List< Medicine > ();
        List<Medicine> BoughtMedicines = new List<Medicine>();

        private void StockMedButton_Click(object sender, EventArgs e)
        {
            bool flag = false;

            string MedName = StockMedNameTB.Text;
            int MedQty = Convert.ToInt32(StockMedQtyTB.Text);
            int MedUnitPrice = Convert.ToInt32(StockMedUnitPriceTB.Text);

            foreach (Medicine med in Medicines)
            {
                if (med.medname == MedName)
                {
                    flag = true;
                    med.medqty = med.medqty + MedQty;
                    med.medunitprice=MedUnitPrice;
                    Medicines.Add(med);
                    MessageBox.Show("Medicine has been successfully added.Name: " + med.medname + ",Quantity: " + med.medqty);
                    return;
                }
            }
            if (flag == false)
            {
                Medicine dummed = new Medicine();
                dummed.medname = MedName;
                dummed.medqty = MedQty;
                dummed.medunitprice=MedUnitPrice;

                Medicines.Add(dummed);

                InfoCB.Items.Add(dummed.medname);

                BuyMedCB.Items.Add(dummed.medname);


                MessageBox.Show("Medicine has been successfully listed.Name: " + dummed.medname + ",Quantity: " + dummed.medqty);
            }

        }

        private void BuyMedicineButton_Click(object sender, EventArgs e)
        {
            string BuyMedName = BuyMedCB.Text;
            int BuyMedQty = Convert.ToInt32(BuyMedQtyTB.Text);
            int BuyMedUnitPrice;
            int BuyMedTotalPrice;
            bool flag = false;

            foreach (Medicine Med in Medicines)
            {
                if (Med.medname == BuyMedName && Med.medqty >= BuyMedQty)
                {
                    flag = true;
                    Med.medqty -= BuyMedQty;
                    BuyMedUnitPrice = Med.medunitprice;
                    BuyMedTotalPrice = BuyMedUnitPrice * BuyMedQty;
                    MessageBox.Show("You have successfuly purchased:" + BuyMedName + "," + BuyMedQty + " units. You have to pay: " + Convert.ToString(BuyMedTotalPrice));
                    
                    bool flag2 = false;
                    
                    foreach (Medicine M in BoughtMedicines)
                    {
                        if (M.medname == BuyMedName)
                        {
                            flag2 = true;
                            M.medbought += BuyMedQty;
                            return;
                        }
                    }
                    if (flag2 == false)
                    {
                        Med.medbought += BuyMedQty;
                        BoughtMedicines.Add(Med);
                    }
                    return;
                }
                if (Med.medname == BuyMedName && Med.medqty < BuyMedQty)
                {
                    MessageBox.Show("Not enough Stock.");
                    return;
                }
            }
            if (flag == false)
            {
                MessageBox.Show("Medicine is not Found");
            }

        }

        private void CheckInfoButton_Click(object sender, EventArgs e)
        {
            string SearchMedName = InfoCB.Text;
            string MedInfo;
            MedicineInfoListbox.Items.Clear();
            bool flag = false;
            foreach (Medicine Med in Medicines)
            {
                if (SearchMedName == Med.medname)
                {
                    flag = true;
                    MedInfo = Med.medname + "\t" + Med.medqty + "\t" + Convert.ToString(Med.medunitprice);
                    MedicineInfoListbox.Items.Add(MedInfo);
                    break;
                }
            }
            if (flag == false)
            {
                MessageBox.Show("Medicine is not found.");
            }
        }

        private void CheckBalanceButton_Click(object sender, EventArgs e)
        {
            int TotalBalance = 0;
            foreach (Medicine Med in BoughtMedicines)
            {
                TotalBalance +=(Med.medunitprice * Med.medbought);
            }
            MessageBox.Show("Balance: " + Convert.ToString(TotalBalance));
        }
    }
    
}
