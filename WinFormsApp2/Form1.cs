namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbMessage.Text = string.Empty;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            lbMessage.Text = "Hello.... " + tbFirstName.Text + "  " + tbLastName.Text;
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            lbMessage.Text = string.Empty;
            tbFirstName.Text = string.Empty;    
            tbLastName.Text = string.Empty; 
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lbMessage.Text = "Male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lbMessage.Text = "Female";
        }

        private void btconcat_Click(object sender, EventArgs e)
        {
            String message = "You Have Selected ";
            if(cbcpp.Checked)
            {
                message = message + cbcpp.Text; 
            }
            if(cbJava.Checked)
            {
                message = message + cbJava.Text;
            }
            if(cbdotnet.Checked)
            {
                message = message + cbdotnet.Text;  
            }
            lbMessage.Text = message;   
        }

        private void cbcpp_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}