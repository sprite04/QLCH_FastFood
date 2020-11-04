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

namespace FastFood
{
    public partial class Products : UserControl
    {
        public Products()
        {
            InitializeComponent();
        }

        BLSanPham blSP;
        public List<v_SanPham> dsVSP;
        public List<SANPHAM> dsSP;
        private void Products_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            blSP = new BLSanPham();
            dsVSP = blSP.dsVSanPham();
            dgvSanPham.Rows.Clear();
            for (int i = 0; i < dsVSP.Count; i++)
            {
                dgvSanPham.Rows.Add(dsVSP[i].MaSP, dsVSP[i].TenSP, dsVSP[i].GiaGoc, dsVSP[i].GiaBan);
            }
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            if (txtFind.Text == "")
                LoadData();
            else
            {
                dgvSanPham.Rows.Clear();
                for (int i = 0; i < dsVSP.Count; i++)
                {
                    if (dsVSP[i].TenSP.ToLower().Contains(txtFind.Text.ToLower()) )
                        dgvSanPham.Rows.Add(dsVSP[i].MaSP, dsVSP[i].TenSP, dsVSP[i].GiaGoc, dsVSP[i].GiaBan);
                }
            }
        }

        int rowselect = 0;

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowselect = e.RowIndex;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.SelectedRows.Count > 0)
            {
                if (rowselect == -1 || rowselect >= dsVSP.Count)
                    return;
                int vt = 0;
                for (int i = 0; i < dsVSP.Count; i++)
                {
                    if (dsVSP[i].MaSP == (int)(dgvSanPham.Rows[rowselect].Cells[0].Value))
                    {
                        vt = i;
                        break;
                    }
                }
                DataGridViewRow row = dgvSanPham.Rows[vt];
                int Ma = int.Parse(row.Cells[0].Value.ToString());
                DetailProduct detail = new DetailProduct(Ma);
                var result = detail.ShowDialog();
                LoadData();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DetailProduct detail = new DetailProduct(true);
            var result = detail.ShowDialog();
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.SelectedRows.Count > 0)
            {
                if (rowselect == -1 || rowselect >= dsVSP.Count)
                    return;
                int vt = 0;
                for (int i = 0; i < dsVSP.Count; i++)
                {
                    if (dsVSP[i].MaSP == (int)(dgvSanPham.Rows[rowselect].Cells[0].Value))
                    {
                        vt = i;
                        break;
                    }
                }
                DialogResult dialog = MessageBox.Show("Bạn có muốn xoá không?", "Xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    dsSP = blSP.dsSanPham();
                    string message;
                    for(int i=0; i<dsSP.Count; i++)
                        if(dsSP[i].MaSP==dsVSP[vt].MaSP)
                        {
                            dsSP[i].TT_Ban = false;
                            bool result = blSP.Update(dsSP[i], out message);
                            if (result == false)
                            {
                                MessageBox.Show(message);
                                return;
                            }
                        }
                    LoadData();
                }
            }
        }
    }
}
