using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangingAreaPerAlexF
{
    public partial class frmChangingAreaPer : Form
    {
        public frmChangingAreaPer()
        {
            InitializeComponent();
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            // Exits Program
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //declare local variables
            double length, width, perimeter, area;

            // convert the string from each text box to a double
            length = double.Parse(txtLength.Text);
            width = double.Parse(txtWidth.Text);

            //calculate the area and the perimeter
            area = length * width;
            perimeter = 2 * (length + width);

            // insert the area and the perimeter labels with their respective answers
            
        }
    }
}
