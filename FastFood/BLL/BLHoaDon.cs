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
    }
}
