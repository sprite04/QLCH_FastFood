using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.BLL
{
    public class BLHoaDon
    {
        public List<HOADON> dsHoaDon()
        {
            QLBH_FastFoodDataContext context = new QLBH_FastFoodDataContext();
            List<HOADON> dsHD = context.HOADONs.ToList();
            return dsHD;
        }

        public List<v_HoaDon> dsVHoaDon()
        {
            QLBH_FastFoodDataContext context = new QLBH_FastFoodDataContext();
            List<v_HoaDon> dsVHD = context.v_HoaDons.ToList();
            return dsVHD;
        }

        public bool Insert(int MaHD, out string message)
        {
            message = "";
            try
            {
                QLBH_FastFoodDataContext context = new QLBH_FastFoodDataContext();
                context.sp_ThemHoaDon(MaHD);
                return true;
            }
            catch (Exception e)
            {
                message = e.Message;
            }
            return false;
        }

        public bool Delete(int MaHD, out string message)
        {
            message = "";
            try
            {
                QLBH_FastFoodDataContext context = new QLBH_FastFoodDataContext();
                context.sp_XoaHoaDon(MaHD);
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
