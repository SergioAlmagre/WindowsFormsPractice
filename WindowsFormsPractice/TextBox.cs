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
    public partial class TextBox : Form
    {
        public TextBox()
        {
            InitializeComponent();
        }

        private void btnNextFocus_Click(object sender, EventArgs e)
        {
            txtMusic.Focus();
        }

        private void btnWriter_Click(object sender, EventArgs e)
        {
            FormTxtBox newFormTxt = new FormTxtBox(txtMusic.Text, txtName.Text, txtSecondName.Text, txtPassword.Text);
            InterWindow.formTxtBoxSingle = newFormTxt;
            if (txtName.ReadOnly == true)
            {
                txtName.ReadOnly = false;
            }
            else
            {
                txtName.ReadOnly = true;
            }
            
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            if (txtSecondName.Enabled == true)
            {
                txtSecondName.Enabled = false;
            }
            else
            {
                txtSecondName.Enabled = true;
            }
            
        }

        private void btnMakeVisible_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = '\0';

            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }
    }
}
