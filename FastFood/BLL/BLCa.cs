
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FastFood.Static;

namespace FastFood.BLL
{
    public class BLCa
    {

        public BLCa()
        {
            
        }


        public List<CA> dsCa()
        {
            //QLBH_FastFoodDataContext context = new QLBH_FastFoodDataContext(conStr);
            // thay vì tạo context mới thì dùng biến global đã được gán ở fmLogin
            List<CA> dsCa = Global.global_datacontext.CAs.ToList();
            return dsCa;
        }

        public List<sp_CaResult> dsCaNgay()
        {
            //QLBH_FastFoodDataContext context = new QLBH_FastFoodDataContext(conStr);
            var dsCaNgay = Global.global_datacontext.sp_Ca(DateTime.Now).ToList();
            return dsCaNgay;
        }
        public bool Insert(DateTime MaCa, out string message)
        {
            message = "";
            try
            {
                //QLBH_FastFoodDataContext context = new QLBH_FastFoodDataContext(conStr);
                Global.global_datacontext.sp_ThemCa(MaCa);
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
