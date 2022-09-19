using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogPractise1_1
{
    public partial class Form2 : Form
    {
        private string receivedData = "";
        public string ReceivedData
        {
            set { receivedData = value; }
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // textBox1.Text = receivedData;
            Form1 form1 = (Form1)Owner;
            textBox1.Text = form1.message;
        }
    }
}
