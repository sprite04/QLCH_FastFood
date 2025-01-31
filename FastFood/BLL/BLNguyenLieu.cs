﻿using FastFood.DTO;
using FastFood.Static;
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

        public BLNguyenLieu()
        {

        }

        public List<v_NguyenLieu> dsVNguyenLieu()
        {
            //QLBH_FastFoodDataContext context = new QLBH_FastFoodDataContext();
            List<v_NguyenLieu> dsNL = Global.global_datacontext.v_NguyenLieus.ToList();
            return dsNL;
        }

        public List<NGUYENLIEU> dsNguyenLieu()
        {
            //QLBH_FastFoodDataContext context = new QLBH_FastFoodDataContext();
            List<NGUYENLIEU> dsNL = Global.global_datacontext.NGUYENLIEUs.ToList();
            return dsNL;
        }

        public List<NguyenLieuDGV> dsNguyenLieuDGV(SANPHAM sp)
        {
            List<NguyenLieuDGV> dsNLDGV = new List<NguyenLieuDGV>();
            //QLBH_FastFoodDataContext context = new QLBH_FastFoodDataContext();
            var dsNL = Global.global_datacontext.sp_NguyenLieuDGV(sp.MaSP).ToList();
            for (int i = 0; i < dsNL.Count; i++)
                dsNLDGV.Add(new NguyenLieuDGV() { MaNL = dsNL[i].MaNL, 
                                                  TenNL = dsNL[i].TenNL, 
                                                  GiaNL = dsNL[i].GiaNL, 
                                                  SL = dsNL[i].SL });
            return dsNLDGV;
        }

        public bool Insert(NGUYENLIEU nl, out string message)
        {
            message = "";
            try
            {
                //QLBH_FastFoodDataContext context = new QLBH_FastFoodDataContext();
                Global.global_datacontext.sp_ThemNguyenLieu(nl.MaNL, nl.TenNL, nl.GiaNL, nl.DonVi, nl.SLTonKho, nl.TT_Ban);
                return true;
            }
            catch (Exception e)
            {
                message = e.Message;
            }
            return false;
        }

        public bool Update(NGUYENLIEU nl, out string message)
        {
            message = "";
            try
            {
                //QLBH_FastFoodDataContext context = new QLBH_FastFoodDataContext();
                Global.global_datacontext.sp_SuaNguyenLieu(nl.MaNL, nl.TenNL, nl.GiaNL, nl.DonVi, nl.SLTonKho, nl.TT_Ban);
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
