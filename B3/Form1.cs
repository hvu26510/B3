using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1Lv3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DateTime.Now.ToString());
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtLink.Text);
        }

        private void txtLink_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                webView.Source = new System.Uri(txtLink.Text);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtTimer.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
