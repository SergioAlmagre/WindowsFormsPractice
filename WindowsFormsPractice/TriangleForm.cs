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
            Boolean allSame = true;
            int sameSides = 0;
            int value;
            int index = 0;
            int[] sidesInt = new int[3];
            string[] sidesStr = new string[3];
            Image newImage;
            Boolean correct;

            sidesStr[0] = txtSideA.Text;
            sidesStr[1] = txtSideB.Text;
            sidesStr[2] = txtSideC.Text;

            for (int i = 0; i < sidesStr.Length; i++)
            {
                correct = int.TryParse(sidesStr[i], out value);
                if (correct)
                {
                    sidesInt[i] = value;
                    index++;
                }
                else
                {
                    switch (i)
                    {
                        case 0:
                            {
                                txtSideA.Text = "Date wrong";
                                newImage = Image.FromFile("../../../../Resources/question.jpg");
                                pictureBox1.Image = newImage;
                            }
                            break;
                        case 1:
                            {
                                txtSideB.Text = "Date wrong";
                                newImage = Image.FromFile("../../../../Resources/question.jpg");
                                pictureBox1.Image = newImage;
                            }
                            break;
                        case 2:
                            {
                                txtSideC.Text = "Date wrong";
                                newImage = Image.FromFile("../../../../Resources/question.jpg");
                                pictureBox1.Image = newImage;
                            }
                            break;
                    }
                }
            }
            if (index == 3)
            {
                for (int i = 0; i < sidesInt.Length; i++)
                {
                    if (i > 0)
                    {
                        if (sidesInt[i] != sidesInt[i - 1])
                        {
                            sameSides++;
                            allSame = false;
                        }
                    }
                }

                if (sameSides == 1)
                {
                    newImage = Image.FromFile("S:/My Drive/2ºDAM/3 - Interfaces Graficas/Tema 2/Proyectos/WindowsFormsPractice/Resources/isosceles.jpg");
                    pictureBox1.Image = newImage;
                    //MessageBox.Show("Isosceles");
                }
                if (sameSides == 2)
                {
                    newImage = Image.FromFile("../../../../Resources/escaleno.jpg");
                    pictureBox1.Image = newImage;
                    //MessageBox.Show("Escaleno");
                }
                if (allSame)
                {
                    newImage = Image.FromFile("../../../../Resources/equilatero.jpg");
                    pictureBox1.Image = newImage;
                    //MessageBox.Show("Todos son iguales"); 
                }
            }
        }

        private void txtSideA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
