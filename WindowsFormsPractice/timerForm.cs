using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPractice
{
    public partial class timerForm : Form
    {
        private int seconds = 0;
        private int miliseconds = 0;
        public timerForm()
        {

            InitializeComponent();
            timer1.Tick += new EventHandler(timer1_Tick);
            btnStop.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e) // this mother fucker is from chatGPT
        {
            miliseconds += timer1.Interval;

            if (miliseconds >= 1000)
            {
                seconds++;
                miliseconds -= 1000; // Restar 1000 para mantener los milisegundos en el rango 0-999
            }
            string milisecondsFormated = (miliseconds / 10).ToString("00");

            lblTimer.Text = $"{seconds:00}:{milisecondsFormated}";

            if (seconds == nudTime.Value)
            {
                txtBoxDown.Text = txtBoxUp.Text;
                txtBoxUp.Text = "";
                timer1.Stop();
                btnRestart.Enabled = true;
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxUp_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxDown_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (nudTime.Value > 0 && txtBoxUp.Text != "")
            {
                timer1.Start();
                txtBoxUp.Enabled = false;
                btnStart.Hide();
                btnStop.Show();
                btnRestart.Enabled = false;
            }
            else
            {
                MessageBox.Show("Select valid time or write something in the up box", "Atention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void nudTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblTimer_Click(object sender, EventArgs e)
        {

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            txtBoxUp.Enabled = true;
            btnStop.Hide();
            btnStart.Show();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            btnStart.Show();
            btnStop.Hide();
            nudTime.Value = 0;
            txtBoxDown.Text = "";
            txtBoxUp.Enabled = true;
            seconds = 0;
            lblTimer.Text = "00:00";
        }
    }
}
