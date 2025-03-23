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
        string strInput;
        double douOutput;
        public Form1()
        {
            InitializeComponent();
        }

        private void txtCM_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtCM.Text;
            if (double.TryParse(strInput, out douOutput) == true)
            {
                txtM.Text = string.Format("{0:0.##########}", douOutput / 100);
                txtKM.Text = string.Format("{0:0.##########}", douOutput / 100000);
                txtin.Text = string.Format("{0:0.##########}", douOutput / 2.54);
                txtFit.Text = string.Format("{0:0.##########}", douOutput / 30.48);
                txtYard.Text = string.Format("{0:0.##########}", douOutput / 91.44);
            }
            else 
            {
                txtInfo.Text = "請輸入數字";
                txtCM.Text = "";
            }
        }

        private void txtM_KeyUp(object sender, EventArgs e)
        {
            strInput = txtM.Text;
            if (double.TryParse(strInput, out douOutput) == true)
            {

                txtCM.Text = string.Format("{0:0.##########}", douOutput * 100);
                txtKM.Text = string.Format("{0:0.##########}", douOutput * 0.001);
                txtin.Text = string.Format("{0:0.##########}", douOutput * 39.37);
                txtFit.Text = string.Format("{0:0.##########}", douOutput * 3.28);
                txtYard.Text = string.Format("{0:0.##########}", douOutput  * 1.09);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtM.Text = "";
            }
            }

        private void txtKM_KeyUp(object sender, EventArgs e)
        {
            strInput = txtKM.Text;
            if (double.TryParse(strInput, out douOutput) == true)
            {


                txtCM.Text = string.Format("{0:0.##########}", douOutput * 100);
            txtM.Text = string.Format("{0:0.##########}", douOutput * 1000);
            txtin.Text = string.Format("{0:0.##########}", douOutput * 39370.1);
            txtFit.Text = string.Format("{0:0.##########}", douOutput * 3280.84);
            txtYard.Text = string.Format("{0:0.##########}", douOutput * 1093.61);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtKM.Text = "";
            }
        }

        private void txtin_KeyUp(object sender, EventArgs e)
        {
            strInput = txtin.Text;
            if (double.TryParse(strInput, out douOutput) == true)
            {

                txtCM.Text = string.Format("{0:0.##########}", douOutput * 2.54);
            txtM.Text = string.Format("{0:0.##########}", douOutput * 0.0254);
            txtKM.Text = string.Format("{0:0.##########}", douOutput * 0.0000254);
            txtFit.Text = string.Format("{0:0.##########}", douOutput * 0.0833);
            txtYard.Text = string.Format("{0:0.##########}", douOutput * 0.0278);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtin.Text = "";
            }
        }

        private void txtFit_KeyUp(object sender, EventArgs e)
        {
            strInput = txtFit.Text;
            if (double.TryParse(strInput, out douOutput) == true)
            {

                txtCM.Text = string.Format("{0:0.##########}", douOutput * 30.48);
            txtM.Text = string.Format("{0:0.##########}", douOutput * 0.3048);
            txtKM.Text = string.Format("{0:0.##########}", douOutput * 0.0003048);
            txtin.Text = string.Format("{0:0.##########}", douOutput * 12);
            txtYard.Text = string.Format("{0:0.##########}", douOutput * 0.3333);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtFit.Text = "";
            }
        }

        private void txtYard_KeyUp(object sender, EventArgs e)
        {
            strInput = txtYard.Text;
            if (double.TryParse(strInput, out douOutput) == true)
            {

                txtCM.Text = string.Format("{0:0.##########}", douOutput * 91.44);
            txtM.Text = string.Format("{0:0.##########}", douOutput * 0.9144);
            txtKM.Text = string.Format("{0:0.##########}", douOutput * 0.0009144);
            txtin.Text = string.Format("{0:0.##########}", douOutput * 36);
            txtFit.Text = string.Format("{0:0.##########}", douOutput * 3);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtYard.Text = "";
            }
        }

        private void btnAllClear_Click(object sender, EventArgs e)
        {
            txtCM.Text = "" ;
            txtM.Text = "" ;
            txtKM.Text = "" ;
            txtin.Text = "" ;
            txtFit.Text = "" ;
            txtYard.Text = "" ;

        }
    }
}
