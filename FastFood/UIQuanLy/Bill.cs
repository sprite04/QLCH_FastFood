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

namespace FastFood.UIQuanLy
{
    public partial class Bill : UserControl
    {
        public Bill()
        {
            InitializeComponent();
        }

        BLHoaDon blHD;
        List<HOADON> dsHD = new List<HOADON>();
        List<v_HoaDon> dsVHD;
        BLSanPham blSP = new BLSanPham();
        BLChiTietHD blCT = new BLChiTietHD();
        List<sp_ChiTietDGVResult> dsVCT;

        private void LoadCT(v_HoaDon hd)
        {
            blCT = new BLChiTietHD();
            dsVCT = blCT.dsChiTietHDDGV(hd);
            dgvSanPham.Rows.Clear();
            lblMa.Visible = true;
            labelMa.Visible = true;
            lblMa.Text = hd.MaHD.ToString();
            for (int i = 0; i < dsVCT.Count; i++)
            {
                dgvSanPham.Rows.Add(dsVCT[i].MaSP,dsVCT[i].TenSP, dsVCT[i].SL);
            }
        }

        private void LoadData()
        {
            blHD = new BLHoaDon();
            dsVHD = blHD.dsVHoaDon();
            dgvHoaDon.Rows.Clear();
            for (int i = 0; i < dsVHD.Count; i++)
            {
                dgvHoaDon.Rows.Add(dsVHD[i].MaHD, dsVHD[i].TongTien, dsVHD[i].TongGiaSP, dsVHD[i].Ngay);
            }
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }

        int rowselect = 0;
        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowselect = e.RowIndex;
            if (rowselect >= 0 && rowselect < dsVHD.Count)
            {
                for (int i = 0; i < dsVHD.Count; i++)
                {
                    if (dsHD[i].MaHD.ToString() == dgvHoaDon.Rows[rowselect].Cells[0].Value.ToString())
                    {
                        dgvSanPham.Visible = true;
                        LoadCT(dsVHD[i]);
                    }
                }
            }
        }

        private void dtpFind_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void lblBill_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
