using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FastFood
{
    public partial class fmLogin : Form
    {
        public fmLogin()
        {
            InitializeComponent();
        }

        private void fmLogin_Load(object sender, EventArgs e)
        {
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            
        }



        private string id;
        private string pw;









        private void btnLogin_Click_1(object sender, EventArgs e)
        {

            try
            {
                string id = txtMaNV.Text.Trim();
                string pw = txtMatKhau.Text.Trim();
                string strCon = String.Format("Data Source=(local);Initial Catalog=QLBH_FastFood;User ID={0};Password={1}", id, pw);


                SqlConnection conn = null;
                SqlDataAdapter adapter = null;
                SqlCommand command = null;
                conn = new SqlConnection(strCon);
                command = new SqlCommand();
                command.Connection = conn;
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();
                if (conn.ConnectionString.Contains("storekeeper"))
                {
                    Manager manager = new Manager(conn);
                    manager.ShowDialog();
                }
                else
                {
                    Form1 form = new Form1(conn);

                    form.ShowDialog();
                }

            }
            catch
            {
                errorProvider1.SetError(txtMaNV, "đăng nhập không thành công");
            }
        }

        private void txtMatKhau_Leave_1(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "")
            {
                txtMatKhau.PasswordChar = (char)0;
                txtMatKhau.Text = "Password";
            }
        }

        private void txtMatKhau_Click_1(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "Password")
            {
                txtMatKhau.Text = "";
                txtMatKhau.PasswordChar = '•';
            }
        }

        private void txtMaNV_Click_1(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "Username")
                txtMaNV.Text = "";
        }

        private void txtMaNV_Leave_1(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "")
                txtMaNV.Text = "Username";
        }

        private void txtMatKhau_Enter(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "Username")
                txtMaNV.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //thêm bạn có chắc k
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = '•';
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                if (txtMaNV.Text == "Username" || txtMaNV.Text == "")
                {
                    errorProvider1.SetError(txtMatKhau, "Bạn chưa nhập tài khoản!");
                }
                else if (txtMatKhau.Text == "Password" || txtMatKhau.Text == "")
                {
                    errorProvider1.SetError(txtMatKhau, "Bạn chưa nhập mật khẩu!");
                }
                else
                {
                    btnLogin.PerformClick();
                }
            }
        }
    }
}
