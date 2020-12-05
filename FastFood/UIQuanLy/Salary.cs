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

namespace FastFood.UIQuanLy
{
    public partial class Salary : UserControl
    {
        SqlConnection conn;
        BLLuong BLLuong;
        List<st_LUONGResult> dsvLuong = new List<st_LUONGResult>();
        List<NHANVIEN> dsNV = new List<NHANVIEN>();
        
        public Salary()
        {
            InitializeComponent();
        }
        public Salary(SqlConnection conn)
        {
            InitializeComponent();
            dtpFind.Value = DateTime.Now;
            
            this.conn = conn;
            dtpFind.Format = DateTimePickerFormat.Custom;
            dtpFind.CustomFormat = "MMMM yyyy";
            //dtpFind.ShowUpDown = true;
        }
        private void LoadData(int Nam, int Thang)
        {
            BLLuong = new BLLuong();
            dsvLuong = BLLuong.dsVLuong(Nam,Thang);

            dgvNhanVien.Rows.Clear();
            for (int i = 0; i < dsvLuong.Count; i++)
            {
                if (dsvLuong[i].GT == true)
                    dgvNhanVien.Rows.Add(dsvLuong[i].MaNV, dsvLuong[i].HoTen, dsvLuong[i].TenCV, "Nữ", dsvLuong[i].CMND, dsvLuong[i].SoGioLamViec, dsvLuong[i].Luong,dsvLuong[i].Thang,dsvLuong[i].Nam);
                else
                    dgvNhanVien.Rows.Add(dsvLuong[i].MaNV, dsvLuong[i].HoTen, dsvLuong[i].TenCV, "Nam", dsvLuong[i].CMND, dsvLuong[i].SoGioLamViec, dsvLuong[i].Luong, dsvLuong[i].Thang, dsvLuong[i].Nam);
            }
        }

        private void Salary_Load(object sender, EventArgs e)
        {
            this.LoadData(dtpFind.Value.Year,dtpFind.Value.Month);
        }

        private void dtpFind_ValueChanged(object sender, EventArgs e)
        {
            this.LoadData(dtpFind.Value.Year, dtpFind.Value.Month);
            if (BLLuong.CheckLuong(dtpFind.Value.Year, dtpFind.Value.Month)==1)
                btn_TraLuong.Enabled = true;
            else
                btn_TraLuong.Enabled = false;
        }

        private void btn_TraLuong_Click(object sender, EventArgs e)
        {
            
        }
    }
}
