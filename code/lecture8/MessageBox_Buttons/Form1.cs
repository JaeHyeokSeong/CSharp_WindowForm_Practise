namespace MessageBox_Buttons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("This Message Box has OK and Cancel button", "Demo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if(dialogResult == DialogResult.OK)
            {
                MessageBox.Show("OK button clicked");
            }
            else if(dialogResult == DialogResult.Cancel)
            {
                MessageBox.Show("Cancel button clicked");
            }
        }
    }
}