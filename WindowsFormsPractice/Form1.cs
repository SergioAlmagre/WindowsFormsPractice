using System.Runtime.Versioning;

namespace WindowsFormsPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTextBox_Click(object sender, EventArgs e)
        {
            /**CLOSE ALL WINDOWS         
                        
            **/

            if (this.MdiChildren.Length > 0)
            {
                if (this.MdiChildren[0].Name != "TextBox")
                {
                    DialogResult rs = MessageBox.Show("¿Do you wish open other windows?, You will lose your data", "Atention!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        this.MdiChildren[0].Close();
                        TextBox frmTexbox = new TextBox();
                        frmTexbox.MdiParent = this;
                        frmTexbox.Dock = DockStyle.Fill;
                        frmTexbox.Show();
                    }
                }
            }
            else
            {
                lblWelcome.Hide();
                TextBox frmTexbox = new TextBox();
                frmTexbox.MdiParent = this;
                frmTexbox.Dock = DockStyle.Fill;
                frmTexbox.Show();
            }

        }



        private void btnTtriangle_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (this.MdiChildren[0].Name != "TriangleForm")
                {
                    DialogResult rs = MessageBox.Show("¿Do you wish open other windows?, You will lose your data", "Atention!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        this.MdiChildren[0].Close();
                        TriangleForm frmTriangle = new TriangleForm();
                        frmTriangle.MdiParent = this;
                        frmTriangle.Dock = DockStyle.Fill;
                        frmTriangle.Show();
                    }
                }
            }
            else
            {
                lblWelcome.Hide();
                TriangleForm frmTriangle = new TriangleForm();
                frmTriangle.MdiParent = this;
                frmTriangle.Dock = DockStyle.Fill;
                frmTriangle.Show();
            }
        }

        private void btnColors_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (this.MdiChildren[0].Name != "colorsForm")
                {
                    DialogResult rs = MessageBox.Show("¿Do you wish open other windows?, You will lose your data", "Atention!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        this.MdiChildren[0].Close();
                        lblWelcome.Hide();
                        colorsForm frmColors = new colorsForm();
                        frmColors.MdiParent = this;
                        frmColors.Dock = DockStyle.Fill;
                        frmColors.Show();
                    }
                }
            }
            else
            {
                lblWelcome.Hide();
                colorsForm frmColors = new colorsForm();
                frmColors.MdiParent = this;
                frmColors.Dock = DockStyle.Fill;
                frmColors.Show();
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {

        }

        private void btnBoxes_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (this.MdiChildren[0].Name != "radioChecksForm")
                {
                    DialogResult rs = MessageBox.Show("¿Do you wish open other windows?, You will lose your data", "Atention!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        this.MdiChildren[0].Close();
                        lblWelcome.Hide();
                        radiosChecksForm frmRadios = new radiosChecksForm();
                        frmRadios.MdiParent = this;
                        frmRadios.Dock = DockStyle.Fill;
                        frmRadios.Show();
                    }
                }
            }
            else
            {
                lblWelcome.Hide();
                radiosChecksForm frmRadios = new radiosChecksForm();
                frmRadios.MdiParent = this;
                frmRadios.Dock = DockStyle.Fill;
                frmRadios.Show();
            }




        }

        private void btnComboBox_Click(object sender, EventArgs e)
        {

        }

        private void btnCalendars_Click(object sender, EventArgs e)
        {

        }

        private void btnTimer_Click(object sender, EventArgs e)
        {

        }

        private void btnColorRange_Click(object sender, EventArgs e)
        {

        }

        private void btnImagesList_Click(object sender, EventArgs e)
        {

        }

    }


}