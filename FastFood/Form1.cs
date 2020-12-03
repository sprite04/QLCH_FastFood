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
namespace FastFood
{
    public partial class Form1 : Form
    {
        SqlConnection sqlConnection;
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
        }
        public Form1(SqlConnection connection)
        {
            InitializeComponent();
            blNV = new BLNhanVien();
            dsNV = blNV.dsNhanVien();
            sqlConnection = connection;
            string arrListStr = Get_ID(connection);
            string connect = sqlConnection.ConnectionString;
            if (connect.Contains("employee"))
            {
                btnManager.Enabled = false;
                btnManager.Visible = false;

            }
            else
            {
                btnManager.Enabled = true;
                btnManager.Visible = true;
            }
            NHANVIEN nv = dsNV.Find(x => x.MaNV == getNumber(arrListStr));
            txtInfo.Text = (string.Format("{0}", nv.HoTen));
        }
        private int getNumber(string input)
        {
            try
            {
                string id_s = input.Substring(input.Length - 3);
                int id = int.Parse(id_s);
                return id;
            }
            catch
            {
                return 0;
            }

        }
        public Form1(Login l, SqlConnection connection)
        {

            InitializeComponent();
            sqlConnection = connection;
            string arrListStr = Get_ID(connection);
            string connect = sqlConnection.ConnectionString;
            if (connect.Contains("employee"))
            {
                btnManager.Enabled = false;
                btnManager.Visible = false;

            }
            else
            {
                btnManager.Enabled = true;
                btnManager.Visible = true;
            }

            txtInfo.Text = (string.Format("{0}", getNumber(arrListStr)));
        }

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
        Home home = new Home();
        Menu monan = new Menu();
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
            btnHome.PerformClick();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnManager.Height;
            SidePanel.Top = btnManager.Top;
            pnShow.Controls.Clear();
            Manager manager = new Manager(sqlConnection);
            manager.ShowDialog();

        }
    }
}
