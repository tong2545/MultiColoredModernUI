using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiColoredModernUI.Forms
{
    public partial class FormOrders : Form
    {
        public static double due = 0, change;
        public FormOrders()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormOrders_Load(object sender, EventArgs e)
        {

        }

        private void slipRtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            slipRtbx1.Text = slipRtbx1.Text + " \nJeans\t\t1200 ฿ ";
            due = due + 1200;
            dueLb1.Text = due.ToString();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            slipRtbx1.Text = slipRtbx1.Text + " \nกางเกงขิโน่\t600 ฿ ";
            due = due + 600;
            dueLb1.Text = due.ToString();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            slipRtbx1.Text = slipRtbx1.Text + " \nกางเกงผ้าcutton\t400 ฿ ";
            due = due + 400;
            dueLb1.Text = due.ToString();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            slipRtbx1.Text = slipRtbx1.Text + " \nกางเกงยืดขายาว\t700 ฿ ";
            due = due + 700;
            dueLb1.Text = due.ToString();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            slipRtbx1.Text = slipRtbx1.Text + " \nกางเกงขาสั้น\t750 ฿ ";
            due = due + 750;
            dueLb1.Text = due.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            change = 0;
            due = 0;
            slipRtbx1.Text = " ";
            dueLb1.Text = " ";
            cashTbx.Text = " ";
            changeLb1.Text = " ";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            slipRtbx1.Text = slipRtbx1.Text + " \nกางเกงขากว้าง\t790 ฿ ";
            due = due + 790;
            dueLb1.Text = due.ToString();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            double cash = Convert.ToDouble(cashTbx.Text);
            change = cash - due;

            if (change < 0)
                MessageBox.Show("Not Enough Cash");

            changeLb1.Text = change.ToString() + "฿";

        }
    }
}
