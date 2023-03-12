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
    public partial class FormProduct : Form
    {
        public static double due = 0, change;
        public FormProduct()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            slipRtbx.Text = slipRtbx.Text + " \nCeline\t\t2000 ฿ ";
            due = due + 2000;
            dueLb1.Text = due.ToString(); 
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            slipRtbx.Text = slipRtbx.Text + " \nเสื้อยืดธรรมดา\t300 ฿ ";
            due = due + 300;
            dueLb1.Text = due.ToString();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            slipRtbx.Text = slipRtbx.Text + " \nเสื้อ Hoodie\t500 ฿ ";
            due = due + 500;
            dueLb1.Text = due.ToString();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            slipRtbx.Text = slipRtbx.Text + " \nเสื้อแขนยาว\t350 ฿ ";
            due = due + 350;
            dueLb1.Text = due.ToString();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            slipRtbx.Text = slipRtbx.Text + " \nเสื้อแขนยาวมีปก\t400 ฿ ";
            due = due + 400;
            dueLb1.Text = due.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
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
            slipRtbx.Text = " ";
            dueLb1.Text = " ";
            cashTbx.Text = " ";
            changeLb1.Text = " ";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void FormProduct_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            slipRtbx.Text = slipRtbx.Text + " \nHoodies Street\t600 ฿ ";
            due = due + 600;
            dueLb1.Text = due.ToString();
        }
    }
}
