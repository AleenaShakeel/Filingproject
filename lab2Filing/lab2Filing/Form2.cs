using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lab2Filing
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = "File Exist";
            this.label1.Text = "File Address";
            this.label2.Text = "File Name";
            this.button1.Text = "Exist";
            this.button2.Text = "Clear";
            this.button3.Text = "Cancel";
            this.textBox1.Text="C:\\folder_name";
            this.textBox2.Text = "File_name.txt";
            this.label3.Text = "Extensions";
            string[] ext = { ".txt", ".png", ".zip", ".docx" };
            this.comboBox1.Items.AddRange(ext);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text + textBox2.Text + this.comboBox1.Text;
            if (File.Exists(s))
            {
                MessageBox.Show("Your File Exits");
            }
            else
            {
                MessageBox.Show("File Not Found");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
            this.textBox2.Clear();
            this.comboBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.Show();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            this.textBox2.Clear();
        }
    }
}
