using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_2_prowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://google.com");
            guna2TextBox1.Focus();
        }

        private void guna2TextBox1_Validating(object sender, CancelEventArgs e)
        {//string.IsNullOrWhiteSpace(guna2TextBox1.Text)
            if(guna2TextBox1.Text== "http ://")
            {
                e.Cancel = true;
                guna2TextBox1.Focus();
                errorProvider1.SetError(guna2TextBox1,"should have avalue");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(guna2TextBox1, "");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(guna2TextBox1.Text))
            {
                webBrowser1.Navigate(guna2TextBox1.Text);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
