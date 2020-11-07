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

        private void LoadData1()
        {
            blCa = new BLCa();
            var dsCaNgay=blCa.dsCaNgay();
            RadioButton[] mangCa = new RadioButton[5];
            for(int i=0; i<dsCaNgay.Count;i++)
            {
                RadioButton rd = new RadioButton();
                rd.Size = new System.Drawing.Size(212, 40);
                rd.Location = new System.Drawing.Point(3, 3+i*40);
                rd.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
                if (dsCaNgay[i].MaCa.Hour == 7)
                {
                    rd.Text = "Ca Sáng";
                    rd.Tag = 7;
                }
                else if (dsCaNgay[i].MaCa.Hour == 12)
                {
                    rd.Text = "Ca Trưa";
                    rd.Tag = 12;
                }
                else if (dsCaNgay[i].MaCa.Hour == 17)
                {
                    rd.Text = "Ca Chiều";
                    rd.Tag = 17;
                }
                mangCa[i] = rd;
            }
            for(int i=0; i<dsCaNgay.Count;i++)
            {
                flpCa.Controls.Add(mangCa[i]);
                mangCa[i].Click += Shift_Click;
            }    

        }

        

        private void Shift_Click(object sender, EventArgs e)
        {
            BLNhanVien blNV = new BLNhanVien();
            BLDiemDanh blDD = new BLDiemDanh();
            var dsDD = blDD.dsDiemDanhNgay();
            List<NHANVIEN> dsNV = blNV.dsNhanVien();
            if (dsNV.Count > 0)
            {
                CheckBox[] danhsach = new CheckBox[dsNV.Count];
                for (int i = 0; i < dsNV.Count; i++)
                {
                    var ds = (from nv in dsDD
                              where nv.MaNV == dsNV[i].MaNV
                              select nv.MaNV).ToList();
                    if (ds.Count > 0)
                    {
                        CheckBox cb = new CheckBox();
                        cb.Text = dsNV[i].MaNV + " " + dsNV[i].HoTen;
                        cb.Tag = dsNV[i].MaNV;
                        cb.AutoSize = true;
                        cb.Checked = true;
                        danhsach[i] = cb;
                    }
                    else
                    {
                        CheckBox cb = new CheckBox();
                        cb.Text = dsNV[i].MaNV + " " + dsNV[i].HoTen;
                        cb.Tag = dsNV[i].MaNV;
                        cb.AutoSize = true;
                        danhsach[i] = cb;
                    }
                    flpDiemDanh.Controls.Add(danhsach[i]);
                }
            }
        }

    }
}
