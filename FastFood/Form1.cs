using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FastFood.BLL;
using System.Windows.Forms;
using FastFood.Static;
namespace FastFood
{
    public partial class Form1 : Form
    {


        List<NHANVIEN> dsNV = new List<NHANVIEN>();
        BLNhanVien blNV;




        public Form1()
        {
            InitializeComponent();
            SidePanel.Height = btnHome.Height;
            SidePanel.Top = btnHome.Top;
            
            home = new Home();
            home.Dock = DockStyle.Fill;
            home.BringToFront();
            pnShow.Controls.Add(home);
            int id = getNumber(Global.global_datacontext.Connection.ConnectionString);
            
            if (id == 1)
            {
                txtInfo.Text = "Test";
            }
            else
            {
                NHANVIEN nv = new NHANVIEN();
                blNV = new BLNhanVien();
                dsNV = blNV.dsNhanVien();
                nv = dsNV.Find(x => x.MaNV == id);
                if(nv!=null)
                {
                    txtInfo.Visible = true;
                    txtInfo.Text = (string.Format("{0}", nv.HoTen));
                }    
                else
                {
                    txtInfo.Visible = false;
                }    
            }

        }
        //public Form1(QLBH_FastFoodDataContext context)
        //{
        //    InitializeComponent();
        //    SidePanel.Height = btnHome.Height;
        //    SidePanel.Top = btnHome.Top;
        //    home = new Home(this.context);
        //    home.Dock = DockStyle.Fill;
        //    home.BringToFront();
        //    pnShow.Controls.Add(home);
        //    this.context = context;
        ////}
        //public Form1(SqlConnection connection)
        //{
        //    InitializeComponent();
        //    blNV = new BLNhanVien();
        //    dsNV = blNV.dsNhanVien();
        //    sqlConnection = connection;
        //    string arrListStr = Get_ID(connection);
        //    string connect = sqlConnection.ConnectionString;
        //    if (connect.Contains("employee"))
        //    {
        //        btnManager.Enabled = false;
        //        btnManager.Visible = false;

        //    }
        //    else
        //    {
        //        btnManager.Enabled = true;
        //        btnManager.Visible = true;
        //    }
        //    NHANVIEN nv = dsNV.Find(x => x.MaNV == getNumber(arrListStr));
        //    if (nv!=null)
        //        txtInfo.Text = (string.Format("{0}", nv.HoTen));
        //}
        private int getNumber(string input)
        {
            try
            {
                //lấy mã nhân viên từ connection string dạng 
                string id_s = input.Substring(input.Length - 4);
                //xóa dấu ;
                id_s = id_s.Remove(id_s.Length-1,1);
                
                int id = int.Parse(id_s);
                return id;
            }
            catch
            {
                return 1;
            }
        }
        //}
        //public Form1(Login l, SqlConnection connection)
        //{

        //    InitializeComponent();
        //    sqlConnection = connection;
        //    string arrListStr = Get_ID(connection);
        //    string connect = sqlConnection.ConnectionString;
        //    if (connect.Contains("employee"))
        //    {
        //        btnManager.Enabled = false;
        //        btnManager.Visible = false;

        //    }
        //    else
        //    {
        //        btnManager.Enabled = true;
        //        btnManager.Visible = true;
        //    }

        //    txtInfo.Text = (string.Format("{0}", getNumber(arrListStr)));
        //}

        private string Get_ID(SqlConnection connection)
        {
            try
            {
                string[] arrListStr = connection.ConnectionString.Split(';');
                string temp = arrListStr[arrListStr.Length - 2];
                string[] temp_list = temp.Split('=');
                return temp_list[1];
            }
            catch
            {
                return "Not available";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnHome.Height;
            SidePanel.Top = btnHome.Top;
            pnShow.Controls.Clear();
            home = new Home();
            home.Dock = DockStyle.Fill;
            home.BringToFront();
            pnShow.Controls.Add(home);

        }
        Home home;
        Menu monan;
        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnEatIn.Height;
            SidePanel.Top = btnEatIn.Top;
            pnShow.Controls.Clear();
            monan = new Menu();
            monan.Dock = DockStyle.Fill;
            monan.BringToFront();
            pnShow.Controls.Add(monan);
            pnShow.Width = 1000;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            //Prestart();
            btnHome.PerformClick();
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
                MessageBox.Show("Data error (from Form1.cs line 156)");
            }

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            try
            {
                SidePanel.Height = btnManager.Height;
                SidePanel.Top = btnManager.Top;
                pnShow.Controls.Clear();
                Manager manager = new Manager();
                manager.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Bạn không có quyền truy cập");
            }


        }
    }
}
