using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LengthCalculator
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtCM_KeyUp(object sender, KeyEventArgs e)
        {
            double douCM = Convert.ToDouble(txtCM.Text);

            txtM.Text = string.Format("{0:0.##########}", douCM / 100);
        }

        private void btnAllClear_Click(object sender, EventArgs e)
        {
 
        }
    }
}
