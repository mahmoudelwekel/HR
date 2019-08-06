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
    public partial class login : Form
    {


        public login()
        {
           
                InitializeComponent();

                this.BringToFront();
                this.Activate();
                this.ActiveControl = usernametxt;
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            try
            {
                int userid = this.users_ViewTableAdapter.check_for_login(this.hrDataSet.users_View,usernametxt.Text,passwordtxt.Text);

                DataTable user = this.users_ViewTableAdapter.Get_check_for_login(usernametxt.Text, passwordtxt.Text);

                if (userid == 1)
                {

                    LoginInfo.employer_id = user.Rows[0]["employer_id"].ToString();
                    LoginInfo.employee_name = user.Rows[0]["employee_name"].ToString();
                    LoginInfo.user_name= user.Rows[0]["user_name"].ToString();
                    LoginInfo.employee_rule_id = user.Rows[0]["employee_rule_id"].ToString();
                    LoginInfo.printer_name = user.Rows[0]["printer_name"].ToString();

                    if (user.Rows[0]["user_current_date"].ToString()==null|| user.Rows[0]["user_current_date"].ToString() == "")
                    {
                        string date = DateTime.Now.ToString("yyyy-MM-dd");

                        this.usersTableAdapter.update_user_current_date(date,int.Parse(user.Rows[0]["employer_id"].ToString()));
                        LoginInfo.user_current_date = date;
                    }
                    else
                    {
                        LoginInfo.user_current_date = DateTime.Parse(user.Rows[0]["user_current_date"].ToString()).ToString("yyyy-MM-dd");
                    }


                    //c.log("تسجيل دخول");

                    home home = new home();
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("بيانات الدخول غير صحيحة حاول مرة اخرى", "تسجيل الدخول", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
            catch (Exception)
            {
                MessageBox.Show("حدث خطأ", "حدث خطأ فى تسجيل الدخول", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
}

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception)
            {
                MessageBox.Show("حدث خطأ", "حدث خطأ فى تسجيل الدخول", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
