namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbMessage.Text= string.Empty;
        }

        private void btSubmitt_Click(object sender, EventArgs e)
        {
            string msg = "Hello....";
            msg = msg + tbFirstName.Text + " " + tbLastName.Text;
            lbMessage.Text = msg;
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            tbFirstName.Text = string.Empty;    
            tbLastName.Text = string.Empty;
            lbMessage.Text = string.Empty;
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            lbMessage.Text = "Male";
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            lbMessage.Text = "Female";
        }

        private void btSubject_Click(object sender, EventArgs e)
        {
            string msg = "You have selected ";
            if (cbCPP.Checked)
                msg = msg + cbCPP.Text;
            if (cbJava.Checked)
                msg = msg + cbJava.Text;
            if (cbDotnet.Checked)
                msg = msg + cbDotnet.Text;
            lbMessage.Text = msg;
        }

        private void cbCPP_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}