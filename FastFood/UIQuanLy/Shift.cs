using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastFood.BLL;
using System.Data.SqlClient;

namespace FastFood.UIQuanLy
{
    public partial class Shift : UserControl
    {
        public Shift()
        {
            InitializeComponent();
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {

        }

        BLCa blCa;
        private void Shift_Load(object sender, EventArgs e)
        {
            LoadData1();
        }

        RadioButton[] mangCa;
        List<sp_CaResult> dsCaNgay;
        private void LoadData1()
        {
            btnSave.Visible = false;
            flpDiemDanh.Visible = false;
            blCa = new BLCa();
            dsCaNgay=blCa.dsCaNgay();
            mangCa = new RadioButton[dsCaNgay.Count];
            for(int i=0; i<dsCaNgay.Count;i++)
            {
                mangCa[i] = new RadioButton();
                mangCa[i].Size = new System.Drawing.Size(212, 40);
                mangCa[i].Location = new System.Drawing.Point(3, 3+i*40);
                mangCa[i].Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
                if (dsCaNgay[i].MaCa.Hour == 7)
                {
                    mangCa[i].Text = "Ca Sáng";
                    mangCa[i].Tag = 7;
                }
                else if (dsCaNgay[i].MaCa.Hour == 12)
                {
                    mangCa[i].Text = "Ca Trưa";
                    mangCa[i].Tag = 12;
                }
                else if (dsCaNgay[i].MaCa.Hour == 17)
                {
                    mangCa[i].Text = "Ca Chiều";
                    mangCa[i].Tag = 17;
                }
            }
            for(int i=0; i<dsCaNgay.Count;i++)
            {
                mangCa[i].Click += Shift_Click;
                flpCa.Controls.Add(mangCa[i]);
                
            }    

        }


        CheckBox[] danhsach;
        BLDiemDanh blDD;
        BLNhanVien blNV;
        List<sp_DiemDanhResult> dsDD;
        List<NHANVIEN> dsNV;
        List<v_ShiftAndEmployee> dsNVandDD;
        private void Shift_Click(object sender, EventArgs e)
        {
            lbThongBao.Text = "";
            flpDiemDanh.Visible = true;
            flpDiemDanh.Controls.Clear();
            btnSave.Visible = true;
            blNV = new BLNhanVien();
            blDD = new BLDiemDanh();
            dsDD = blDD.dsDiemDanhNgay();
            dsNV = blNV.dsNhanVien();
            if (dsNV.Count > 0)
            {
                RadioButton rb = sender as RadioButton;
                gbCa.Text = DateTime.Now.ToString("dd-MMM-yyyy") + "   " + rb.Text;
                danhsach = new CheckBox[dsNV.Count];
                for (int i = 0; i < dsNV.Count; i++)
                {
                    var ds = (from dd in dsDD
                              where dd.MaNV == dsNV[i].MaNV && dd.MaCa.Hour == (int)rb.Tag
                              select dd.MaNV).ToList();
                    if (ds.Count > 0)
                    {
                        danhsach[i] = new CheckBox();
                        danhsach[i].Text = dsNV[i].MaNV + " " + dsNV[i].HoTen;
                        danhsach[i].Tag = dsNV[i].MaNV;
                        danhsach[i].AutoSize = true;
                        danhsach[i].Checked = true;
                        danhsach[i].Padding = new System.Windows.Forms.Padding(30, 20, 20, 0);
                    }
                    else
                    {
                        danhsach[i] = new CheckBox();
                        danhsach[i].Text = dsNV[i].MaNV + "   " + dsNV[i].HoTen;
                        danhsach[i].Tag = dsNV[i].MaNV;
                        danhsach[i].AutoSize = true;
                        danhsach[i].Padding = new System.Windows.Forms.Padding(30, 20, 20, 0);
                    }
                    danhsach[i].CheckedChanged += Shift_CheckedChanged;
                    flpDiemDanh.Controls.Add(danhsach[i]);
                }
            }
        }

        private void Shift_CheckedChanged(object sender, EventArgs e)
        {
            lbThongBao.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int vt = -1;
            for(int i=0; i< dsCaNgay.Count; i++)
            {
                if (mangCa[i].Checked == true)
                    vt = i;
            }
            if((int)mangCa[vt].Tag==7 && DateTime.Now.Hour>=7 && DateTime.Now.Hour<12)
            {
                string message;
                DateTime dt = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 7, 0, 0);
                bool result=blDD.Delete(dt, out message);
                if(result==false)
                {
                    lbThongBao.Text = message;
                    return;
                }
                for (int i=0; i<dsNV.Count; i++)
                {
                    if (danhsach[i].Checked == true)
                    {
                        result = blDD.Insert(dt, (int)danhsach[i].Tag, out message);
                        if (result == false)
                        {
                            lbThongBao.Text = message;
                            return;
                        }
                    }
                }
                lbThongBao.Text = "Thực hiện thành công";
            }
            else if ((int)mangCa[vt].Tag == 12 && DateTime.Now.Hour >= 12 && DateTime.Now.Hour < 17)
            {
                string message;
                DateTime dt = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 12, 0, 0);
                bool result = blDD.Delete(dt, out message);
                if (result == false)
                {
                    lbThongBao.Text = message;
                    return;
                }
                for (int i = 0; i < dsNV.Count; i++)
                {
                    if (danhsach[i].Checked == true)
                    {
                        result = blDD.Insert(dt, (int)danhsach[i].Tag, out message);
                        if (result == false)
                        {
                            lbThongBao.Text = message;
                            return;
                        }
                    }
                }
                lbThongBao.Text = "Thực hiện thành công";
            }
            else if ((int)mangCa[vt].Tag == 17 && DateTime.Now.Hour >= 17 && DateTime.Now.Hour < 22)
            {
                string message;
                DateTime dt = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 17, 0, 0);
                bool result = blDD.Delete(dt, out message);
                if (result == false)
                {
                    MessageBox.Show(message);
                    return;
                }
                for (int i = 0; i < dsNV.Count; i++)
                {
                    if (danhsach[i].Checked == true)
                    {
                        result = blDD.Insert(dt, (int)danhsach[i].Tag, out message);
                        if (result == false)
                        {
                            lbThongBao.Text = message;
                            return;
                        }
                    }
                }
                lbThongBao.Text = "Thực hiện thành công";
            }
            else
            {
                lbThongBao.Text = "Ngoài thời gian điểm danh của ca này";
                
            }    
        }

        private void tabMenu_Click(object sender, EventArgs e)
        {
            lbThongBao.Text = "";
            if (tabMenu.SelectedIndex == 1)
            {
                LoadSearchNameData();
            }
            if (tabMenu.SelectedIndex == 2)
            {
                LoadSearchDateData();
            }
        }


        private void LoadSearchNameData()
        {
            blDD = new BLDiemDanh();
            dsNVandDD = blDD.dsVShiftAndEmployee();
            dgvNhanVien.Rows.Clear();
            for (int i = 0; i < dsNVandDD.Count; i++)
            {
                dgvNhanVien.Rows.Add(dsNVandDD[i].MaNV,dsNVandDD[i].HoTen, dsNVandDD[i].MaCa.ToString("dd/MM/yyy"), dsNVandDD[i].MaCa.TimeOfDay);
            }
        }

        private void LoadSearchDateData()
        {
            blDD = new BLDiemDanh();
            dsNVandDD = blDD.dsVShiftAndEmployee();
            dgvSearchDate.Rows.Clear();
            for (int i = 0; i < dsNVandDD.Count; i++)
            {
                if (dsNVandDD[i].GT == true)
                    dgvSearchDate.Rows.Add(dsNVandDD[i].MaNV, dsNVandDD[i].HoTen, dsNVandDD[i].TenCV, "Nữ", dsNVandDD[i].CMND, dsNVandDD[i].SDT);
                else
                    dgvSearchDate.Rows.Add(dsNVandDD[i].MaNV, dsNVandDD[i].HoTen, dsNVandDD[i].TenCV, "Nam", dsNVandDD[i].CMND, dsNVandDD[i].SDT);
            }
        }

        private void txtFind_TextChanged_1(object sender, EventArgs e)
        {
            if (txtFind.Text == "")
                LoadSearchNameData();
            else
            {
                LoadSearchNameData();
                dgvNhanVien.Rows.Clear();
                for (int i = 0; i < dsNVandDD.Count; i++)
                {
                    if (dsNVandDD[i].HoTen.ToLower().Contains(txtFind.Text.ToLower()))
                        dgvNhanVien.Rows.Add(dsNVandDD[i].MaNV, dsNVandDD[i].HoTen, dsNVandDD[i].MaCa.ToString("dd/MM/yyy"), dsNVandDD[i].MaCa.TimeOfDay);
                }
            }
        }

        private void dtpFind_ValueChanged(object sender, EventArgs e)
        {
            dgvSearchDate.Rows.Clear();
            for (int i = 0; i < dsNVandDD.Count; i++)
            {
                DateTime dt = DateTime.Parse(dsNVandDD[i].MaCa.ToString());
                if (dt.Day == dtpFind.Value.Day && dt.Month == dtpFind.Value.Month && dt.Year == dtpFind.Value.Year)
                    if (dsNVandDD[i].GT == true)
                        dgvSearchDate.Rows.Add(dsNVandDD[i].MaNV, dsNVandDD[i].HoTen, dsNVandDD[i].TenCV, "Nữ", dsNVandDD[i].CMND, dsNVandDD[i].SDT);
                    else
                        dgvSearchDate.Rows.Add(dsNVandDD[i].MaNV, dsNVandDD[i].HoTen, dsNVandDD[i].TenCV, "Nam", dsNVandDD[i].CMND, dsNVandDD[i].SDT);
            }
        }
    }
}
