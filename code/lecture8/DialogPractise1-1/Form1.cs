namespace DialogPractise1_1
{
    public partial class Form1 : Form
    {
        public string message = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // method1
            /*Form2 form2 = new Form2();
            form2.ReceivedData = textBox1.Text;
            this.Hide();
            form2.ShowDialog();
            this.Show();*/

            // method2
            message = textBox1.Text;
            Form2 form2 = new Form2();
            form2.Owner = this;
            form2.ShowDialog();
        }
    }
}