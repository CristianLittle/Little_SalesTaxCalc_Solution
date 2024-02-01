using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Little_SalesTaxCalc_Project
{
    public partial class Form1 : Form
    {
        double price;
        double wataxes = 0.086;
        double ortaxes = 0;
        int oneyear = 1000;
        int twoyear = 2000;
        int threeyear = 3000;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtMoney_TextChanged(object sender, EventArgs e)
        {
           price = double.Parse(txtMoney.Text);
        }

        private void ListWarranty_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ListState_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListState == WA)
            {
                WATaxes * price = double totalprice
            }
            else 
            {
                ortaxes* price = double orprice
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
           Application.Restart();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TotalPrice_TextChanged(object sender, EventArgs e)
        {
            display
        }
    }
}
