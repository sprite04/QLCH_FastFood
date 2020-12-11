using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FastFood.Static;


namespace FastFood.BLL
{
    public class BLNhanVien
    {
       
        public BLNhanVien()
        {

        }

        public List<NHANVIEN> dsNhanVien()
        {
            //QLBH_FastFoodDataContext context = new QLBH_FastFoodDataContext();
            List<NHANVIEN> dsNV = Global.global_datacontext.NHANVIENs.ToList();
            return dsNV;
        }

        public List<v_NhanVien> dsVNhanVien()
        {
            //QLBH_FastFoodDataContext context = new QLBH_FastFoodDataContext();
            List<v_NhanVien> dsVNV = Global.global_datacontext.v_NhanViens.ToList();
            return dsVNV;
        }

        public bool Insert(NHANVIEN nv, out string message)
        {
            message = "";
            try
            {
                QLBH_FastFoodDataContext context = new QLBH_FastFoodDataContext();
                context.sp_ThemNhanVien(nv.MaNV, nv.HoTen, nv.GT, nv.CMND, nv.SDT, nv.DiaChi, nv.TT_Lam, nv.MatKhau, nv.MaCV);
                return true;
            }
            catch (Exception e)
            {
                message = e.Message;
            }
            return false;
        }

        public bool Update(NHANVIEN nv, out string message)
        {
            message = "";
            try
            {
                QLBH_FastFoodDataContext context = new QLBH_FastFoodDataContext();
                context.sp_SuaNhanVien(nv.MaNV, nv.HoTen, nv.GT, nv.CMND, nv.SDT, nv.DiaChi, nv.TT_Lam, nv.MatKhau, nv.MaCV);
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
