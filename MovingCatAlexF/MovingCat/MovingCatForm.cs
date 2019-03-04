/*
 * Created by: Alex Forgeron
 * Created on: 14-02-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #9 - Moving Cat
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

namespace MovingCat
{
    public partial class MovingCatForm : Form
    {
        public MovingCatForm()
        {
            InitializeComponent();
        }

        private void mniCat1_Click(object sender, EventArgs e)
        {
            this.picCat.Image = Properties.Resources.cat1;
        }

        private void mniCat2_Click(object sender, EventArgs e)
        {
            this.picCat.Image = Properties.Resources.cat2;
        }

        private void picCat_Click(object sender, EventArgs e)
        {


        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
