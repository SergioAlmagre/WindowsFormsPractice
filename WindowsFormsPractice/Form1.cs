namespace WindowsFormsPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox frmTexbox = new TextBox();
            frmTexbox.MdiParent = this;
            frmTexbox.Dock = DockStyle.Fill;
            frmTexbox.Show();
        }
    }
}