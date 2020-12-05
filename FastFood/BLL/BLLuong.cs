using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.BLL
{
    public class BLLuong
    {

        public List<LUONG> dsLuong()
        {
            QLBH_FastFoodDataContext context = new QLBH_FastFoodDataContext();
            List<LUONG> dsLuong = context.LUONGs.ToList();
            return dsLuong;
        }
        public bool Insert(DateTime MaCa, int MaNV, out string message)
        {
            message = "";
            try
            {
                QLBH_FastFoodDataContext context = new QLBH_FastFoodDataContext();
                context.sp_ThemLuong(MaNV,MaCa.Month,MaCa.Year);
                return true;
            }
            catch (Exception e)
            {
                message = e.Message;
            }
            return false;
        }
        public List<st_LUONGResult> dsVLuong(int nam, int thang)
        {
            QLBH_FastFoodDataContext context = new QLBH_FastFoodDataContext();
            List<st_LUONGResult> dsl = context.st_LUONG(nam, thang).ToList();
            return dsl;
        }
        public int CheckLuong(int nam, int thang)
        {
            QLBH_FastFoodDataContext context = new QLBH_FastFoodDataContext();
            int a = context.fn_TraLuongCheck(nam,thang).GetValueOrDefault();
            return a;
        }

    }

}
