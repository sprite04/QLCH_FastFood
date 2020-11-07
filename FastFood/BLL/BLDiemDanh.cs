using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.BLL
{
    public class BLDiemDanh
    {
        public List<DIEMDANH> dsDiemDanh()
        {
            QLBH_FastFoodDataContext context = new QLBH_FastFoodDataContext();
            List<DIEMDANH> dsDD = context.DIEMDANHs.ToList();
            return dsDD;
        }

        public List<sp_DiemDanhResult> dsDiemDanhNgay()
        {
            QLBH_FastFoodDataContext context = new QLBH_FastFoodDataContext();
            List<sp_DiemDanhResult> dsDD = context.sp_DiemDanh(DateTime.Now).ToList();
            return dsDD;
        }
    }
}
