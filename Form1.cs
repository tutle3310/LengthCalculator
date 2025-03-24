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


private void caculateAnswer(int _kind, double _value)
        {
            if (_kind != 0)
                txtCM.Text = string.Format("{0:0.##########}", _value);
            if (_kind != 1)
                txtM.Text = string.Format("{0:0.##########}", _value / 100);
            if (_kind != 2)
                txtKM.Text = string.Format("{0:0.##########}", _value / 100000);
            if (_kind != 3)
                txtin.Text = string.Format("{0:0.##########}", _value / 2.54);
            if (_kind != 4)
                txtFit.Text = string.Format("{0:0.##########}", _value / 30.48);
            if (_kind != 5)
                txtYard.Text = string.Format("{0:0.##########}", _value / 91.44);
        }
        

        public Form1()
        {
            InitializeComponent();
        }

        private void txtCM_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtCM.Text;
            if (double.TryParse(strInput, out douOutput) == true)
            {
             caculateAnswer(0, douOutput);
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

                caculateAnswer(1, douOutput*100);
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

                caculateAnswer(2, douOutput*100000);
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

                caculateAnswer(3, douOutput*2.54);
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
                caculateAnswer(4, douOutput*30.48);
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
                caculateAnswer(5, douOutput*91.44);
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
