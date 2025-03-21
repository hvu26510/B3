using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B3P2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a = 0, b = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            Ran();
        }

        public void Ran()
        {
            Random rd = new Random();
            a = rd.Next(1,10);
            b = rd.Next(1, 10);
            txtA.Text = a.ToString();
            txtB.Text = b.ToString();
            txtKQ.Text = "";
            progressBar1.Value = 0;
            timer1.Start();
        }

        private void btnTraLoi_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            check();
            Ran();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 1000;
            if (progressBar1.Value >= 10000) 
            {
                timer1.Stop();
                MessageBox.Show("Da het thoi gian");
            }
        }

        public void check()
        {
            int kq = int.Parse(txtKQ.Text);
            if (kq == a * b)
            {
                MessageBox.Show("Dap an chinh xac");
            }
            else
            {
                MessageBox.Show("Dap an KHONG chinh xac");
            }
        }
    }
}
