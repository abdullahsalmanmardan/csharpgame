using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool flag=false;
        bool timerfirst = false;
        bool timersecond = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            pictureBox1.Visible = false;
        }
        // action clicekd
        private void label1_Click(object sender, EventArgs e)
        {
            flag=!flag;
            if(flag)
            {
                panel2.Visible=true;
            }
            else
            {
                panel2.Visible=false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = "Stop";
            label3.ForeColor = Color.Red;

            label4.Text = "Go";
            label4.ForeColor= Color.Green;
            timer2_Tick(sender, e);
        }
        // start clicked
        private void label2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            timer1_Tick(sender, e);

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }
    }
}
