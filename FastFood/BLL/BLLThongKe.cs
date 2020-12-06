﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.BLL
{
    class BLLThongKe
    {
        public bool Insert(int Nam, int Thang, out string message)
        {
            message = "";
            try
            {
                QLBH_FastFoodDataContext context = new QLBH_FastFoodDataContext();
                context.sp_TaoTK(Nam, Thang);
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
