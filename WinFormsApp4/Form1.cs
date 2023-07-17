namespace WinFormsApp4
{
    
    public partial class Form1 : Form
        {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            frm2.MdiParent = this;
        }

        private void resultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            frm3.MdiParent = this;
        }
    }

    partial class Form2 : Form
    {
        public Form2()
        {

        }
    }

    partial class Form3 : Form
    {
        public Form3()
        {

        }
    }
}