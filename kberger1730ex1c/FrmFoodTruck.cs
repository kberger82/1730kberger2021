using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kberger1730ex1c
{
    public partial class FrmFoodTruck : Form
    {
        private const string V = "";

        public FrmFoodTruck()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtHotDogsSubtotal.Text = (
                4.0m * Convert.ToDecimal(txtHotDogs.Text)
                ).ToString("0.00");
            
            txtHamburgersSubtotal.Text = (
                5.0m * Convert.ToDecimal(txtHamburgers.Text)
                ).ToString("0.00");
           
            txtPretaxTotal.Text = 
                (Convert.ToDecimal(txtHotDogsSubtotal.Text)
                + Convert.ToDecimal(txtHamburgersSubtotal.Text)
                ).ToString("0.00");

            txtTax.Text = (
                .06875m * Convert.ToDecimal(txtPretaxTotal.Text)
                ).ToString("0.00");

            txtTotal.Text =
                (Convert.ToDecimal(txtHotDogsSubtotal.Text)
                + Convert.ToDecimal(txtHamburgersSubtotal.Text)
                ).ToString();

            txtTotal.Text =
                (Convert.ToDecimal(txtPretaxTotal.Text)
                + Convert.ToDecimal(txtTax.Text)
                ).ToString();

            btnClear.Focus();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHotDogs.Text = "0";
            txtHamburgers.Text = "0";
            txtHotDogsSubtotal.Text = "";
            txtHamburgersSubtotal.Text = "";
            txtPretaxTotal.Text = "";
            txtTax.Text = "";
            txtTotal.Text = "";

            txtHotDogs.Focus();

        }
    }
}
