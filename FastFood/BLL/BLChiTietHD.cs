﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.BLL
{
    public class BLChiTietHD
    {
        public List<CHITIET_HD> dsCT_HD()
        {
            QLBH_FastFoodDataContext context = new QLBH_FastFoodDataContext();
            List<CHITIET_HD> dsCT = context.CHITIET_HDs.ToList();
            return dsCT;
        }

        public List<sp_ChiTietDGVResult> dsChiTietHDDGV(v_HoaDon hd)
        {
            QLBH_FastFoodDataContext context = new QLBH_FastFoodDataContext();
            var dsCT = context.sp_ChiTietDGV(hd.MaHD).ToList();
            return dsCT;
        }

        public bool Insert(CHITIET_HD ct, out string message)
        {
            message = "";
            try
            {
                
                QLBH_FastFoodDataContext context = new QLBH_FastFoodDataContext();
                context.sp_ThemChiTietHD(ct.MaHD, ct.MaSP, ct.SL);
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
