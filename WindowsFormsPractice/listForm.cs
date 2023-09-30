using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace WindowsFormsPractice
{
    public partial class listForm : Form
    {
        static int ix = 0;

        public listForm()
        {
            InitializeComponent();
            String[] items = { "Mesa", "Coche","Libro","Maceta","Silla","Estanteria","Lampara","Rotuladores","Ventilador","Ordenador" };
            foreach (string i in items) { 
                lstItems.Items.Add(i);
            }
        }

        private void lstItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            Boolean selected = false;
            int index = lstItems.SelectedIndex;
            ix = index;
            if(lstItems.SelectedItem != null)
            {
                lblItemSelected.Text = lstItems.Items[index].ToString() + " is selected";
                selected = true;
            }

            if (!selected)
            {
                lblItemSelected.Text = "No elements selected";
            }

        }

        private void txtAddSearch_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void chkSort_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkShowInColums_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if(txtAddSearch.Text != "")
            {
                if (lstItems.Items.Contains(txtAddSearch.Text))
                {
                    MessageBox.Show("Item already included");
                }
                else
                {
                    lstItems.Items.Add(txtAddSearch.Text);
                    txtAddSearch.Clear();
                }
            }
        }

        private void btnAddFruit_Click(object sender, EventArgs e)
        {
            if(txtAddSearch.Text != "")
            {
                if (chklFruits.Items.Contains(txtAddSearch.Text))
                {
                    MessageBox.Show("Item already included");
                }
                else
                {
                    chklFruits.Items.Add(txtAddSearch.Text);
                    txtAddSearch.Clear();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            foreach (var item in lstItems.Items)
            {
                if (item.ToString().ToUpper() == txtAddSearch.Text.ToUpper())
                {
                    MessageBox.Show("Founded in Items list" + "\n" + txtAddSearch.Text);
                    lstItems.SelectedItem = item;
                }
            }
            foreach (var item in lstTransferedItems.Items)
            {
                if (item.ToString().ToUpper() == txtAddSearch.Text.ToUpper())
                {
                    MessageBox.Show("Founded in Transfered list" + "\n" + txtAddSearch.Text);
                    lstItems.SelectedItem = item;
                }
            }
        }

        private void rboSimple_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rboMultiple_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rboExtended_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void grpRadios_Enter(object sender, EventArgs e)
        {

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

        }

        private void btnDeselect_Click(object sender, EventArgs e)
        {
            lstItems.SelectedItem = null;

            for (int i = 0; i < chklFruits.Items.Count; i++)
            {
             chklFruits.SetItemChecked(i, false);
            }
        }

        private void btnTransferLR_Click(object sender, EventArgs e)
        {
            if(lstItems.SelectedIndex != -1) // One way to do it
            {
                lstTransferedItems.Items.Add(lstItems.SelectedItem);
                ix = lstItems.SelectedIndex;
                lstItems.Items.RemoveAt(ix);
            }
        }

        private void lstTransferedItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            Boolean selected = false;
            if (lstTransferedItems.SelectedItem != null)
            {
                lblItemSelected.Text = lstTransferedItems.Items[lstTransferedItems.SelectedIndex].ToString() + " is selected";
                selected = true;
            }

            if (!selected)
            {
                lblItemSelected.Text = "No elements selected";
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            lstTransferedItems.Items.Clear();
        }

        private void chklFruits_SelectedIndexChanged(object sender, EventArgs e)
        {
            Boolean selected = false;
            for (int i = 0; i < chklFruits.Items.Count; i++)
            {
                if (chklFruits.GetItemChecked(i))
                {
                    lblItemSelected.Text = chklFruits.Items[i].ToString() + " is selected";
                    selected = true;
                }

            }
            if (!selected)
            {
                lblItemSelected.Text = "No elements selected";
            }
        }

        private void btnTransferRL_Click(object sender, EventArgs e)
        {
           if (chklFruits.SelectedItem != null) // other way to do it
            {
                lstTransferedItems.Items.Add(chklFruits.SelectedItem);
                chklFruits.Items.Remove(chklFruits.SelectedItem);
            }

            
        }

        private void lblItemSelected_Click(object sender, EventArgs e)
        {

        }
    }
}
