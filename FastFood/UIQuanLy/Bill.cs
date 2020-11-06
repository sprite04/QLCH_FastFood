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
        BLSanPham blSP = new BLSanPham();
        List<CHITIET_HD> dsCT = new List<CHITIET_HD>();
        List<SANPHAM> dsSP = new List<SANPHAM>();

        private void LoadCT(HOADON hd)
        {
            
        }

        private void LoadData()
        {
            
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
            if (rowselect >= 0 && rowselect < dgvHoaDon.Rows.Count - 1)
            {
                for (int i = 0; i < dsHD.Count; i++)
                {
                    if (dsHD[i].MaHD.ToString() == dgvHoaDon.Rows[rowselect].Cells[0].Value.ToString())
                    {
                        dgvSanPham.Visible = true;
                        LoadCT(dsHD[i]);
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
