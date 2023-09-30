using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPractice
{
    public partial class radiosChecksForm : Form
    {
        public radiosChecksForm()
        {
            InitializeComponent();
        }

        private void groupBoxColors_Enter(object sender, EventArgs e)
        {

        }

        private void rboRed_CheckedChanged(object sender, EventArgs e)
        {
            txtChecking.ForeColor = Color.Red;

        }

        private void rboGreen_CheckedChanged(object sender, EventArgs e)
        {
            txtChecking.ForeColor = Color.Green;
        }

        private void rboBlue_CheckedChanged(object sender, EventArgs e)
        {
            txtChecking.ForeColor = Color.Blue;
        }

        private void chkCenter_CheckedChanged(object sender, EventArgs e)
        {
            txtChecking.TextAlign = HorizontalAlignment.Center;
        }

        private void chkCapital_CheckedChanged(object sender, EventArgs e)
        {
            txtChecking.Text = txtChecking.Text.ToUpper();
        }

        private void groupBoxFormat_Enter(object sender, EventArgs e)
        {

        }

        private void txtChecking_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
