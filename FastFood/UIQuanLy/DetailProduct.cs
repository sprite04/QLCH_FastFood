using FastFood.BLL;
using FastFood.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFood
{
    public partial class DetailProduct : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        SANPHAM sp = new SANPHAM();
        bool Them = false;
        BLSanPham blSP;
        BLNguyenLieu blNL;
        List<SANPHAM> dsSP;
        List<NGUYENLIEU> dsNL;
        
        public DetailProduct()
        {
            InitializeComponent();
        }
        public DetailProduct(bool them)
        {
            InitializeComponent();
            Them = them;
        }
        public DetailProduct(SANPHAM s)
        {
            InitializeComponent();
            sp = s;
        }

        public Image ConvertImage(byte[] b)
        {
            MemoryStream ms = new MemoryStream(b, 0, b.Length);
            ms.Write(b, 0, b.Length);
            return Image.FromStream(ms, true);
        }

        public byte[] ImageByte(Image image)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(image, typeof(byte[]));
        }
        private void DetailProduct_Load(object sender, EventArgs e)
        {
            blSP = new BLSanPham();
            blNL = new BLNguyenLieu();
            dsNL = blNL.dsNguyenLieu();
            dsSP = blSP.dsSanPham();
            cbNguyenLieu.BeginUpdate();
            dsNL.ForEach(x => cbNguyenLieu.Items.Add(x.TenNL));
            cbNguyenLieu.EndUpdate();
            if (Them == true)
                lblName.Text = "ADD";
            else
            {
                v_SanPham vsp = blSP.dsVSanPham().Find(x => x.MaSP == sp.MaSP);
                lblName.Text = "EDIT";
                txtTenSP.Text = sp.TenSP;
                txtGiaBan.Text = vsp.GiaBan.ToString();
                txtGiaGoc.Text = vsp.GiaGoc.ToString();
                picSP.BackgroundImage = ConvertImage((byte[])sp.HinhSP.ToArray());
                pnKind.Visible = false;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnTieuDe_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void picSP_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*.jpg)|*.jpg|(*.png)|*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picSP.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            float Num;
            bool k = float.TryParse(txtLoiNhuan.Text, out Num);
            if (k == false)
            {
                errorProvider1.SetError(pnLoiNhuan, "Lợi nhuận không hợp lệ");
                return;
            }
            k = float.TryParse(txtGiamGia.Text, out Num);
            if (k == false)
            {
                errorProvider1.SetError(pnGiamGia, "Giảm giá không hợp lệ");
                return;
            }
            if (Them == true)
            {
                if (cbKind.SelectedIndex >= 0)
                {
                    int value = 0;
                    if (cbKind.SelectedItem.ToString() == "Burger")
                    {
                        value = (from sp in dsSP
                                 where sp.MaSP >= 100 && sp.MaSP < 200
                                 select sp.MaSP).ToList().Max();
                    }
                    else if (cbKind.SelectedItem.ToString() == "Chicken")
                    {
                        value = (from sp in dsSP
                                 where sp.MaSP >= 200 && sp.MaSP < 300
                                 select sp.MaSP).ToList().Max();
                    }
                    else if (cbKind.SelectedItem.ToString() == "Chicken Set")
                    {
                        value = (from sp in dsSP
                                 where sp.MaSP >= 300 && sp.MaSP < 400
                                 select sp.MaSP).ToList().Max();
                    }
                    else if (cbKind.SelectedItem.ToString() == "Combo")
                    {
                        value = (from sp in dsSP
                                 where sp.MaSP >= 400 && sp.MaSP < 500
                                 select sp.MaSP).ToList().Max();
                    }
                    else if (cbKind.SelectedItem.ToString() == "Value")
                    {
                        value = (from sp in dsSP
                                 where sp.MaSP >= 500 && sp.MaSP < 600
                                 select sp.MaSP).ToList().Max();
                    }
                    else if (cbKind.SelectedItem.ToString() == "Set")
                    {
                        value = (from sp in dsSP
                                 where sp.MaSP >= 600 && sp.MaSP < 700
                                 select sp.MaSP).ToList().Max();
                    }
                    else if (cbKind.SelectedItem.ToString() == "Dessert")
                    {
                        value = (from sp in dsSP
                                 where sp.MaSP >= 700 && sp.MaSP < 800
                                 select sp.MaSP).ToList().Max();
                    }
                    else
                    {
                        value = (from sp in dsSP
                                 where sp.MaSP >= 800
                                 select sp.MaSP).ToList().Max();
                    }
                    SANPHAM SP = new SANPHAM()
                    {
                        MaSP = value + 1,
                        HinhSP = new System.Data.Linq.Binary(ImageByte(picSP.BackgroundImage)),
                        TenSP = txtTenSP.Text,
                        TT_Ban = true,
                        TT_Con=true,
                        LoiNhuan=float.Parse(txtLoiNhuan.Text),
                        GiamGia=float.Parse(txtGiamGia.Text)
                    };

                    string message;
                    bool result = blSP.Insert(SP, out message);
                    if (result == false)
                        MessageBox.Show(message);
                    this.Close();
                }
            }
            else
            {
                SANPHAM SP = new SANPHAM()
                {
                    MaSP = sp.MaSP,
                    HinhSP = new System.Data.Linq.Binary(ImageByte(picSP.BackgroundImage)),
                    TenSP = txtTenSP.Text,
                    TT_Ban = true,
                    TT_Con = true,
                    LoiNhuan = float.Parse(txtLoiNhuan.Text),
                    GiamGia = float.Parse(txtGiamGia.Text)
                };
                string message;
                bool result = blSP.Update(SP, out message);
                if (result == false)
                    MessageBox.Show(message);
                this.Close();
            }
        }

        List<NguyenLieuDGV> dsDGV = new List<NguyenLieuDGV>();
        private void LoadData()
        {
            int GiaGoc = 0;
            dgvNguyenLieu.Rows.Clear();
            if(dsDGV.Count>0)
            {
                for (int i = 0; i < dsDGV.Count; i++)
                {
                    dgvNguyenLieu.Rows.Add(dsDGV[i].MaNL, dsDGV[i].TenNL, dsDGV[i].GiaNL, dsDGV[i].SL);
                    GiaGoc += dsDGV[i].SL * dsDGV[i].GiaNL;
                }
                txtGiaGoc.Text = GiaGoc.ToString();
                errorProvider1.Clear();
                float Num;
                bool k = float.TryParse(txtLoiNhuan.Text, out Num);
                if (k == false)
                {
                    errorProvider1.SetError(pnLoiNhuan, "Lợi nhuận không hợp lệ");
                    return;
                }
                k = float.TryParse(txtGiamGia.Text, out Num);
                if (k == false)
                {
                    errorProvider1.SetError(pnGiamGia, "Giảm giá không hợp lệ");
                    return;
                }
                txtGiaBan.Text = (GiaGoc * (float.Parse(txtLoiNhuan.Text) - float.Parse(txtGiamGia.Text))).ToString();
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(cbNguyenLieu.SelectedIndex>=0 && numNguyenLieu.Value>0)
            {
                string TenNL = cbNguyenLieu.SelectedItem.ToString();
                if(dsDGV.Count==0)
                {
                    for (int j = 0; j < dsNL.Count; j++)
                    {
                        if (dsNL[j].TenNL == TenNL)
                        {
                            dsDGV.Add(new NguyenLieuDGV()
                            {
                                MaNL = dsNL[j].MaNL,
                                TenNL = dsNL[j].TenNL,
                                GiaNL = int.Parse(dsNL[j].GiaNL.ToString()),
                                SL = int.Parse(numNguyenLieu.Value.ToString())
                            });
                            LoadData();
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < dsDGV.Count; i++)
                    {
                        if (dsDGV[i].TenNL == TenNL)
                        {
                            dsDGV[i].SL = int.Parse(numNguyenLieu.Value.ToString());
                            LoadData();
                            return;
                        }
                    }
                    for (int j = 0; j < dsNL.Count; j++)
                    {
                        if (dsNL[j].TenNL == TenNL)
                        {
                            dsDGV.Add(new NguyenLieuDGV()
                            {
                                MaNL = dsNL[j].MaNL,
                                TenNL = dsNL[j].TenNL,
                                GiaNL = int.Parse(dsNL[j].GiaNL.ToString()),
                                SL = int.Parse(numNguyenLieu.Value.ToString())
                            });
                            LoadData();
                        }
                    }
                }       
            }    
        }

        int rowselect = -1;
        private void dgvNguyenLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowselect = e.RowIndex;
            if (rowselect >= 0 && rowselect < dsDGV.Count)
            {
                for (int i = 0; i < cbNguyenLieu.Items.Count; i++)
                    if (cbNguyenLieu.Items[i].ToString() == dgvNguyenLieu.Rows[rowselect].Cells[1].Value.ToString())
                    {
                        cbNguyenLieu.SelectedIndex = i;
                        numNguyenLieu.Value = int.Parse(dgvNguyenLieu.Rows[rowselect].Cells[3].Value.ToString());
                    }
            }
        }


        private void txtLoiNhuan_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtGiamGia_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
