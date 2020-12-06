using FastFood.BLL;
using FastFood.UIQuanLy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFood
{
    public partial class Manager : Form
    {
        public Manager(Login l)
        {
            InitializeComponent();
            login = l;
        }
        SqlConnection conn;
        public Manager(SqlConnection connection)
        {
            InitializeComponent();
            sqlConnection = connection;
            conn = connection;

            //làm cái này đẹp đẹp xíu nè. Kiểu welcome ..... hay là login thành công gì đó
            //MessageBox.Show(arrListStr);

        }
        public Manager(Login l, SqlConnection connection)
        {
            InitializeComponent();
            login = l;
            conn = connection;


  
            //làm cái này đẹp đẹp xíu nè. Kiểu welcome ..... hay là login thành công gì đó
            //MessageBox.Show(arrListStr);

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        SqlConnection sqlConnection = new SqlConnection();
        Form1 FORM = new Form1();
        Login login = new Login();
        public Manager(Form1 form)
        {
            InitializeComponent();
            FORM = form;
            this.Show();
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            List<Button> admin_btns = new List<Button>();
            List<PictureBox> admin_pic = new List<PictureBox>();
            List<Button> emp_btn = new List<Button>();
            List<Button> stkp_btn = new List<Button>();
            List<PictureBox> stkp_pic = new List<PictureBox>();
            admin_btns.Add(btnBill);
            admin_btns.Add(btnEmployee);
            admin_btns.Add(btnItem);
            admin_btns.Add(btnMaterial);
            admin_btns.Add(btnRevene);
            admin_btns.Add(btnSalary);
            admin_btns.Add(btnShift);
            admin_btns.Add(btnDashboard);
            admin_pic.Add(picItem);
            admin_pic.Add(picRevenue);
            admin_pic.Add(picSalary);
            admin_pic.Add(pictureBox2);
            admin_pic.Add(pictureBox3);
            admin_pic.Add(picBill);
            admin_pic.Add(picDashboard);
            admin_pic.Add(picEmployee);

            emp_btn.Add(btnItem);
            emp_btn.Add(btnItem);
            emp_btn.Add(btnItem);
            emp_btn.Add(btnItem);

            stkp_btn.Add(btnMaterial);
            stkp_pic.Add(pictureBox2);
            string connect = sqlConnection.ConnectionString;
            if (connect.Contains("admin"))
            {
                foreach(Button a in admin_btns)
                {
                    a.Enabled = true;
                    a.Visible = true;
                }
                foreach (PictureBox x in admin_pic)
                {
                    x.Visible = true;
                }    
            }
            else if (connect.Contains("storekeeper")) 
            {
                foreach (Button a in admin_btns)
                {
                    a.Enabled = false;
                    a.Visible = false;
                }
                foreach (Button a in stkp_btn)
                {
                    a.Enabled = true;
                    a.Visible = true;
                }
                foreach (PictureBox x in admin_pic)
                {
                    x.Visible = false;
                }
                foreach (PictureBox x in stkp_pic)
                {
                    x.Visible = true;
                }
            }
            
            

            this.WindowState = FormWindowState.Maximized;
            this.Size = new Size(1000, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            
            Prestart();
        }
        public void Prestart()
        {
            try
            {
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
            }
            catch
            {
                MessageBox.Show("Data error (from Manager.cs line 153)");
            }

        }
        private string Get_ID(SqlConnection conn)
        {
            try
            {
                string[] arrListStr = conn.ConnectionString.Split(';');
                string temp = arrListStr[arrListStr.Length - 2];
                string[] temp_list = temp.Split('=');
                return temp_list[1];
            }
            catch
            {
                return "Not available";
            }

        }
        private void btnZoom_Click(object sender, EventArgs e)
        {
            if (pnList.Width == 258)
                pnList.Width = 80;
            else
                pnList.Width = 258;
        }


        private void picItem_Click(object sender, EventArgs e)
        {
            btnItem.PerformClick();
        }

        private void picBill_Click(object sender, EventArgs e)
        {
            btnBill.PerformClick();
        }

        private void picEmployee_Click(object sender, EventArgs e)
        {
            btnEmployee.PerformClick();
        }

        private void picSalary_Click(object sender, EventArgs e)
        {
            btnSalary.PerformClick();
        }

        private void picRevenue_Click(object sender, EventArgs e)
        {
            btnRevene.PerformClick();
        }

        private void picDashboard_Click(object sender, EventArgs e)
        {
            btnDashboard.PerformClick();
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            pnShow.Controls.Clear();
            Products products = new Products(conn);
            products.Dock = DockStyle.Fill;
            pnShow.Controls.Add(products);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximize.Visible = false;
            btnRestore.Visible = true;
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaximize.Visible = true;
            btnRestore.Visible = false;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnTieuDe_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximize.Visible = false;
            btnRestore.Visible = true;
            pnShow.Controls.Clear();
            Employee employee = new Employee(conn);
            employee.Dock = DockStyle.Fill;
            pnShow.Controls.Add(employee);
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximize.Visible = false;
            btnRestore.Visible = true;
            pnShow.Controls.Clear();
            Bill bill = new Bill(conn);
            bill.Dock = DockStyle.Fill;
            pnShow.Controls.Add(bill);
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            //string err = "";
            //try
            //{
            //    BLLuong bLLuong = new BLLuong();
            //    BLNhanVien bLNhanvien = new BLNhanVien();
            //    List<v_NhanVien> dsnv = bLNhanvien.dsVNhanVien();
            //    foreach (v_NhanVien nv in dsnv)
            //    {
            //        bLLuong.Insert(DateTime.Now, nv.MaNV, out err);
            //    }
            //}
            //catch
            //{
            //    MessageBox.Show(err);
            //}
            this.WindowState = FormWindowState.Maximized;
            btnMaximize.Visible = false;
            btnRestore.Visible = true;
            pnShow.Controls.Clear();
            Salary salary = new Salary(conn);
            salary.Dock = DockStyle.Fill;
            pnShow.Controls.Add(salary);
        }

        private void btnRevene_Click(object sender, EventArgs e)
        {
            pnShow.Controls.Clear();
            Revenue revenue = new Revenue(conn);
            revenue.Dock = DockStyle.Fill;
            pnShow.Controls.Add(revenue);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            
        }


        private void btnMaterial_Click(object sender, EventArgs e)
        {
            pnShow.Controls.Clear();
            Material materials = new Material(conn);
            materials.Dock = DockStyle.Fill;
            pnShow.Controls.Add(materials);
        }

        private void btnShift_Click(object sender, EventArgs e)
        {
            BLCa blCa = new BLCa();
            var dsCa = blCa.dsCa();
            if(DateTime.Now.Hour>=7&&DateTime.Now.Hour<12)
            {
                var ds = (from ca in dsCa
                          where ca.MaCa.Day == DateTime.Now.Day && ca.MaCa.Month == DateTime.Now.Month && ca.MaCa.Year == DateTime.Now.Year && ca.MaCa.Hour >= 7 && ca.MaCa.Hour < 12
                          select ca.MaCa).ToList();
                if (ds.Count == 0)
                {
                    string message;
                    DateTime dt = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 7, 0, 0);
                    blCa.Insert(dt,out message);
                }
            }   
            else if (DateTime.Now.Hour >= 12 && DateTime.Now.Hour < 17)
            {
                var ds = (from ca in dsCa
                          where ca.MaCa.Day == DateTime.Now.Day && ca.MaCa.Month == DateTime.Now.Month && ca.MaCa.Year == DateTime.Now.Year && ca.MaCa.Hour >= 12 && ca.MaCa.Hour < 17
                          select ca.MaCa).ToList();
                if (ds.Count == 0)
                {
                    string message;
                    DateTime dt = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 12, 0, 0);
                    blCa.Insert(dt, out message);
                }
            }
            else if (DateTime.Now.Hour >= 17 && DateTime.Now.Hour < 22)
            {
                var ds = (from ca in dsCa
                          where ca.MaCa.Day == DateTime.Now.Day && ca.MaCa.Month == DateTime.Now.Month && ca.MaCa.Year == DateTime.Now.Year && ca.MaCa.Hour >= 17 && ca.MaCa.Hour < 22
                          select ca.MaCa).ToList();
                if (ds.Count == 0)
                {
                    string message;
                    DateTime dt = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 17, 0, 0);
                    blCa.Insert(dt, out message);
                }
            }

            this.WindowState = FormWindowState.Maximized;
            btnMaximize.Visible = false;
            btnRestore.Visible = true;
            pnShow.Controls.Clear();
            Shift shift = new Shift();
            shift.Dock = DockStyle.Fill;
            pnShow.Controls.Add(shift);
        }
    }
}
