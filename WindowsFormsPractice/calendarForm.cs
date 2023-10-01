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
    public partial class calendarForm : Form
    {
        public calendarForm()
        {
            InitializeComponent();
            rboLong.Checked = true;
        }

        private void mcal_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (rboLong.Checked)
            {
                this.txtDate.Text = this.mcal.SelectionStart.ToLongDateString();

            }
            else
            {
                this.txtDate.Text = this.mcal.SelectionStart.ToShortDateString();
            }
            dtp.Value = mcal.SelectionStart; //pay attention about the different methods to selected the date between MonthCalendar and DateTimePicker

        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            if (rboLong.Checked)
            {
                this.txtDate.Text = this.mcal.SelectionStart.ToLongDateString();
            }
            else
            {
                this.txtDate.Text = this.mcal.SelectionStart.ToShortDateString();
            }
            mcal.SetDate(dtp.Value);//pay attention about the different methods to selected the date between MonthCalendar and DateTimePicker
        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void rboShort_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rboLong_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
