using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kberger1730ex1d
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAmountAustralia.Text = "0.00";
            txtAmountBhutan.Text = "0.00";
            txtAmountCR.Text = "0.00";
            txtAmountEurope.Text = "0.00";
            txtRateAustralia.Text = "0.717976";
            txtRateBhutan.Text = "0.0139831";
            txtRateCR.Text = "0.00176122";
            txtRateEurope.Text = "1.15528";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void australiaTextChanged(object sender, EventArgs e)
        {
            txtUSDAustralia.Text = 
                (Convert.ToDecimal(txtAmountAustralia.Text)
                * Convert.ToDecimal(txtRateAustralia.Text)
               ).ToString("0.00");
        }

        private void bhutanTextChanged(object sender, EventArgs e)
        {
            txtUSDBhutan.Text = 
                (Convert.ToDecimal(txtAmountBhutan.Text)
                * Convert.ToDecimal(txtRateBhutan.Text)
               ).ToString("0.00");
        }

        private void CRTextChanged(object sender, EventArgs e)
        {
            txtUSDCR.Text =
                (Convert.ToDecimal(txtAmountCR.Text)
                * Convert.ToDecimal(txtRateCR.Text)
               ).ToString("0.00");
        }

        private void europeTextChanged(object sender, EventArgs e)
        {
            txtUSDEurope.Text =
                (Convert.ToDecimal(txtAmountEurope.Text)
                * Convert.ToDecimal(txtRateEurope.Text)
               ).ToString("0.00");
        }

        private void usdTextChanged(object sender, EventArgs e)
        {
            txtTotalUSD.Text = (
                Convert.ToDecimal(txtUSDAustralia.Text) + Convert.ToDecimal(txtUSDBhutan.Text) +
                Convert.ToDecimal(txtUSDCR.Text) + Convert.ToDecimal(txtUSDEurope.Text)
                ).ToString("0.00");
        }
    }
    }
  
