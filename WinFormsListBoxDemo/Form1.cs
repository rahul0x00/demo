namespace WinFormsListBoxDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btRight_Click(object sender, EventArgs e)
        {
            if(lbLeft.SelectedIndex != -1)
            {
                lbRight.Items.Add(lbLeft.SelectedItem);
                lbLeft.Items.Remove(lbLeft.SelectedItem);
            }
        }

        private void btLeft_Click(object sender, EventArgs e)
        {
            if(lbRight.SelectedIndex != -1)
            {
                lbLeft.Items.Add(lbRight.SelectedItem); 
                lbRight.Items.Remove(lbRight.SelectedItem); 
            }
        }
    }
}