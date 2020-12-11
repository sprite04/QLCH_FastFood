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

namespace FastFood
{
    public partial class DetailEmployee : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        public DetailEmployee()
        {
            InitializeComponent();

            
        }
        public DetailEmployee(bool kind, NHANVIEN n)
        {
            InitializeComponent();

            nv = n;
            Kind = kind;
            blNV = new BLNhanVien();
            dsNV = blNV.dsNhanVien();
        }
        public DetailEmployee(bool them)
        {
            InitializeComponent();
            Them = them;
            blNV = new BLNhanVien();
            dsNV = blNV.dsNhanVien();
        }

        bool Them = false;
        bool Pass = false;
        bool Kind = false;

        BLNhanVien blNV;
        NHANVIEN nv = new NHANVIEN();
        List<NHANVIEN> dsNV = new List<NHANVIEN>();
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

        private void DetailEmployee_Load(object sender, EventArgs e)
        {
            if (Them)
            {
                lblName.Text = "ADD";
            }
            else
            {
                lblName.Text = "EDIT";
                //pnPass.Visible = Pass;
                //pnKind.Visible = Kind;
                txtHoTen.Text = nv.HoTen;
                txtCMND.Text = nv.CMND.ToString();
                txtMK.Text = nv.MatKhau;
                txtSDT.Text = nv.SDT.ToString();
                cbGT.Checked = (Boolean)nv.GT;
                if ((Boolean)nv.GT)
                    picNV.BackgroundImage = Properties.Resources.nu;
                else
                    picNV.BackgroundImage = Properties.Resources.nam;
                cbKind.SelectedIndex = (int.Parse(nv.MaCV.ToString()) - 1);
            }
        
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            int Num;
            bool k = int.TryParse(txtCMND.Text, out Num);
            if (k == false)
            {
                errorProvider1.SetError(pnCMND, "Giá trị CMND không hợp lệ");
                return;
            }
            k = int.TryParse(txtSDT.Text, out Num);
            if (k == false)
            {
                errorProvider1.SetError(pnSDT, "Giá trị SDT không hợp lệ");
                return;
            }
            if (Them)
            {
                string message;
                int value = 0;
                var ds = (from nv in dsNV
                          select nv.MaNV).ToList();
                if (ds.Count > 0)
                    value = ds.Max();
                NHANVIEN NV = new NHANVIEN()
                {
                    MaNV = value + 1,
                    HoTen = txtHoTen.Text,
                    GT = cbGT.Checked,
                    CMND = txtCMND.Text,
                    SDT = txtSDT.Text,
                    TT_Lam = true,
                    MaCV = cbKind.SelectedIndex+1
                };

                bool result = blNV.Insert(NV, out message);
                if (result == false)
                    MessageBox.Show(message);
                this.Close();
            }
            else
            {
                NHANVIEN NV = new NHANVIEN()
                {
                    MaNV = nv.MaNV,
                    HoTen = txtHoTen.Text,
                    GT = cbGT.Checked,
                    CMND = txtCMND.Text,
                    SDT = txtSDT.Text,
                    TT_Lam = nv.TT_Lam,
                    MatKhau = txtMK.Text,
                    MaCV = cbKind.SelectedIndex + 1
                };
                string message;
                bool result = blNV.Update(NV, out message);
                if (result == false)
                    MessageBox.Show(message);
                this.Close();
            }
        }

        private void cbGT_CheckedChanged(object sender, EventArgs e)
        {
            if (cbGT.Checked)
                picNV.BackgroundImage = Properties.Resources.nu;
            else
                picNV.BackgroundImage = Properties.Resources.nam;
        }

        private void cbKind_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Kind==true)
            {
                if (cbKind.SelectedIndex == 0)
                    pnPass.Visible = false;
                else
                    pnPass.Visible = true;
            }    
        }

        private void pnPass_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
