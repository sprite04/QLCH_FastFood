using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFood
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        private int Ma;
        private string MK;
        public int MaNV
        {
            get { return Ma; }
        }

        public string MatKhau
        {
            get { return MK; }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            int Num;
            bool kq = int.TryParse(txtMaNV.Text, out Num);
            if (kq == false)
            {
                errorProvider1.SetError(txtMaNV, "Tên đăng nhập không chính xác");
                return;
            }
            QLBH_FastFoodDataContext context = new QLBH_FastFoodDataContext();
            sp_LoginResult nv = context.sp_Login(Num).FirstOrDefault();
            if(nv==null)
            {
                errorProvider1.SetError(txtMaNV, "Tên đăng nhập không chính xác");
                return;
            }
            if (txtMaNV.Text==nv.MaNV.ToString() && txtMatKhau.Text==nv.MatKhau && nv.MaCV>1 && nv.TT_Lam==true)
            {
                Ma = Num;
                MK = txtMatKhau.Text;
                txtMaNV.Text = "Username";
                txtMatKhau.PasswordChar = (char)0;
                txtMatKhau.Text = "Password";
                Manager manager = new Manager(this);
                manager.ShowDialog();
            }
            else if(txtMaNV.Text == nv.MaNV.ToString() && txtMaNV.Text != nv.MatKhau && nv.MaCV > 1 && nv.TT_Lam == true)
            {
                errorProvider1.SetError(txtMatKhau, "Mật khẩu không chính xác");
                return;
            }
            else
            {
                errorProvider1.SetError(txtMaNV, "Đăng nhập không hợp lệ");
                return;
            }    
        }
        private void txtMaNV_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "Username")
                txtMaNV.Text = "";
        }

        private void txtMaNV_Leave(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "")
                txtMaNV.Text = "Username";
        }

        private void txtMatKhau_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "Password")
            {
                txtMatKhau.Text = "";
                txtMatKhau.PasswordChar = '•';
            }
        }

        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "")
            {
                txtMatKhau.PasswordChar = (char)0;
                txtMatKhau.Text = "Password";
            }
        }
    }
}
