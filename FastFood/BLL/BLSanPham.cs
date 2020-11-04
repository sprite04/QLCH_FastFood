using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.BLL
{
    public class BLSanPham
    {
        public List<SANPHAM> dsSanPham()
        {
            QLBH_FastFoodDataContext context = new QLBH_FastFoodDataContext();
            List<SANPHAM> dsSP = context.SANPHAMs.ToList();
            return dsSP;
        }
    }
}
