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
    public partial class users : Form
    {
        public users()
        {
            InitializeComponent();
        }

        private void users_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'hRDataSet.employees' table. You can move, or remove it, as needed.
                this.employeesTableAdapter.Fill(this.hRDataSet.employees);
                // TODO: This line of code loads data into the 'hRDataSet.users_View' table. You can move, or remove it, as needed.
                this.users_ViewTableAdapter.Fill(this.hRDataSet.users_View);

                foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
                {
                    printer_list.Items.Add(printer);
                }

            }
            catch (Exception)
            {
            }

        }

        void clearall()
        {
            try
            {
                this.users_ViewTableAdapter.search(this.hRDataSet.users_View, search_txt.Text);

                employee_list.SelectedIndex = -1;
                printer_list.SelectedIndex = -1;
                username_txt.Text = "";
                password_txt.Text = "";

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

        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.users_ViewTableAdapter.search(this.hRDataSet.users_View, search_txt.Text);
            }
            catch (Exception)
            {
            }
           
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (employee_list.SelectedIndex != -1&&username_txt.Text != ""&&password_txt.Text != "")
                {

                    this.usersTableAdapter.Insert((int)employee_list.SelectedValue,username_txt.Text,password_txt.Text,printer_list.Text,Convert.ToBoolean(active_ch.CheckState),null);
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

                        this.usersTableAdapter.Update(id, username_txt.Text, password_txt.Text, printer_list.Text, Convert.ToBoolean(active_ch.CheckState), null);

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

                        this.usersTableAdapter.Delete(id);

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
