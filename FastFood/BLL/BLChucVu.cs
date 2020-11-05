using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.BLL
{
    public class BLChucVu
    {
        public List<CHUCVU> dsChucVu()
        {
            QLBH_FastFoodDataContext context = new QLBH_FastFoodDataContext();
            List<CHUCVU> dsCV = context.CHUCVUs.ToList();
            return dsCV;
        }
    }
}
