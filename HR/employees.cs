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
    public partial class employees : Form
    {
        public employees()
        {
            InitializeComponent();
        }

        void clearall()
        {
            try
            {
                this.statusTableAdapter.Fill(this.hRDataSet.status);
                this.rulesTableAdapter.Fill(this.hRDataSet.rules);
                this.departmentsTableAdapter.Fill(this.hRDataSet.departments);

                this.employees_ViewTableAdapter.search(this.hRDataSet.employees_View, search_txt.Text);

                name_txt.Text = "";
                department_list.SelectedIndex = -1;
                nationalid_txt.Text = "";
                rule_list.SelectedIndex = -1;
                adress_txt.Text = "";
                phone_txt.Text = "";
                salary_txt.Value = 0;
                status_list.SelectedIndex = -1;
                hour_price_txt.Value = 0;
                day_hours.Value = 0;

                this.ActiveControl = name_txt;
            }
            catch (Exception)
            {
            }
        }

        private void employees_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'hRDataSet.status' table. You can move, or remove it, as needed.
                this.statusTableAdapter.Fill(this.hRDataSet.status);
                // TODO: This line of code loads data into the 'hRDataSet.rules' table. You can move, or remove it, as needed.
                this.rulesTableAdapter.Fill(this.hRDataSet.rules);
                // TODO: This line of code loads data into the 'hRDataSet.departments' table. You can move, or remove it, as needed.
                this.departmentsTableAdapter.Fill(this.hRDataSet.departments);
                // TODO: This line of code loads data into the 'hRDataSet.employees_View' table. You can move, or remove it, as needed.
                this.employees_ViewTableAdapter.Fill(this.hRDataSet.employees_View);
            }
            catch (Exception)
            {
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            clearall();
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

        private void add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (name_txt.Text != "")
                {

                    this.employeesTableAdapter.Insert(
                   name_txt.Text,
                   (int)rule_list.SelectedValue,
                   nationalid_txt.Text,
                   phone_txt.Text,
                   adress_txt.Text,
                   (int)status_list.SelectedValue,
                   salary_txt.Value,
                   day_hours.Value,
                   hour_price_txt.Value,
                   (int)department_list.SelectedValue,
                   Convert.ToBoolean(active_ch.CheckState)
                   );
                }
                else
                {
                    MessageBox.Show("أدخل البيانات أولا", "الأضافة", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                clearall();
            }
            catch (Exception)
            {
            }
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("هل أنت متأكد من أجراء هذا التعديل ؟", "تعديل بيانات ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow dr = dataGridView1.CurrentRow;
                    if (dr != null)
                    {

                        int id = int.Parse(dr.Cells[0].Value.ToString());

                        this.employeesTableAdapter.Update(
                            name_txt.Text,
                            (int)rule_list.SelectedValue,
                            nationalid_txt.Text,
                            phone_txt.Text,
                            adress_txt.Text,
                            (int)status_list.SelectedValue,
                            salary_txt.Value,
                            day_hours.Value,
                            hour_price_txt.Value,
                            (int)department_list.SelectedValue,
                            Convert.ToBoolean(active_ch.CheckState),
                            id
                            );

                        MessageBox.Show(this, "تم التعديل بنجاح", "تعديل بيانات ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("أختر من القائمة أولا", "التعديل", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                clearall();
            }
            catch (Exception)
            {
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("هل أنت متأكد من أجراء هذا الحذف ؟", "حذف بيانات ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow dr = dataGridView1.CurrentRow;

                    if (dr != null)
                    {
                        int id = int.Parse(dr.Cells[0].Value.ToString());

                        this.employeesTableAdapter.Delete(id);

                        MessageBox.Show(this, "تم الحذف بنجاح", "حذف بيانات ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("أختر من القائمة أولا", "الحذف", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                clearall();
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
