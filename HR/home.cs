using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pictureBox3.Width == 0)
            {
                pictureBox3.Width = this.Width;
                pictureBox3.Height = this.Height - 110;
            }
            else
            {
                pictureBox3.Width = 0;
                pictureBox3.Height = 0;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                login ll = new login();
                ll.Show();
                this.Hide();
            }
            catch (Exception)
            {

            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            try
            {
                attendance ll = new attendance();
                ll.Show();
                this.Hide();
            }
            catch (Exception)
            {

            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            try
            {
                users ll = new users();
                ll.Show();
                this.Hide();
            }
            catch (Exception)
            {

            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            try
            {
                statistics ll = new statistics();
                ll.Show();
                this.Hide();
            }
            catch (Exception)
            {

            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            try
            {
                payment ll = new payment();
                ll.Show();
                this.Hide();
            }
            catch (Exception)
            {

            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            try
            {
                status ll = new status();
                ll.Show();
                this.Hide();
            }
            catch (Exception)
            {

            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            try
            {
                rules ll = new rules();
                ll.Show();
                this.Hide();
            }
            catch (Exception)
            {

            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            try
            {
                employees ll = new employees();
                ll.Show();
                this.Hide();
            }
            catch (Exception)
            {

            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            try
            {
                departments ll = new departments();
                ll.Show();
                this.Hide();
            }
            catch (Exception)
            {

            }
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            try
            {
                endday ll = new endday();
                ll.Show();
                this.Hide();
            }
            catch (Exception)
            {

            }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            try
            {
                deductions ll = new deductions();
                ll.Show();
                this.Hide();
            }
            catch (Exception)
            {

            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            try
            {
                holidays ll = new holidays();
                ll.Show();
                this.Hide();
            }
            catch (Exception)
            {

            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            try
            {
                payment_type ll = new payment_type();
                ll.Show();
                this.Hide();
            }
            catch (Exception)
            {

            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            try
            {
                holiday_types ll = new holiday_types();
                ll.Show();
                this.Hide();
            }
            catch (Exception)
            {

            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            try
            {
                deductions_types ll = new deductions_types();
                ll.Show();
                this.Hide();
            }
            catch (Exception)
            {

            }
        }
    }
}
