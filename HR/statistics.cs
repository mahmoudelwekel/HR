using Microsoft.Reporting.WinForms;
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
    public partial class statistics : Form
    {
        public statistics()
        {
            InitializeComponent();
        }

        private void statistics_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'hRDataSet.holidays_View' table. You can move, or remove it, as needed.
                this.holidays_ViewTableAdapter.Fill(this.hRDataSet.holidays_View);
                // TODO: This line of code loads data into the 'hRDataSet.employees' table. You can move, or remove it, as needed.
                this.employeesTableAdapter.Fill(this.hRDataSet.employees);
                // TODO: This line of code loads data into the 'hRDataSet.attendance_View' table. You can move, or remove it, as needed.
                this.attendance_ViewTableAdapter.Fill(this.hRDataSet.attendance_View);
                // TODO: This line of code loads data into the 'hRDataSet.payment_View' table. You can move, or remove it, as needed.
                this.payment_ViewTableAdapter.Fill(this.hRDataSet.payment_View);

                this.employees_ViewTableAdapter.Fill(this.hRDataSet.employees_View);
            }
            catch (Exception)
            {
            }
       

        }

        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.employees_ViewTableAdapter.search(this.hRDataSet.employees_View, search_txt.Text);
            }
            catch (Exception)
            {
            }
        }

        private void sales_date_from_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime date = DateTime.Parse(salary_date_from.Text);
                DateTime firstDayOfMonth = new DateTime(date.Year, date.Month, 1);
                DateTime lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);


                this.salary_ViewTableAdapter.Fill(this.hRDataSet.salary_View, firstDayOfMonth, lastDayOfMonth);


            }
            catch (Exception)
            {

            }

        }

        private void statistics_DoubleClick(object sender, EventArgs e)
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

        decimal deduction(int id,decimal salary,decimal remain)
        {

            DataTable dt = this.employees_deduction_ViewTableAdapter.GetDataBy_emp_id(id);

            decimal final_deduction = 0;
           
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

            return final_deduction;
        }
        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = dataGridView2.CurrentRow;

               

                if (dr != null)
                {

                    decimal salary = decimal.Parse(dr.Cells[10].Value.ToString());
                    decimal remain = decimal.Parse(dr.Cells[13].Value.ToString());
                    decimal final_deduction = deduction((int)dr.Cells[0].Value,salary,remain);

                    salary_txt.Value = final_deduction + salary;
                    remain_txt.Value = final_deduction + remain;
                    cut_txt.Value = final_deduction;
                }

            }
            catch (Exception)
            {

            }
           
        }

        private void from_txt_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime from = DateTime.Parse(from_txt.Text);
                DateTime to = DateTime.Parse(to_txt.Text);

                // TODO: This line of code loads data into the 'hRDataSet.attendance_View' table. You can move, or remove it, as needed.
                this.attendance_ViewTableAdapter.search_by_date(this.hRDataSet.attendance_View, from.ToString("yyyy-MM-dd"), to.ToString("yyyy-MM-dd"));
            }
            catch (Exception)
            {
            }
           
        }

        private void employees_list_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'hRDataSet.attendance_View' table. You can move, or remove it, as needed.
                this.attendance_ViewTableAdapter.search_by_id(this.hRDataSet.attendance_View, (int)employees_list.SelectedValue);

            }
            catch (Exception)
            {
            }

        }

        private void from2_txt_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime from = DateTime.Parse(from2_txt.Text);
                DateTime to = DateTime.Parse(to2_txt.Text);

                // TODO: This line of code loads data into the 'hRDataSet1.holidays_View' table. You can move, or remove it, as needed.
                this.holidays_ViewTableAdapter.search_by_day(this.hRDataSet.holidays_View, from.ToString("yyyy-MM-dd"), to.ToString("yyyy-MM-dd"));
            }
            catch (Exception)
            {
            }

        }

        private void employees2_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'hRDataSet1.holidays_View' table. You can move, or remove it, as needed.
                this.holidays_ViewTableAdapter.search_by_id(this.hRDataSet.holidays_View, (int)employees2_list.SelectedValue);

            }
            catch (Exception)
            {

            }

        }

        private void from3_txt_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime from = DateTime.Parse(from3_txt.Text);
                DateTime to = DateTime.Parse(to3_txt.Text);

                // TODO: This line of code loads data into the 'hRDataSet1.holidays_View' table. You can move, or remove it, as needed.
                this.payment_ViewTableAdapter.search_by_date(this.hRDataSet.payment_View, from.ToString("yyyy-MM-dd"), to.ToString("yyyy-MM-dd"));
            }
            catch (Exception)
            {
            }

        }

        private void employees3_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                // TODO: This line of code loads data into the 'hRDataSet1.holidays_View' table. You can move, or remove it, as needed.
                this.payment_ViewTableAdapter.search_by_id(this.hRDataSet.payment_View, (int)employees3_list.SelectedValue);
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

        private void employee_print_Click(object sender, EventArgs e)
        {
            try
            {
                BindingSource bs = (BindingSource)dataGridView1.DataSource;
                DataTable dt = ((HRDataSet)(bs.DataSource)).Tables["employees_View"];
                if (dt.Rows.Count != 0)
                {
                    LocalReport report1 = users_reportViewer.LocalReport;

                    report1.Refresh();

                    report1.PrintToPrinter(LoginInfo.printer_name);
                }
            }
            catch (Exception)
            {

            }
           
        }

        private void print_salary_Click(object sender, EventArgs e)
        {
            try
            {
                BindingSource bs = (BindingSource)dataGridView2.DataSource;
                DataTable dt = ((HRDataSet)(bs.DataSource)).Tables["salary_View"];
                if (dt.Rows.Count != 0)
                {

                    DataTable salary = this.hRDataSet.Tables["salary"];
                    salary.Rows.Clear();
                    foreach (DataRow item in dt.Rows)
                    {
                        decimal dedu = deduction((int)item[0], (decimal)item[10], (decimal)item[13]);
                        string name = item[1].ToString();
                        string salaryafterdedu = (dedu + (decimal)item[10]).ToString();
                        string paid = ((decimal)item[11] + (decimal)item[12]).ToString();
                        string remianafterdedu = (dedu + (decimal)item[13]).ToString();

                        salary.Rows.Add(name, salaryafterdedu, dedu.ToString(), paid, remianafterdedu);

                    }

                    ReportDataSource HRDataSet = new ReportDataSource("salary", salary);
                    ReportParameter date = new ReportParameter("date", salary_date_from.Text);


                    salary_reportViewer.LocalReport.DataSources.Clear();

                    salary_reportViewer.LocalReport.DataSources.Add(HRDataSet);
                    salary_reportViewer.LocalReport.SetParameters(new ReportParameter[] { date });

                    LocalReport report2 = salary_reportViewer.LocalReport;

                    report2.Refresh();

                    report2.PrintToPrinter(LoginInfo.printer_name);
                }

            }
            catch (Exception)
            {
            }
        }

        private void print_payment_Click(object sender, EventArgs e)
        {
            try
            {
                BindingSource bs = (BindingSource)dataGridView5.DataSource;
                DataTable dt = ((HRDataSet)(bs.DataSource)).Tables["payment_View"];
                if (dt.Rows.Count != 0)
                {

                    ReportParameter from = new ReportParameter("from", from3_txt.Text);
                    ReportParameter to = new ReportParameter("to", to3_txt.Text);

                    payment_reportViewer.LocalReport.SetParameters(new ReportParameter[] { from });
                    payment_reportViewer.LocalReport.SetParameters(new ReportParameter[] { to });

                    LocalReport report1 = payment_reportViewer.LocalReport;

                    report1.Refresh();

                    report1.PrintToPrinter(LoginInfo.printer_name);
                }

            }
            catch (Exception)
            {
            }


        }

        private void print_attendance_Click(object sender, EventArgs e)
        {
            try
            {
                BindingSource bs = (BindingSource)dataGridView3.DataSource;
                DataTable dt = ((HRDataSet)(bs.DataSource)).Tables["attendance_View"];
                if (dt.Rows.Count != 0)
                {

                    ReportParameter from = new ReportParameter("from", from_txt.Text);
                    ReportParameter to = new ReportParameter("to", to_txt.Text);

                    attendance_reportViewer.LocalReport.SetParameters(new ReportParameter[] { from });
                    attendance_reportViewer.LocalReport.SetParameters(new ReportParameter[] { to });

                    LocalReport report1 = attendance_reportViewer.LocalReport;

                    report1.Refresh();

                    report1.PrintToPrinter(LoginInfo.printer_name);
                }


            }
            catch (Exception)
            {

            }
        }

        private void print_holidays_Click(object sender, EventArgs e)
        {
            try
            {
                BindingSource bs = (BindingSource)dataGridView4.DataSource;
                DataTable dt = ((HRDataSet)(bs.DataSource)).Tables["holidays_View"];
                if (dt.Rows.Count != 0)
                {

                    ReportParameter from = new ReportParameter("from", from2_txt.Text);
                    ReportParameter to = new ReportParameter("to", to2_txt.Text);

                    holidays_reportViewer.LocalReport.SetParameters(new ReportParameter[] { from });
                    holidays_reportViewer.LocalReport.SetParameters(new ReportParameter[] { to });

                    LocalReport report1 = holidays_reportViewer.LocalReport;

                    report1.Refresh();

                    report1.PrintToPrinter(LoginInfo.printer_name);
                }
            }
            catch (Exception)
            {
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'hRDataSet.holidays_View' table. You can move, or remove it, as needed.
                this.holidays_ViewTableAdapter.Fill(this.hRDataSet.holidays_View);
                // TODO: This line of code loads data into the 'hRDataSet.employees' table. You can move, or remove it, as needed.
                this.employeesTableAdapter.Fill(this.hRDataSet.employees);
                // TODO: This line of code loads data into the 'hRDataSet.attendance_View' table. You can move, or remove it, as needed.
                this.attendance_ViewTableAdapter.Fill(this.hRDataSet.attendance_View);
                // TODO: This line of code loads data into the 'hRDataSet.payment_View' table. You can move, or remove it, as needed.
                this.payment_ViewTableAdapter.Fill(this.hRDataSet.payment_View);

                this.employees_ViewTableAdapter.Fill(this.hRDataSet.employees_View);
            }
            catch (Exception)
            {
            }
        }

        private void users_reportViewer_Load(object sender, EventArgs e)
        {

        }
    }
}
