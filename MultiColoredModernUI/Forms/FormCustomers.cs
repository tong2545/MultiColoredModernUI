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
    public partial class FormCustomers : Form
    {
        public static double due = 0, change;
        public FormCustomers()
        {
            InitializeComponent();
        }

        private void slipRtbx1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            slipRtbx1.Text = slipRtbx1.Text + " \nแตะหุ้มส้นadidas\t1300 ฿ ";
            due = due + 1300;
            dueLb1.Text = due.ToString();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            slipRtbx1.Text = slipRtbx1.Text + " \nadidas5\t\t2500 ฿ ";
            due = due + 2500;
            dueLb1.Text = due.ToString();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            slipRtbx1.Text = slipRtbx1.Text + " \nadidas4\t\t3000 ฿ ";
            due = due + 3000;
            dueLb1.Text = due.ToString();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            slipRtbx1.Text = slipRtbx1.Text + " \nadidas3\t\t2700 ฿ ";
            due = due + 2700;
            dueLb1.Text = due.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            slipRtbx1.Text = slipRtbx1.Text + " \nแตะadidas\t\t800 ฿ ";
            due = due + 800;
            dueLb1.Text = due.ToString();
        }

        private void payBtn_Click(object sender, EventArgs e)
        {
            double cash = Convert.ToDouble(cashTbx.Text);
            change = cash - due;

            if (change < 0)
                MessageBox.Show("Not Enough Cash");

            changeLb1.Text = change.ToString() + "฿";
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            slipRtbx1.Text = slipRtbx1.Text + " \nadidas1\t\t1590 ฿ ";
            due = due + 1590;
            dueLb1.Text = due.ToString();
        }
    }
}
