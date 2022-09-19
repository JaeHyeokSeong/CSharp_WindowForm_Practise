using System.Diagnostics;

namespace CommonDialogs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Reference: https://learn.microsoft.com/en-us/dotnet/desktop/winforms/controls/how-to-open-files-using-the-openfiledialog-component?view=netframeworkdesktop-4.8

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                using (Stream str = openFileDialog1.OpenFile())
                {
                    Process.Start("notepad.exe", fileName).Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Reference: https://dailycoding-diary.tistory.com/35
                /*string str = saveFileDialog1.FileName;
                StreamWriter sw = new StreamWriter(str, false, System.Text.Encoding.Default);
                sw.Write(richTextBox1.Text);
                sw.Flush();
                sw.Close();*/
                FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(richTextBox1.Text);
                sw.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // this buttion opens the form2
            Form2 form2 = new Form2();
            form2.ShowDialog(); // Modal dialog
            form2.Dispose(); // optional for using a Dispose(), but in order to make a strong program
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}