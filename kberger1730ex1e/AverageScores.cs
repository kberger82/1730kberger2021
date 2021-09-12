using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kberger1730ex1e
{
    public partial class AverageScores : Form
    {
        public AverageScores()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtAvgScore.Text = (
                (Convert.ToDecimal(txtScore1.Text) + Convert.ToDecimal(txtScore2.Text) + Convert.ToDecimal(txtScore3.Text))
                / 3m
                ).ToString("0.00");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtScore1.Text = "0";
            txtScore2.Text = "0";
            txtScore3.Text = "0";
            txtAvgScore.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
