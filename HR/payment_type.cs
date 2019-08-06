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
    public partial class payment_type : Form
    {
        public payment_type()
        {
            InitializeComponent();
        }

        private void departments_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'hRDataSet.payment_type' table. You can move, or remove it, as needed.
                this.payment_typeTableAdapter.Fill(this.hRDataSet.payment_type);

            }
            catch (Exception)
            {
            }
          
        }

        void clearall()
        {
            try
            {
                this.payment_typeTableAdapter.search(this.hRDataSet.payment_type, search_txt.Text);

                name_txt.Text = "";

                this.ActiveControl = name_txt;
            }
            catch (Exception)
            {
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            clearall();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (name_txt.Text != "")
                {

                    this.payment_typeTableAdapter.Insert(name_txt.Text, Convert.ToBoolean( active_ch.CheckState));

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

                        this.payment_typeTableAdapter.Update(name_txt.Text, Convert.ToBoolean(active_ch.CheckState), id);

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

                        this.payment_typeTableAdapter.Delete(id);

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

        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.payment_typeTableAdapter.search(this.hRDataSet.payment_type, search_txt.Text);

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
