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
    public partial class colorRangeForm : Form
    {
        int red = 0;
        int green = 0;
        int blue = 0;
        
        public colorRangeForm()
        {
            InitializeComponent();
            panelColor.BackColor = Color.FromArgb(red, green, blue);
        }

        private void dudRed_SelectedItemChanged(object sender, EventArgs e)
        {
            if (dudRed.Text != "")
            {
                if (int.TryParse(dudRed.Text, out red))
                {
                    if (red < 0 || red > 255)
                    {
                        red = 127;
                    }
                    else
                    {
                        panelColor.BackColor = Color.FromArgb(red, green, blue);
                        trbRed.Value = red;
                    }
                }
                else
                {
                    MessageBox.Show("Input not valid", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    

        private void trbRed_Scroll(object sender, EventArgs e)
        {
            red = trbRed.Value;
            panelColor.BackColor = Color.FromArgb(red, green, blue);
            dudRed.Text = red.ToString();
            trbRed.Value = red;
        }

        private void dudGreen_SelectedItemChanged(object sender, EventArgs e)
        {
            if (dudGreen.Text != "")
            {
                if (int.TryParse(dudGreen.Text, out green))
                {
                    if (green < 0 || green > 255)
                    {
                        green = 127;
                    }
                    else
                    {
                        panelColor.BackColor = Color.FromArgb(red, green, blue);
                        trbGreen.Value = green;
                    }
                }
                else
                {
                    MessageBox.Show("Input not valid", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    

        private void trbGreen_Scroll(object sender, EventArgs e)
        {
            green = trbGreen.Value;
            panelColor.BackColor = Color.FromArgb(red, green, blue);
            dudGreen.Text = green.ToString();
            trbGreen.Value = green;
        }

        private void dudBlue_SelectedItemChanged(object sender, EventArgs e)
        {
            if (dudBlue.Text != "")
            {
                if(int.TryParse(dudBlue.Text, out blue))
                {
                    if (blue < 0 || blue > 255)
                    {
                        blue = 127;
                    }
                    else
                    {
                        panelColor.BackColor = Color.FromArgb(red, green, blue);
                        trbBlue.Value = blue;
                    }
                }
                else
                {
                    MessageBox.Show("Input not valid","Attention!", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void trbBlue_Scroll(object sender, EventArgs e)
        {
            blue = trbBlue.Value;
            panelColor.BackColor = Color.FromArgb(red, green, blue);
            dudBlue.Text = blue.ToString();
            trbBlue.Value = blue;
        }

        private void panelColor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
