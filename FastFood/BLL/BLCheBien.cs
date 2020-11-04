using FastFood.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.BLL
{
    public class BLCheBien
    {
        public bool Insert(NguyenLieuDGV nl,SANPHAM sp, out string message)
        {
            message = "";
            try
            {
                QLBH_FastFoodDataContext context = new QLBH_FastFoodDataContext();
                context.sp_ThemCheBien(sp.MaSP, nl.MaNL, nl.SL);
                return true;
            }
            catch (Exception e)
            {
                message = e.Message;
            }
            return false;
        }

        public bool Delete(SANPHAM sp, out string message)
        {
            message = "";
            try
            {
                QLBH_FastFoodDataContext context = new QLBH_FastFoodDataContext();
                context.sp_XoaCheBien(sp.MaSP);
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
