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
    public partial class deductions : Form
    {
        public deductions()
        {
            InitializeComponent();
        }

        void clearall()
        {
            try
            {
                this.deductions_ViewTableAdapter.search(this.hRDataSet.deductions_View, search_txt.Text);
                this.deduction_typesTableAdapter.Fill(this.hRDataSet.deduction_types);
                this.rulesTableAdapter.Fill(this.hRDataSet.rules);


                rule_list.SelectedIndex = -1;
                deduction_type_list.SelectedIndex = -1;
                amount_txt.Text = "0";

                this.ActiveControl = rule_list;

            }
            catch (Exception)
            {

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            clearall();
        }
        private void deductions_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'hRDataSet.deductions_View' table. You can move, or remove it, as needed.
                this.deductions_ViewTableAdapter.Fill(this.hRDataSet.deductions_View);
                // TODO: This line of code loads data into the 'hRDataSet.deduction_types' table. You can move, or remove it, as needed.
                this.deduction_typesTableAdapter.Fill(this.hRDataSet.deduction_types);
                // TODO: This line of code loads data into the 'hRDataSet.rules' table. You can move, or remove it, as needed.
                this.rulesTableAdapter.Fill(this.hRDataSet.rules);

            }
            catch (Exception)
            {
            }
            
        }
        
        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.deductions_ViewTableAdapter.search(this.hRDataSet.deductions_View,search_txt.Text);
            }
            catch (Exception)
            {
            }
        }


        private void add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (rule_list.SelectedIndex != -1)
                {

                    this.deductionsTableAdapter.Insert((int)rule_list.SelectedValue, (int)deduction_type_list.SelectedValue, amount_txt.Text);

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

                        this.deductionsTableAdapter.Update((int)rule_list.SelectedValue, (int)deduction_type_list.SelectedValue, amount_txt.Text, id);

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

                        this.deductionsTableAdapter.Delete(id);

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
