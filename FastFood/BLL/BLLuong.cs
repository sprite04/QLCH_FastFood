using FastFood.Static;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.BLL
{
    public class BLLuong
    {

        public BLLuong()
        {

        }
        public List<LUONG> dsLuong()
        {
            //QLBH_FastFoodDataContext context = new QLBH_FastFoodDataContext();
            List<LUONG> dsLuong = Global.global_datacontext.LUONGs.ToList();
            return dsLuong;
        }
        public bool Insert(DateTime MaCa, int MaNV, out string message)
        {
            message = "";
            try
            {
                //QLBH_FastFoodDataContext context = new QLBH_FastFoodDataContext();
                Global.global_datacontext.sp_ThemLuong(MaNV,MaCa.Month,MaCa.Year);
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
            //QLBH_FastFoodDataContext context = new QLBH_FastFoodDataContext();
            List<st_LUONGResult> dsl = Global.global_datacontext.st_LUONG(nam, thang).ToList();
            return dsl;
        }
        public int CheckLuong(int nam, int thang)
        {
            //QLBH_FastFoodDataContext context = new QLBH_FastFoodDataContext();
            int a = Global.global_datacontext.fn_TraLuongCheck(nam,thang).GetValueOrDefault();
            return a;
        }
        public bool Pay(int nam, int thang, DateTime dateTime)
        {
            try
            {
                //QLBH_FastFoodDataContext context = new QLBH_FastFoodDataContext();
                Global.global_datacontext.sp_TraLuong1(nam,thang,dateTime.Date);
                return true;
            }
            catch
            {
                return false;
            }

        }

    }

}
