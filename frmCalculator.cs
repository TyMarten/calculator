using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }

        private void lblOut_Click(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double Gr1 = Convert.ToDouble(txtG1.Text);
            double Gr2 = Convert.ToDouble(txtG2.Text);
            double Gr3 = Convert.ToDouble(txtG3.Text);
            double Gr4 = Convert.ToDouble(txtG4.Text);
            double Gr5 = Convert.ToDouble(txtG5.Text);

            double totalGrade = Gr1 + Gr2 + Gr3 + Gr4 + Gr5;


            lblOut.Text = "Your Average Mark is " + totalGrade / 5 + "%";
        }
    }
}
