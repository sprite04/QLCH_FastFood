using FastFood.Static;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.BLL
{
    public class BLSanPham
    {

        public BLSanPham()
        {

        }
        public List<SANPHAM> dsSanPham()
        {

            //context.Refresh();
            List<SANPHAM> dsSP = Global.global_datacontext.SANPHAMs.ToList();
            return dsSP;
        }

        public List<v_SanPham> dsVSanPham()
        {
           // QLBH_FastFoodDataContext context = new QLBH_FastFoodDataContext();
            List<v_SanPham> dsVSP = Global.global_datacontext.v_SanPhams.ToList();
            return dsVSP;
        }

        public bool Insert(SANPHAM sp,out string message)
        {
            message = "";
            try
            {
                //QLBH_FastFoodDataContext context = new QLBH_FastFoodDataContext();
                Global.global_datacontext.sp_ThemSanPham(sp.MaSP, sp.HinhSP, sp.TenSP, sp.TT_Ban, sp.TT_Con, sp.LoiNhuan, sp.GiamGia);
                return true;
            }
            catch (Exception e)
            {
                message = e.Message;
            }
            return false;
        }

        public bool Update(SANPHAM sp, out string message)
        {
            message = "";
            try
            {
                //  QLBH_FastFoodDataContext context = new QLBH_FastFoodDataContext();
                Global.global_datacontext.sp_SuaSanPham(sp.MaSP, sp.HinhSP, sp.TenSP, sp.TT_Ban, sp.TT_Con, sp.LoiNhuan, sp.GiamGia);
                return true;
            }
            catch (Exception e)
            {
                message = e.Message;
            }
            return false;
        }
    }
}
