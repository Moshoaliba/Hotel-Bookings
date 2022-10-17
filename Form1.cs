//Moshoaliba,K-34316345

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Bookings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            const decimal five_Star = 2000.00m, three_Star = 1300.00m, basic = 500.00m;
            decimal total = 0m;
            decimal price = 0m;
            decimal total_price = 0m;
            string day = " ";

            day = txtInput.Text;

            if (rb5Star.Checked)
            {
                lbOutput.Items.Add("5 STAR hotel");
                total += five_Star;
            }
            else if(rb3Star.Checked)
            {
                lbOutput.Items.Add("3 Star hotel");
                total += three_Star;
            }
            else if(rbBasic.Checked)
            {
                lbOutput.Items.Add("Basic hotel");
                total += basic;
            }
            else
            {
                lbOutput.Items.Add(" ");
            }

            if(checkBox1.Checked)
            {
                lbOutput.Items.Add("Balcony");
                price += 350;
            }
            if(checkBox2.Checked)
            {
                lbOutput.Items.Add("1 Bathroom & 1 Bedroom");
                price += 250;
            }
            if(checkBox3.Checked)
            {
                lbOutput.Items.Add("2 Bedrooms & 1 Bathroom");
                price += 350;
            }
            if(checkBox4.Checked)
            {
                lbOutput.Items.Add("3 Bedrooms & 2 Bathrooms");
                price += 450;
            }
            if(checkBox5.Checked)
            {
                lbOutput.Items.Add("4 Bedrooms & 2 Bathrooms");
                price += 550;
            }
            if(checkBox6.Checked)
            {
                lbOutput.Items.Add("Swimming pool");
                price += 400;
            }

            switch(day)
            {
                case "Monday":
                    MessageBox.Show("WE OPEN FROM 09:00 - 14:00 for Bookings");
                    break;
                case "Tuesday":
                    MessageBox.Show("WE OPEN FROM 09:00 - 14:00 for Bookings");
                    break;
                case "Wednesday":
                    MessageBox.Show("WE OPEN FROM 09:30 - 13:45 for Bookings");
                    break;
                case "Thursday":
                    MessageBox.Show("WE OPEN FROM 09:30 - 13:30 for Bookings");
                    break;
                case "Friday":
                    MessageBox.Show("WE OPEN FROM 09:00 - 16:00 for Bookings");
                    break;
                default:
                    MessageBox.Show("WE DONT DO BOOKINGS ON THIS DAY");
                    break;
            }

            if(int.TryParse(txtInput2.Text,out int days))
            {
                lbOutput.Items.Add("FOR " + days.ToString() + " DAYS");
                total_price += (total + price) * days;
                txtOutput.Text = "R " + total_price.ToString();
            }
            else
            {
                MessageBox.Show("INVALID INPUT FORMAT!!!");
            }
            this.Focus();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBookAgain_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
            txtInput2.Text = "";
            txtOutput.Text = "";
            lbOutput.Items.Clear();
        }
    }
}
