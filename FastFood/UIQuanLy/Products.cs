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
    public partial class Products : UserControl
    {
        public Products()
        {
            InitializeComponent();
        }

        public List<v_SanPham> dsSP;
        private void Products_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            QLBH_FastFoodDataContext context = new QLBH_FastFoodDataContext();
            dsSP = context.v_SanPhams.ToList();
            for (int i = 0; i < dsSP.Count; i++)
            {
                dgvSanPham.Rows.Add(dsSP[i].MaSP, dsSP[i].TenSP, dsSP[i].GiaGoc, dsSP[i].GiaBan);
            }
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            if (txtFind.Text == "")
                LoadData();
            else
            {
                dgvSanPham.Rows.Clear();
                for (int i = 0; i < dsSP.Count; i++)
                {
                    if (dsSP[i].TenSP.ToLower().Contains(txtFind.Text.ToLower()) )
                        dgvSanPham.Rows.Add(dsSP[i].MaSP, dsSP[i].TenSP, dsSP[i].GiaGoc, dsSP[i].GiaBan);
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
                if (rowselect == -1 || rowselect >= dsSP.Count)
                    return;
                int vt = 0;
                for (int i = 0; i < dsSP.Count; i++)
                {
                    if (dsSP[i].MaSP == (int)(dgvSanPham.Rows[rowselect].Cells[0].Value))
                    {
                        vt = i;
                        break;
                    }
                }
                DataGridViewRow row = dgvSanPham.Rows[vt];
                int Ma = int.Parse(row.Cells[0].Value.ToString());
                //DetailProduct detail = new DetailProduct(Ma);
                //var result = detail.ShowDialog();
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
                if (rowselect == -1 || rowselect >= dsSP.Count)
                    return;
                int vt = 0;
                for (int i = 0; i < dsSP.Count; i++)
                {
                    if (dsSP[i].MaSP == (int)(dgvSanPham.Rows[rowselect].Cells[0].Value))
                    {
                        vt = i;
                        break;
                    }
                }
                DialogResult dialog = MessageBox.Show("Bạn có muốn xoá không?", "Xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    string message;
                    //dsSP[vt].TT_Ban = false;
                    //bool result = blSP.Delete(dsSP[vt], out message);
                    //if (result == false)
                    //    MessageBox.Show(message);
                    LoadData();
                }
            }
        }
    }
}
