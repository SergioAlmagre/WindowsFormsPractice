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
            lblWelcome.Hide();
            TextBox frmTexbox = new TextBox();
            frmTexbox.MdiParent = this;
            frmTexbox.Dock = DockStyle.Fill;
            frmTexbox.Show();
        }

        private void btnTtriangle_Click(object sender, EventArgs e)
        {

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