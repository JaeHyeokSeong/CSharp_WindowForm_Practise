namespace DialogPractise1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            // in form2, DialogResult property needs to be set as DialogResult.Yes to make following codes to work
            if(form2.ShowDialog() == DialogResult.Yes)
            {
                MessageBox.Show("Form2 successfully closed");
            }
            else
            {
                MessageBox.Show("Form2 not successfully closed");
            }
            MessageBox.Show(form2.Result.ToString()); // show form2 values in the form1
            form2.Dispose();
        }
    }
}