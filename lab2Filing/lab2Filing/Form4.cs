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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.Text = "File Copy";
            this.label1.Text = "File Address";
            this.label2.Text = "File Name";
            this.label3.Text = "Destination" + Environment.NewLine + "Address";
            this.label4.Text = "Destination" + Environment.NewLine + "Name";
            this.button1.Text = "Copy";
            this.button2.Text = "Clear";
            this.button3.Text = "Cancel";
            this.textBox4.ReadOnly = true;
            this.button4.Text = "Change Destination File Name";
            this.button4.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text + textBox2.Text;
            string d = textBox3.Text + textBox4.Text;
            if (File.Exists(d))
            {
                DialogResult dr = MessageBox.Show("Do you want to replace file?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    File.Delete(d);
                    File.Copy(s, d);
                    MessageBox.Show("File Copied");
                }
                if (dr == DialogResult.No)
                {
                    MessageBox.Show("File Not Copy");
                }
            }
            else
            {
                if (File.Exists(s))
                {
                    File.Copy(s, d);
                    MessageBox.Show("File Copied");
                }
                else
                {
                    MessageBox.Show("File Not Exits");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
            this.textBox2.Clear();
            this.textBox3.Clear();
            this.textBox4.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.Show();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.textBox4.Text = this.textBox2.Text;
            if (this.textBox2.Text == "")
            {
                this.button4.Enabled = false;
            }
            else
            {
                this.button4.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.textBox4.ReadOnly = false;
        }
    }
}
