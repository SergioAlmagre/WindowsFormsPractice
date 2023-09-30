using System;
using System.Collections;
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
    public partial class comboBoxForm : Form
    {


        public comboBoxForm()
        {
            InitializeComponent();
            String[] colores = { "Rojo", "Azul", "Naranja", "Amarillo" };
            foreach (String i in colores)
            {
                cboDropDownStyle.Items.Add(i);
            }
            foreach (var item in cboDropDownStyle.Items)
            {
                cboList.Items.Add(item);
                cboSimple.Items.Add(item);
            }

        }

        private void txtAddColor_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboDropDownStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtLastChoosed.Text = cboDropDownStyle.SelectedItem.ToString();
        }

        private void cboList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboSimple_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtLastChoosed_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddColor_Click(object sender, EventArgs e)
        {
            cboDropDownStyle.MaxDropDownItems = 30;
            cboList.MaxDropDownItems = 30;


            if (cboDropDownStyle.Items.Contains(txtAddColor.Text))
            {
                txtAddColor.Text = "Color alreday included";
            }
            else if (txtAddColor.Text == "")
            {
                txtAddColor.Text = "Write here a new color";
            }
            else
            {
                if (txtAddColor.Text != "Color alreday included")
                {
                    if (txtAddColor.Text != "Write here a new color")
                    {
                        cboDropDownStyle.Items.Add(txtAddColor.Text);
                        cboSimple.Items.Add(txtAddColor.Text);
                        cboList.Items.Add(txtAddColor.Text);
                        cboDropDownStyle.Text = txtAddColor.Text.ToString() + " added";
                        txtAddColor.Clear();
                    }
                }
            }

        }

        private void comboBoxForm_Load(object sender, EventArgs e)
        {

        }
    }
}
