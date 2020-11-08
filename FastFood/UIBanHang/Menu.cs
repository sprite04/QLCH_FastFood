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
using System.IO;

namespace FastFood
{
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
        }

        int ThanhTien = 0;
        BLSanPham blSP = new BLSanPham();
        BLHoaDon blHD = new BLHoaDon();
        BLChiTietHD blCT = new BLChiTietHD();
        PicItem[] listPi = new PicItem[200];
        List<Item> listItem = new List<Item>();
        List<v_SanPham> dsVSP = new List<v_SanPham>();
        List<HOADON> dsHD = new List<HOADON>();
        public Image ConvertImage(byte[] b)
        {
            MemoryStream ms = new MemoryStream(b, 0, b.Length);
            ms.Write(b, 0, b.Length);
            return Image.FromStream(ms, true);
        }
        private void Menu_Load(object sender, EventArgs e)
        {
            pnThanhToan.Visible = false;

            dsVSP = blSP.dsVSanPham();

            for (int i = 0; i < dsVSP.Count; i++)
            {
                listPi[i] = new PicItem()
                {
                    Tag = dsVSP[i].MaSP,
                    TenSP = dsVSP[i].TenSP,
                    GiaBan = string.Format("{0:n0}", dsVSP[i].GiaBan) + " &đ",
                    PicSP = ConvertImage((byte[])dsVSP[i].HinhSP.ToArray()),
                    Count = 0,
                };
                listPi[i].Click += Menu_Click;
                AddControl(listPi[i]);
            }

        }



        public void AddControl(PicItem pi)
        {
            int Ma = (int)pi.Tag;
            if (Ma >= 100 && Ma < 200)
                flpBurger.Controls.Add(pi);
            else if (Ma >= 200 && Ma < 300)
                flpChicken.Controls.Add(pi);
            else if (Ma >= 300 && Ma < 400)
                flpChickenSet.Controls.Add(pi);
            else if (Ma >= 400 && Ma < 500)
                flpCombo.Controls.Add(pi);
            else if (Ma >= 500 && Ma < 600)
                flpValue.Controls.Add(pi);
            else if (Ma >= 600 && Ma < 700)
                flpSet.Controls.Add(pi);
            else if (Ma >= 700 && Ma < 800)
                flpDessert.Controls.Add(pi);
            else
                flpDrink.Controls.Add(pi);
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            pnThanhToan.Visible = true;

            PicItem pi = sender as PicItem;
            pi.Count++;
            listItem.Remove(listItem.Find(i => i.Tag == pi.Tag));

            Item item = new Item()
            {
                Tag = pi.Tag,
                PicSP = pi.PicSP,
                TenSP = pi.TenSP,
                GiaBan = "× " + pi.GiaBan,
                SoLuong = pi.Count,
            };

            listItem.Add(item);

            flpSanPham.Controls.Clear();
            listItem.ForEach(i => flpSanPham.Controls.Add(i));

            TinhTien();

            for (int i = 0; i < listItem.Count; i++)
            {
                listItem[i].Click += MenuItemClick;
            }
        }

        private void TinhTien()
        {
            ThanhTien = 0;
            for (int i = 0; i < listItem.Count; i++)
            {
                int value = (int)(listItem[i].Tag);
                v_SanPham sp = dsVSP.Find(x => x.MaSP == value);
                ThanhTien += (int)sp.GiaBan * listItem[i].SoLuong;
            }
            if (listItem.Count == 0)
                pnThanhToan.Visible = false;
            else
                lblThanhTien.Text = "× " + string.Format("{0:n0}", ThanhTien) + " &đ";
        }
        private void MenuItemClick(object sender, EventArgs e)
        {
            flpSanPham.Controls.Clear();
            Item item = sender as Item;
            for (int i = 0; i < dsVSP.Count; i++)
            {
                int valuePi = (int)(listPi[i].Tag);
                int valueI = (int)(item.Tag);
                if (valuePi == valueI)
                {
                    listPi[i].Count = 0;
                    break;
                }

            }
            listItem.Remove(item);
            listItem.ForEach(i => flpSanPham.Controls.Add(i));
            TinhTien();
        }

        private int MaxHD()
        {
            dsHD = blHD.dsHoaDon();
            int value = 0;
            var ds = (from hd in dsHD
                          select hd.MaHD).ToList();
            if (ds.Count > 0)
                value = ds.Max();
            return value;
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            string message;
            int MaHD = MaxHD() + 1;
            blHD.Insert(MaHD, out message);
            bool result = true;
            for (int i = 0; i < listItem.Count; i++)
            {
                int value = (int)(listItem[i].Tag);
                CHITIET_HD ct = new CHITIET_HD();
                ct.MaHD = MaHD;
                ct.MaSP = value;
                ct.SL = listItem[i].SoLuong;
                result=blCT.Insert(ct, out message);
                if(result == false)
                {
                    MessageBox.Show(message);
                    return;
                }    
            }
            MessageBox.Show("Thực hiện thành công");
            listItem.Clear();
            flpSanPham.Controls.Clear();
            for (int i = 0; i < dsVSP.Count; i++)
            {
                if (listPi[i] == null)
                    break;
                listPi[i].Count = 0;
            }
            pnThanhToan.Visible = false;
        }
    }
}
