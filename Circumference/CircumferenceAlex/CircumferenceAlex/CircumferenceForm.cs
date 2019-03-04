/*
 * Created by: Alexander Forgeron
 * Created on: 20-02-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #11 - Circumference of a circle
 * This program calculates the circumference of a circle 
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

namespace CircumferenceAlex
{
    public partial class CircumferenceForm : Form
    {
        public CircumferenceForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Declare constants
            const double PI = 3.14159;

            //Declare local values
            double circumference, radius;

            //convert the string form each text box to a double
            radius = double.Parse(txtInput.Text);
 
            circumference = 2 * PI * radius;
            this.lblAnswer.Text = Convert.ToString(circumference);
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
