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

        public bool Insert(DateTime dt, int MaNV, out string message)
        {
            message = "";
            try
            {
                QLBH_FastFoodDataContext context = new QLBH_FastFoodDataContext();
                context.sp_ThemDiemDanh(dt, MaNV);
                return true;
            }
            catch (Exception e)
            {
                message = e.Message;
            }
            return false;
        }

        public bool Delete(DateTime dt, out string message)
        {
            message = "";
            try
            {
                QLBH_FastFoodDataContext context = new QLBH_FastFoodDataContext();
                context.sp_XoaDiemDanh(dt);
                return true;
            }
            catch (Exception e)
            {
                message = e.Message;
            }
            return false;
        }

        public List<v_ShiftAndEmployee> dsVShiftAndEmployee()
        {
            QLBH_FastFoodDataContext context = new QLBH_FastFoodDataContext();
            List<v_ShiftAndEmployee> dsVShiftAndEmployee = context.v_ShiftAndEmployees.ToList();
            return dsVShiftAndEmployee;
        }
    }
}
