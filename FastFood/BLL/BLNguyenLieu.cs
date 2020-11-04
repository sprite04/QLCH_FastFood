using FastFood.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        public List<NguyenLieuDGV> dsNguyenLieuDGV(SANPHAM sp)
        {
            List<NguyenLieuDGV> dsNLDGV = new List<NguyenLieuDGV>();
            QLBH_FastFoodDataContext context = new QLBH_FastFoodDataContext();
            var dsNL = context.sp_NguyenLieuDGV(sp.MaSP).ToList();
            for (int i = 0; i < dsNL.Count; i++)
                dsNLDGV.Add(new NguyenLieuDGV() { MaNL = dsNL[i].MaNL, 
                                                  TenNL = dsNL[i].TenNL, 
                                                  GiaNL = dsNL[i].GiaNL, 
                                                  SL = dsNL[i].SL });
            return dsNLDGV;
        }
    }
}
