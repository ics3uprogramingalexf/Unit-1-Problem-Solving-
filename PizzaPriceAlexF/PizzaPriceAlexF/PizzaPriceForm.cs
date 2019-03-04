/*
 * Created by: Alexander Forgeron
 * Created on: 26-02-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #11 - Top-Down Design & Flow Charts
 * This program calculates the price of a pizza based off diameter
*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaPriceAlexF
{
    public partial class frmPizzaPrice : Form
    {
        public frmPizzaPrice()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double diameter, subTotal, total;
            diameter = (double)nudPrice.Value;

            subTotal = ((diameter * 0.50) + 0.75 + 0.99);
            total = subTotal * 1.13;
            lblSubtotal.Text = "Subtotal = " + Convert.ToString(subTotal) + "$";
            lblTotal.Text = "Total = " + Convert.ToString(total) + "$";
        }
    }
}
