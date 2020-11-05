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
    public partial class Employee : UserControl
    {
        public Employee(Login l)
        {
            InitializeComponent();
            login = l;
        }
        Login login = new Login();
        List<v_NhanVien> dsVNV = new List<v_NhanVien>();
        List<NHANVIEN> dsNV = new List<NHANVIEN>();
        private void Employee_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        BLNhanVien blNV;
        private void LoadData()
        {
            blNV = new BLNhanVien();
            dsNV = blNV.dsNhanVien();
            dsVNV = blNV.dsVNhanVien();

            dgvNhanVien.Rows.Clear();
            for (int i = 0; i < dsVNV.Count; i++)
            {
                dgvNhanVien.Rows.Add(dsVNV[i].MaNV,dsVNV[i].HoTen,dsVNV[i].TenCV,dsVNV[i].GT,dsVNV[i].CMND,dsVNV[i].SDT);
            }
        }

        private int QuanLi()
        {
            for (int i = 0; i < dsVNV.Count; i++)
            {
                if (login.MaNV == dsVNV[i].MaNV)
                    return dsVNV[i].MaCV;
            }
            return -1;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count > 0)
            {
                if (rowselect >=0 && rowselect <dsVNV.Count)
                {
                    DataGridViewRow row = dgvNhanVien.Rows[rowselect];
                    int Ma = (int)row.Cells[0].Value;
                    NHANVIEN nv = dsNV.Find(x => x.MaNV == Ma);

                    if ((nv.MaCV < QuanLi() && QuanLi() == 3) || QuanLi() == 4 || login.MaNV == nv.MaNV)
                    {
                        bool kind = (QuanLi() == 4);
                        bool pass = (login.MaNV == nv.MaNV);
                        DetailEmployee detail = new DetailEmployee(pass,kind, nv);
                        var result = detail.ShowDialog();
                    }
                    else
                        MessageBox.Show("Bạn không có quyền hạn chỉnh sửa thông tin người này", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    LoadData();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (rowselect >= 0 && rowselect < dsVNV.Count && QuanLi() != 4)
            {
                MessageBox.Show("Bạn có quyền hạn thêm nhân viên", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (QuanLi() == 4)
            {
                DetailEmployee detail = new DetailEmployee(true);
                var result = detail.ShowDialog();
                LoadData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (dgvNhanVien.SelectedRows.Count > 0)
            {
                if (rowselect >=0 && rowselect <dsVNV.Count && QuanLi() != 4)
                {
                    MessageBox.Show("Bạn có quyền hạn xoá thông tin người này", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if(rowselect >= 0 && rowselect < dsVNV.Count)
                {
                    int vt = 0;
                    for (int i = 0; i < dsVNV.Count; i++)
                    {
                        if (dsVNV[i].MaNV == (int)(dgvNhanVien.Rows[rowselect].Cells[0].Value))
                        {
                            vt = i;
                            break;
                        }
                    }
                    string message;
                    NHANVIEN nv = dsNV.Find(x => x.MaNV == dsVNV[vt].MaNV);
                    nv.TT_Lam = false;
                    if (QuanLi() == 4)
                    {
                        DialogResult dialog = MessageBox.Show("Bạn có muốn xoá không?", "Xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialog == DialogResult.Yes)
                        {
                            bool result = blNV.Update(nv, out message);
                            if (result == false)
                                MessageBox.Show(message);
                            LoadData();
                        }
                    }
                }    
            }
        }

        int rowselect = 0;
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowselect = e.RowIndex;
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            if (txtFind.Text == "")
                LoadData();
            else
            {
                dgvNhanVien.Rows.Clear();
                for (int i = 0; i < dsVNV.Count; i++)
                {
                    if (dsVNV[i].HoTen.ToLower().Contains(txtFind.Text.ToLower()))
                        dgvNhanVien.Rows.Add(dsVNV[i].MaNV, dsVNV[i].HoTen, dsVNV[i].TenCV, dsVNV[i].GT, dsVNV[i].CMND, dsVNV[i].SDT);
                }

            }
        }

        
    }
}
