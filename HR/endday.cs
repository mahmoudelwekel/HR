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
    public partial class endday : Form
    {
        public endday()
        {
            InitializeComponent();
        }

        private void endday_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'hRDataSet.users_View' table. You can move, or remove it, as needed.
                this.users_ViewTableAdapter.current_users(this.hRDataSet.users_View);

            }
            catch (Exception)
            {

            }

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("هل أنت متأكد من إنهاء اليوم ؟", "إنهاء اليوم ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow dr = dataGridView1.CurrentRow;
                    if (dr != null)
                    {

                        int id = int.Parse(dr.Cells[0].Value.ToString());

                        this.usersTableAdapter.update_user_current_date(null, id);

                        MessageBox.Show(this, "تم إنهاء اليوم", "إنهاء اليوم ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("أختر من القائمة أولا", "إنهاء اليوم", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                this.users_ViewTableAdapter.current_users(this.hRDataSet.users_View);

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.users_ViewTableAdapter.current_users(this.hRDataSet.users_View);

        }
    }
}
