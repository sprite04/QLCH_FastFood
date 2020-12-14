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
    public partial class Material : UserControl
    {

        public Material()
        {
            InitializeComponent();
        }


        BLNguyenLieu blNL;
        List<v_NguyenLieu> dsNL;
        private void Products_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            blNL = new BLNguyenLieu();
            dsNL = blNL.dsVNguyenLieu();
            dgvNguyenLieu.Rows.Clear();
            for (int i = 0; i < dsNL.Count; i++)
            {
                dgvNguyenLieu.Rows.Add(dsNL[i].MaNL, dsNL[i].TenNL, dsNL[i].GiaNL, dsNL[i].SLTonKho);
            }
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            if (txtFind.Text == "")
                LoadData();
            else
            {
                dgvNguyenLieu.Rows.Clear();
                for (int i = 0; i < dsNL.Count; i++)
                {
                    if (dsNL[i].TenNL.ToLower().Contains(txtFind.Text.ToLower()))
                        dgvNguyenLieu.Rows.Add(dsNL[i].MaNL, dsNL[i].TenNL, dsNL[i].GiaNL, dsNL[i].SLTonKho);
                }
            }
        }

        int rowselect = 0;

        private void dgvNguyenLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowselect = e.RowIndex;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvNguyenLieu.SelectedRows.Count > 0)
            {
                if (rowselect == -1 || rowselect >= dsNL.Count)
                    return;
                int vt = 0;
                for (int i = 0; i < dsNL.Count; i++)
                {
                    if (dsNL[i].MaNL == (int)(dgvNguyenLieu.Rows[rowselect].Cells[0].Value))
                    {
                        vt = i;
                        break;
                    }
                }
                DataGridViewRow row = dgvNguyenLieu.Rows[vt];
                int Ma = int.Parse(row.Cells[0].Value.ToString());
                v_NguyenLieu nl = new v_NguyenLieu();
                nl=dsNL.Find(x => x.MaNL == Ma);
                DetailMaterial detail = new DetailMaterial(nl);
                var result = detail.ShowDialog();
                LoadData();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DetailMaterial detail = new DetailMaterial(true);
            var result = detail.ShowDialog();
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvNguyenLieu.SelectedRows.Count > 0)
            {
                if (rowselect == -1 || rowselect >= dsNL.Count)
                    return;
                int vt = 0;
                for (int i = 0; i < dsNL.Count; i++)
                {
                    if (dsNL[i].MaNL == (int)(dgvNguyenLieu.Rows[rowselect].Cells[0].Value))
                    {
                        vt = i;
                        break;
                    }
                }
                DialogResult dialog = MessageBox.Show("Bạn có muốn xoá không?", "Xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    NGUYENLIEU NL = new NGUYENLIEU()
                    {
                        MaNL = dsNL[vt].MaNL,
                        TenNL = dsNL[vt].TenNL,
                        GiaNL = dsNL[vt].GiaNL,
                        SLTonKho = dsNL[vt].SLTonKho,
                        DonVi = dsNL[vt].DonVi,
                        TT_Ban = false
                    };
                    string message;
                    bool result = blNL.Update(NL, out message);
                    if (result == false)
                        MessageBox.Show(message);
                    LoadData();
                }
            }
        }

        
    }
}
