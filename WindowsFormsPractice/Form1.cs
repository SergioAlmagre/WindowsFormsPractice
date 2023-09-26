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
            if (this.MdiChildren.Length > 0)
            {
                if (MdiChildren[0].Name != "TexBox")
                {
                    DialogResult rs = MessageBox.Show("¿Do you wish open again the same windows?, You will lose your data", "Atention!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        // Problem: Windows are overlapping
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
            if (this.MdiChildren.Length> 0)
            {
                if (MdiChildren[0].Name != "TriangleFrom")
                {
                    DialogResult rs = MessageBox.Show("¿Do you wish open again the same windows?, You will lose your data", "Atention!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
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

        }

        private void btnList_Click(object sender, EventArgs e)
        {

        }

        private void btnBoxes_Click(object sender, EventArgs e)
        {

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