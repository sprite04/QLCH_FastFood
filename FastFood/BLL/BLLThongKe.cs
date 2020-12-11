using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FastFood.Static;

namespace FastFood.BLL
{
    class BLLThongKe
    {

        public BLLThongKe()
        {
            int a = Global.global_datacontext.THONGKE_Ts.First().Nam;
        }
        public bool Insert(int Nam, int Thang, out string message)
        {
            message = "";
            try
            {
                //QLBH_FastFoodDataContext context = new QLBH_FastFoodDataContext();
                Global.global_datacontext.sp_TaoTK(Nam, Thang);
                
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
