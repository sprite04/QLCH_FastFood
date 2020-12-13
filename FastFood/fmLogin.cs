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
using FastFood.BLL;
using FastFood.Static;

namespace FastFood
{
    public partial class fmLogin : Form
    {
        public string connectionString;
        public fmLogin()
        {
            InitializeComponent();
        }

        private void fmLogin_Load(object sender, EventArgs e)
        {
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            try
            {
                //đoạn này dùng để khởi tạo record thống kê, lương
                //nhân viên login => không có quyền truy cập thống kê => không tạo được tk
                // khi chưa có thống kê tuownwng ứng => hóa đơn được tạo sẽ không được cập nhật vào thống kê
                // trigger on hóa đơn => update thống kê 
                // TH xảy ra:
                //  Đầu tháng: nhân viên đăng nhập => không có quyền tạo tk => không có thống kê tương ứng với tháng mới
                //  nhân viên đặt hóa đơn => không được cộng vào thống kê tương ứng
                // do windows 
                Global.global_datacontext = new QLBH_FastFoodDataContext();
                Global.global_datacontext.Connection.Open();
                int month = DateTime.Now.Month;
                int year = DateTime.Now.Year;
                BLLThongKe bltk = new BLLThongKe();
                string err;
                bltk.Insert(year, month, out err);
                BLLuong bLLuong = new BLLuong();
                BLNhanVien bLNhanvien = new BLNhanVien();
                List<v_NhanVien> dsnv = bLNhanvien.dsVNhanVien();
                foreach (v_NhanVien nv in dsnv)
                {
                    bLLuong.Insert(DateTime.Now, nv.MaNV, out err);
                }
                MessageBox.Show(Global.global_datacontext.Connection.ConnectionString);
                Global.global_datacontext.Connection.Close();
            }
            catch
            {
                MessageBox.Show("Data error (from fmLogin.cs line 42)");

            }
        }



        private string id;
        private string pw;









        private void btnLogin_Click_1(object sender, EventArgs e)
        {


            string id = txtMaNV.Text.Trim();
            string pw = txtMatKhau.Text.Trim();
            // thật ra không dùng connection string này nhiều
            // tao để debug là chính
            Global.global_connection_string = String.Format("Data Source=(local);Initial Catalog=QLBH_FastFood;User ID={0};Password={1}", id, pw);
            


            try
            {
                //QLBH_FastFoodDataContext context = new QLBH_FastFoodDataContext(connectionString);
                //khi mở kết nối với connection string dạng ở trên Global.global_connection_string
                //admin1 123
                //employee1 123
                //manager1 123
                //stkp1 123
                // 4 test login
                Global.global_datacontext = new QLBH_FastFoodDataContext(Global.global_connection_string);

                Global.global_datacontext.Connection.Open();
                //MessageBox.Show(context.Connection.ConnectionString);
                if (Global.global_datacontext.Connection.State == ConnectionState.Open)
                {
                    
                    MessageBox.Show(Global.global_datacontext.Connection.ConnectionString);
                    Form1 fm1 = new Form1();
                    fm1.ShowDialog();
                    txtMaNV.Clear();
                    txtMatKhau.Clear();
                    Global.global_datacontext.Connection.Close();
                    Global.global_connection_string = "";
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

        private void lb_change_login_password_Click(object sender, EventArgs e)
        {
            ChangePassword fm = new ChangePassword();
            fm.ShowDialog();
            txtMaNV.Clear();
            txtMatKhau.Clear();
        }
    }
}
