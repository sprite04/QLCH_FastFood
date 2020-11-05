using FastFood.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFood.UIQuanLy
{
    public partial class DetailMaterial : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public DetailMaterial(bool them)
        {
            InitializeComponent();
            Them = them;
        }

        public DetailMaterial(v_NguyenLieu n)
        {
            InitializeComponent();
            nl = n;
        }

        v_NguyenLieu nl = new v_NguyenLieu();
        bool Them = false;
        BLNguyenLieu blNL = new BLNguyenLieu();
        List<v_NguyenLieu> dsNL = new List<v_NguyenLieu>();

        private void DetailProduct_Load(object sender, EventArgs e)
        {
            dsNL = blNL.dsVNguyenLieu();
            if (Them == true)
                lblName.Text = "ADD";
            else
            {
                lblName.Text = "EDIT";
                txtTenNL.Text = nl.TenNL;
                txtSL.Text = nl.SLTonKho.ToString();
                txtGiaNL.Text = nl.GiaNL.ToString();
                txtDonVi.Text = nl.DonVi;
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


        private void btnSave_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            int Num;
            bool k = int.TryParse(txtSL.Text, out Num);
            if (k == false)
            {
                errorProvider1.SetError(txtSL, "Số lượng nguyên liệu không hợp lệ");
                return;
            }
            k = int.TryParse(txtGiaNL.Text, out Num);
            if (k == false)
            {
                errorProvider1.SetError(txtGiaNL, "Giá nguyên liệu không hợp lệ");
                return;
            }
            if (Them == true)
            {
                int value = 0;
                var ds = (from nl in blNL.dsNguyenLieu()
                              select nl.MaNL).ToList();
                if (ds.Count > 0)
                    value = ds.Max();
                NGUYENLIEU NL = new NGUYENLIEU()
                {
                    MaNL=value+1,
                    TenNL=txtTenNL.Text,
                    GiaNL=int.Parse(txtGiaNL.Text),
                    SLTonKho=int.Parse(txtSL.Text),
                    DonVi=txtDonVi.Text,
                    TT_Ban=true
                };

                string message;
                bool result = blNL.Insert(NL, out message);
                if (result == false)
                    MessageBox.Show(message);
                this.Close();
            }
            else
            {
                NGUYENLIEU NL = new NGUYENLIEU()
                {
                    MaNL = nl.MaNL,
                    TenNL = txtTenNL.Text,
                    GiaNL = int.Parse(txtGiaNL.Text),
                    SLTonKho = int.Parse(txtSL.Text),
                    DonVi = txtDonVi.Text,
                    TT_Ban =true
                };
                string message;
                bool result = blNL.Update(NL, out message);
                if (result == false)
                    MessageBox.Show(message);
                this.Close();
            }
        }
    }
}
