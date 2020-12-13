using FastFood.Static;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFood
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void lb_ok_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == null || txtMatKhau == null || txt_newpassw.Text == null || txt_comfPass == null)
            {
                errorProvider1.SetError(lb_ok, "All fields must be filled");
            }
            else
            {
                string login = txtMaNV.Text.Trim();
                string passold = txtMatKhau.Text.Trim();
                string passnew = txt_newpassw.Text.Trim();
                string passconf = txt_comfPass.Text.Trim();
                if (passnew == passconf)
                {
                    // thật ra không dùng connection string này nhiều
                    // tao để debug là chính
                    Global.global_connection_string = String.Format("Data Source=(local);Initial Catalog=QLBH_FastFood;User ID={0};Password={1}", login, passold);

                    MessageBox.Show(Global.global_connection_string);

                    try
                    {
                        Global.global_datacontext = new QLBH_FastFoodDataContext(Global.global_connection_string);
                        Global.global_datacontext.Connection.Open();
                        if (Global.global_datacontext.Connection.State == ConnectionState.Open)
                        {

                            Global.global_connection_string = "";
                            Global.global_datacontext.Connection.Close();


                        }
                        try
                        {
                            Global.global_datacontext = new QLBH_FastFoodDataContext();
                            Global.global_datacontext.Connection.Open();
                            Global.global_datacontext.sp_ChangePassword(login, passnew);
                            Global.global_datacontext.Connection.Close();
                            DialogResult di = MessageBox.Show("Đổi mật khẩu thành công!, Chọn Ok để về Đăng nhập","Thành công",MessageBoxButtons.OK);
                            if (di == DialogResult.OK)
                            {
                                this.Close();
                            }    
                            
                        }
                        catch
                        {
                            errorProvider1.SetError(txtMaNV, "Fail");
                        }
                    }
                    catch
                    {
                        errorProvider1.SetError(txtMaNV, "Login and password does not match");
                    }
                }
                else
                {
                    errorProvider1.SetError(lb_ok, "Password and confirm password does not match");
                }
            }
        }

        private void txt_comfPass_TextChanged(object sender, EventArgs e)
        {
            string passnew = txt_newpassw.Text.Trim();
            string passconf = txt_comfPass.Text.Trim();
            if (passnew != passconf)
            {
                errorProvider1.SetError(txt_comfPass, "Password and confirm password does not match");
            }    
            else
            {
                errorProvider1.Clear();
            }    
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_newpassw_Click(object sender, EventArgs e)
        {
            if (txt_newpassw.Text == "New Password")
                txtMaNV.Text = "";
        }

        private void txt_comfPass_Click(object sender, EventArgs e)
        {
            if (txt_newpassw.Text == "Confirm new password") 
                txtMaNV.Text = "";
        }

        private void txt_comfPass_Leave(object sender, EventArgs e)
        {

        }
    }
}
