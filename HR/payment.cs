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
    public partial class payment : Form
    {
        public payment()
        {
            InitializeComponent();
        }

        private void clearall()
        {
            try
            {
                employee_list.SelectedIndex = -1;
                payment_type_list.SelectedIndex = -1;
                amount_txt.Value = 0;
                date_txt.Text = "";
                comment_txt.Text = "";

                // TODO: This line of code loads data into the 'hRDataSet.payment_View' table. You can move, or remove it, as needed.
                this.payment_ViewTableAdapter.Fill(this.hRDataSet.payment_View);
                // TODO: This line of code loads data into the 'hRDataSet.payment_type' table. You can move, or remove it, as needed.
                this.payment_typeTableAdapter.Fill(this.hRDataSet.payment_type);
                // TODO: This line of code loads data into the 'hRDataSet.employees' table. You can move, or remove it, as needed.
                this.employeesTableAdapter.FillBy_active(this.hRDataSet.employees);

                this.ActiveControl = employee_list;
            }
            catch (Exception)
            {
            }
            
        }

        private void payment_Load(object sender, EventArgs e)
        {

            clearall();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            clearall();
        }

        private void payment_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (this.WindowState == FormWindowState.Maximized)
                {
                    this.WindowState = FormWindowState.Normal;
                }
                else
                {
                    this.WindowState = FormWindowState.Maximized;
                }
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
                    int v = 1;
                    if (this.payment_typeTableAdapter.negative_or_not((int)payment_type_list.SelectedValue) == true)
                    {
                        v = -1;
                    }

                    DateTime current = DateTime.Parse(date_txt.Text);

                    this.paymentTableAdapter.Insert(int.Parse(LoginInfo.employer_id), (int)employee_list.SelectedValue, (int)payment_type_list.SelectedValue, DateTime.Now, current.Date, v * amount_txt.Value, comment_txt.Text);

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

                // TODO: This line of code loads data into the 'hRDataSet.payment_View' table. You can move, or remove it, as needed.
                this.payment_ViewTableAdapter.search(this.hRDataSet.payment_View, search_txt.Text);
            }
            catch (Exception)
            {
            }

        }

        private void employee_list_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (employee_list.SelectedIndex != -1)
                {
                    DataTable dt = this.employees_deduction_ViewTableAdapter.GetDataBy_emp_id((int)employee_list.SelectedValue);
                    DataTable empl = this.employeesTableAdapter.Get_search_by_id((int)employee_list.SelectedValue);

                    decimal final_deduction = 0;
                    decimal salary = decimal.Parse(empl.Rows[0][7].ToString());

                    foreach (DataRow item in dt.Rows)
                    {
                        string deduction_amount = item[5].ToString();
                        decimal deduction = 0;

                        if (deduction_amount.Contains("%"))
                        {
                            deduction = salary * (Convert.ToDecimal(deduction_amount.Replace("%", "")) / 100);
                        }
                        else
                        {
                            deduction = Convert.ToDecimal(deduction_amount);
                        }

                        if (Convert.ToBoolean(item[4].ToString()))
                        {
                            deduction = deduction * -1;
                        }

                        final_deduction += deduction;
                    }
                    salary_txt.Value = final_deduction + salary;
                }

            }
            catch (Exception)
            {
            }
            

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
    }
}
