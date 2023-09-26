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
    public partial class TriangleForm : Form
    {
        public TriangleForm()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int same;
            int value;
            int[] sidesInt = new int[3];
            string[] sidesStr = new string[3];

            Boolean correct = false;
            int index = 0;

            sidesStr[0] = txtSideA.Text;
            sidesStr[1] = txtSideB.Text;
            sidesStr[2] = txtSideC.Text;
          
            for (int i= 0; i<sidesStr.Length;i++)
            {
                correct = int.TryParse(sidesStr[i], out value);
                if (correct)
                {
                    sidesInt[index] = value;
                }
                else
                {
                    switch (i)
                    {
                        case 0:
                        {
                            txtSideA.Text = "Date wrong";
                        }
                        break;
                        case 1:
                        {
                            txtSideB.Text = "Date wrong";
                        }
                        break;
                        case 2:
                        {
                            txtSideC.Text = "Date wrong";
                        }
                        break;
                    }
                    //DialogResult rs = MessageBox.Show("Some value wrong");
                }

            }
            
                



        }
    }
}
