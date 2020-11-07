using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.BLL
{
    public class BLCa
    {
        public List<CA> dsCa()
        {
            QLBH_FastFoodDataContext context = new QLBH_FastFoodDataContext();
            List<CA> dsCa = context.CAs.ToList();
            return dsCa;
        }

        public List<sp_CaResult> dsCaNgay()
        {
            QLBH_FastFoodDataContext context = new QLBH_FastFoodDataContext();
            var dsCaNgay = context.sp_Ca(DateTime.Now).ToList();
            return dsCaNgay;
        }
        public bool Insert(DateTime MaCa, out string message)
        {
            message = "";
            try
            {
                QLBH_FastFoodDataContext context = new QLBH_FastFoodDataContext();
                context.sp_ThemCa(MaCa);
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
