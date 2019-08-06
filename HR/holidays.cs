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
    public partial class holidays : Form
    {
        public holidays()
        {
            InitializeComponent();
        }

        private void holidays_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'hRDataSet.holiday_type' table. You can move, or remove it, as needed.
                this.holiday_typeTableAdapter.Fill(this.hRDataSet.holiday_type);
                // TODO: This line of code loads data into the 'hRDataSet.employees' table. You can move, or remove it, as needed.
                this.employeesTableAdapter.Fill(this.hRDataSet.employees);
                // TODO: This line of code loads data into the 'hRDataSet.holidays_View' table. You can move, or remove it, as needed.
                this.holidays_ViewTableAdapter.Fill(this.hRDataSet.holidays_View);

            }
            catch (Exception)
            {

            }
           
        }

        void clearall()
        {
            try
            {
                employee_list.SelectedIndex = -1;
                holiday_type_list.SelectedIndex = -1;
                day_amount_txt.Value = 1;
                date_txt.Text = "";
                comment_txt.Text = "";

                // TODO: This line of code loads data into the 'hRDataSet.holiday_type' table. You can move, or remove it, as needed.
                this.holiday_typeTableAdapter.Fill(this.hRDataSet.holiday_type);
                // TODO: This line of code loads data into the 'hRDataSet.employees' table. You can move, or remove it, as needed.
                this.employeesTableAdapter.Fill(this.hRDataSet.employees);
                // TODO: This line of code loads data into the 'hRDataSet.holidays_View' table. You can move, or remove it, as needed.
                this.holidays_ViewTableAdapter.Fill(this.hRDataSet.holidays_View);

                this.ActiveControl = employee_list;
            }
            catch (Exception)
            {
            }
            
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            clearall();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                home home = new home();
                home.Show();
                this.Hide();
            }
            catch (Exception)
            {
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (employee_list.SelectedIndex != -1)
                {
                    int v = -1;
                    if (this.holiday_typeTableAdapter.payed_or_not((int)holiday_type_list.SelectedValue) == true)
                    {
                        v = 1;
                    }

                    DateTime date = DateTime.Parse(date_txt.Text);

                    this.holidaysTableAdapter.Insert(int.Parse(LoginInfo.employer_id), (int)employee_list.SelectedValue, (int)holiday_type_list.SelectedValue, (int)day_amount_txt.Value * v, date.Date, comment_txt.Text);

                    clearall();
                }
                else
                {
                    MessageBox.Show("أختر اسم الموظف أولا", "تسجيل المصروفات و الخصومات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
            }
            
        }

        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'hRDataSet.holidays_View' table. You can move, or remove it, as needed.
                this.holidays_ViewTableAdapter.search(this.hRDataSet.holidays_View, search_txt.Text);
            }
            catch (Exception)
            {
            }

        }

        
    }
}
