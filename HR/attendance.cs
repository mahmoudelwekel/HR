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
    public partial class attendance : Form
    {
        public attendance()
        {
            InitializeComponent();
        }

        private void attendance_Load(object sender, EventArgs e)
        {
            clearall();
        }

        private void clearall()
        {
            try
            {
                employee_id.Value = 0;
                employee_list.SelectedIndex = -1;
                this.employeesTableAdapter.FillBy_active(this.hRDataSet.employees);
                DateTime current = DateTime.Parse(LoginInfo.user_current_date);
                this.attendance_ViewTableAdapter.today_attendace(this.hRDataSet.attendance_View, current.ToShortDateString());

                this.ActiveControl = employee_id;

            }
            catch (Exception)
            {

            }
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (employee_list.SelectedIndex != -1)
                {
                    int employee_id = (int)employee_list.SelectedValue;
                    DateTime d = DateTime.Now;
                    TimeSpan time = TimeSpan.Parse(d.ToString("HH:mm:ss"));

                    DateTime current = DateTime.Parse(LoginInfo.user_current_date);

                    int exist = this.attendanceTableAdapter.if_exist(this.hRDataSet.attendance, employee_id, current.ToShortDateString());


                    if (comming_rd.Checked)//حضور
                    {
                        if (exist == 0)
                        {
                            this.attendanceTableAdapter.Insert(employee_id, time, time, current.Date);
                            MessageBox.Show("تم تسجيل الحضور بنجاح", "تسجيل الحضور", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("تم تسجيل الحضور من قبل ", "تسجيل الحضور", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                    if (going_rd.Checked)//انصراف
                    {
                        if (exist == 1)
                        {
                            this.attendanceTableAdapter.Update_going_time(time.ToString(), employee_id, current.ToShortDateString());
                            MessageBox.Show("تم تسجيل الأنصراف بنجاح", "تسجيل الأنصراف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("تم تسجيل الأنصراف من قبل ", "تسجيل الأنصراف", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("أختر الموظف أولا من القائمة او ادخل رقم الموظف ", "تسجيل الحضور و الأنصراف", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                clearall();
            }
            catch (Exception)
            {
            }
        }
        

        private void employee_id_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'hRDataSet.employees' table. You can move, or remove it, as needed.
                DataTable empl = this.employeesTableAdapter.Get_search_by_id((int)employee_id.Value);

                if (empl.Rows.Count == 0)
                {
                    employee_list.SelectedIndex = -1;
                }
                else
                {
                    employee_list.SelectedValue = empl.Rows[0][0].ToString();
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

        private void employee_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                employee_id.Value = Convert.ToDecimal(employee_list.SelectedValue);

            }
            catch (Exception)
            {
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            clearall();
        }
    }
}
