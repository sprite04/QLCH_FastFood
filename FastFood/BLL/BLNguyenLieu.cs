using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.BLL
{
    public class BLNguyenLieu
    {
        public List<NGUYENLIEU> dsNguyenLieu()
        {
            QLBH_FastFoodDataContext context = new QLBH_FastFoodDataContext();
            List<NGUYENLIEU> dsNL = context.NGUYENLIEUs.ToList();
            return dsNL;
        }
    }
}
