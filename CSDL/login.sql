
GO
USE QLBH_FastFood
CREATE login account1   WITH PASSWORD = '123' --test
CREATE login account2  WITH PASSWORD = '123' --test
--admin
CREATE login admin1   WITH PASSWORD = '123' 
CREATE USER USadmin1 FOR LOGIN admin1 
CREATE login admin2   WITH PASSWORD = '123' 
CREATE USER USadmin2 FOR LOGIN admin2  
CREATE login admin3   WITH PASSWORD = '123' 
CREATE USER USadmin3 FOR LOGIN admin3
Exec sp_addrolemember @rolename = 'admin', @membername = 'USadmin1'
Exec sp_addrolemember @rolename = 'admin', @membername = 'USadmin2'
Exec sp_addrolemember @rolename = 'admin', @membername = 'USadmin3'

--employee
CREATE login employee1   WITH PASSWORD = '123'  
CREATE USER USemployee1 FOR LOGIN employee1
CREATE login employee2   WITH PASSWORD = '123'  
CREATE USER USemployee2 FOR LOGIN employee2
CREATE login employee3   WITH PASSWORD = '123'  
CREATE USER USemployee3 FOR LOGIN employee3
Exec sp_addrolemember @rolename = 'employee', @membername = 'USemployee1'
Exec sp_addrolemember @rolename = 'employee', @membername = 'USemployee2'
Exec sp_addrolemember @rolename = 'employee', @membername = 'USemployee3'
--storekeeper
CREATE login stkp1   WITH PASSWORD = '123'  
CREATE USER USstkp1 FOR LOGIN stkp1
CREATE login stkp2   WITH PASSWORD = '123'  
CREATE USER USstkp2 FOR LOGIN stkp2
Exec sp_addrole @rolename = 'storekeeper'
Exec sp_addrolemember @rolename = 'storekeeper', @membername = 'USstkp1'
Exec sp_addrolemember @rolename = 'storekeeper', @membername = 'USstkp2'

--manager
CREATE login manager1   WITH PASSWORD = '123'  
CREATE USER USmanager1 FOR LOGIN manager1
CREATE login manager2   WITH PASSWORD = '123'  
CREATE USER USmanager2 FOR LOGIN manager2
Exec sp_addrole @rolename = 'manager'
Exec sp_addrolemember @rolename = 'manager', @membername = 'USmanager1'
Exec sp_addrolemember @rolename = 'manager', @membername = 'USmanager2'


--permission on table

--employee
GRANT SELECT ON SANPHAM TO employee
DENY INSERT, UPDATE, DELETE ON dbo.SANPHAM TO employee
GRANT SELECT,INSERT,UPDATE,DELETE ON HOADON TO employee
GRANT SELECT,UPDATE ON NGUYENLIEU TO employee
DENY INSERT ON dbo.NGUYENLIEU TO employee
DENY DELETE ON dbo.NGUYENLIEU TO employee
GRANT SELECT ON CHEBIEN TO employee
DENY DELETE, INSERT,UPDATE ON dbo.CHEBIEN TO employee
GRANT SELECT,INSERT,UPDATE,DELETE ON CHITIET_HD TO employee
DENY UPDATE ON dbo.THONGKE_T TO employee
DENY SELECT,INSERT,DELETE ON dbo.NHANVIEN TO employee


--storekeeper
GRANT SELECT,INSERT,UPDATE,DELETE ON dbo.NGUYENLIEU TO storekeeper
DENY SELECT,INSERT, DELETE, UPDATE ON dbo.NHANVIEN TO storekeeper
DENY SELECT,INSERT, DELETE, UPDATE ON dbo.SANPHAM TO storekeeper
DENY SELECT,INSERT, DELETE, UPDATE ON dbo.THONGKE_T TO storekeeper
DENY SELECT,INSERT, DELETE, UPDATE ON dbo.CA TO storekeeper
DENY SELECT,INSERT, DELETE, UPDATE ON dbo.CHEBIEN TO storekeeper
DENY SELECT,INSERT, DELETE, UPDATE ON dbo.CHITIET_HD TO storekeeper
DENY SELECT,INSERT, DELETE, UPDATE ON dbo.DIEMDANH TO storekeeper
DENY SELECT,INSERT, DELETE, UPDATE ON dbo.HOADON TO storekeeper
DENY SELECT,INSERT, DELETE, UPDATE ON dbo.CHUCVU TO storekeeper
DENY SELECT,INSERT, DELETE, UPDATE ON dbo.LUONG TO storekeeper
DENY SELECT,INSERT, DELETE, UPDATE ON dbo.THONGKE_T TO storekeeper









--admin
GRANT SELECT,INSERT,UPDATE,DELETE ON dbo.CA TO admin
GRANT SELECT,INSERT,UPDATE,DELETE ON dbo.CHEBIEN TO admin
GRANT SELECT,INSERT,UPDATE,DELETE ON dbo.CHITIET_HD TO admin
GRANT SELECT,INSERT,UPDATE,DELETE ON dbo.CHUCVU TO admin
GRANT SELECT,INSERT,UPDATE,DELETE ON dbo.DIEMDANH TO admin
GRANT SELECT,INSERT,UPDATE,DELETE ON dbo.HOADON TO admin
GRANT SELECT,INSERT,UPDATE,DELETE ON dbo.LUONG TO admin
GRANT SELECT,INSERT,UPDATE,DELETE ON dbo.NGUYENLIEU TO admin -- deny
GRANT SELECT,INSERT,UPDATE,DELETE ON dbo.NHANVIEN TO admin
GRANT SELECT,INSERT,UPDATE,DELETE ON dbo.SANPHAM TO admin--qun li
GRANT SELECT,INSERT,UPDATE,DELETE ON dbo.THONGKE_T TO admin



--manager
GRANT SELECT,INSERT, UPDATE ON dbo.CA TO manager
DENY SELECT,INSERT, UPDATE ON dbo.CHEBIEN TO manager
GRANT SELECT,INSERT, UPDATE ON dbo.CHITIET_HD TO manager
GRANT SELECT,INSERT ON dbo.CHUCVU TO manager
GRANT SELECT,INSERT,UPDATE ON dbo.DIEMDANH TO manager
GRANT SELECT,INSERT,UPDATE ON dbo.HOADON TO manager
GRANT SELECT,INSERT,UPDATE ON dbo.LUONG TO manager
GRANT SELECT,UPDATE ON NGUYENLIEU TO manager
DENY INSERT ON dbo.NGUYENLIEU TO manager
DENY DELETE ON dbo.NGUYENLIEU TO manager
GRANT SELECT,INSERT,UPDATE ON dbo.NHANVIEN TO manager
GRANT SELECT ON dbo.SANPHAM TO manager--qun li
DENY INSERT, UPDATE, DELETE ON dbo.SANPHAM TO manager
GRANT SELECT,INSERT,UPDATE ON dbo.THONGKE_T TO manager

--permission on view

--admin


--manager


--employee


--store keeper



--stored procedure

--admin
--REVOKE EXEC ON SCHEMA::dbo TO admin;
--manager
;







--sp_CA
------EMPLOYEE
DENY EXEC ON dbo.sp_Ca TO employee
------STOREKEEPER
DENY EXEC ON dbo.sp_Ca TO storekeeper
------MANAGER
GRANT EXEC ON dbo.sp_Ca TO manager
------ADMIN
GRANT EXEC ON dbo.sp_Ca TO admin

--sp_ThemCA
------EMPLOYEE
DENY EXEC ON dbo.sp_ThemCa TO employee
------STOREKEEPER
DENY EXEC ON dbo.sp_ThemCa TO storekeeper
------MANAGER
GRANT EXEC ON dbo.sp_ThemCa TO manager
------ADMIN
GRANT EXEC ON dbo.sp_ThemCa TO admin

--sp_themchebien
------EMPLOYEE
DENY EXEC ON dbo.sp_ThemCheBien TO employee
------STOREKEEPER
DENY EXEC ON dbo.sp_ThemCheBien TO storekeeper
------MANAGER
DENY EXEC ON dbo.sp_ThemCheBien TO manager
------ADMIN
GRANT EXEC ON dbo.sp_ThemCheBien TO admin



--sp_xoachebien
------EMPLOYEE
DENY EXEC ON dbo.sp_XoaCheBien TO employee
------STOREKEEPER
DENY EXEC ON dbo.sp_XoaCheBien TO storekeeper
------MANAGER
DENY EXEC ON dbo.sp_XoaCheBien TO manager
------ADMIN
GRANT EXEC ON dbo.sp_XoaCheBien TO admin

--sp_chitietdgv
------EMPLOYEE
DENY EXEC ON dbo.sp_ChiTietDGV TO employee
------STOREKEEPER
DENY EXEC ON dbo.sp_ChiTietDGV TO storekeeper
------MANAGER
GRANT EXEC ON dbo.sp_ChiTietDGV TO manager
------ADMIN
GRANT EXEC ON dbo.sp_ChiTietDGV TO admin

--sp_themchitiethd
------EMPLOYEE
GRANT EXEC ON dbo.sp_ThemChiTietHD TO employee
------STOREKEEPER
DENY EXEC ON dbo.sp_ThemChiTietHD TO storekeeper
------MANAGER
GRANT EXEC ON dbo.sp_ThemChiTietHD TO manager
------ADMIN
GRANT EXEC ON dbo.sp_ThemChiTietHD TO admin



--sp_diemdanh
------EMPLOYEE
DENY EXEC ON dbo.sp_DiemDanh TO employee
------STOREKEEPER
DENY EXEC ON dbo.sp_DiemDanh TO storekeeper
------MANAGER
GRANT EXEC ON dbo.sp_DiemDanh TO manager
------ADMIN
GRANT EXEC ON dbo.sp_DiemDanh TO admin


--sp_themdiemdanh
------EMPLOYEE
DENY EXEC ON dbo.sp_ThemDiemDanh TO employee
------STOREKEEPER
DENY EXEC ON dbo.sp_ThemDiemDanh TO storekeeper
------MANAGER
GRANT EXEC ON dbo.sp_ThemDiemDanh TO manager
------ADMIN
GRANT EXEC ON dbo.sp_ThemDiemDanh TO admin


--sp_xoadiemdanh
------EMPLOYEE
DENY EXEC ON dbo.sp_XoaDiemDanh TO employee
------STOREKEEPER
DENY EXEC ON dbo.sp_XoaDiemDanh TO storekeeper
------MANAGER
GRANT EXEC ON dbo.sp_XoaDiemDanh TO manager
------ADMIN
GRANT EXEC ON dbo.sp_XoaDiemDanh TO admin


--v_shiftandemployee
------EMPLOYEE
DENY SELECT ON dbo.v_ShiftAndEmployee TO employee
------STOREKEEPER
DENY SELECT ON dbo.v_ShiftAndEmployee TO storekeeper
------MANAGER
GRANT SELECT ON dbo.v_ShiftAndEmployee TO manager
------ADMIN
GRANT SELECT ON dbo.v_ShiftAndEmployee TO admin



--v_hoadon
------EMPLOYEE
DENY SELECT ON dbo.v_HoaDon TO employee
------STOREKEEPER
DENY SELECT ON dbo.v_HoaDon TO storekeeper
------MANAGER
GRANT SELECT ON dbo.v_HoaDon TO manager
------ADMIN
GRANT SELECT ON dbo.v_HoaDon TO admin


--sp_themhd
------EMPLOYEE
GRANT EXEC ON dbo.sp_ThemHoaDon TO employee
------STOREKEEPER
DENY EXEC ON dbo.sp_ThemHoaDon TO storekeeper
------MANAGER
GRANT EXEC ON dbo.sp_ThemHoaDon TO manager
------ADMIN
GRANT EXEC ON dbo.sp_ThemHoaDon TO admin


--sp_xoahd
------EMPLOYEE
GRANT EXEC ON dbo.sp_XoaHoaDon TO employee
------STOREKEEPER
DENY EXEC ON dbo.sp_XoaHoaDon TO storekeeper
------MANAGER
GRANT EXEC ON dbo.sp_XoaHoaDon TO manager
------ADMIN
GRANT EXEC ON dbo.sp_XoaHoaDon TO admin



--sp_taoThongKe
------EMPLOYEE
DENY EXEC ON dbo.sp_TaoTK TO employee
------STOREKEEPER
DENY EXEC ON dbo.sp_TaoTK TO storekeeper
------MANAGER
GRANT EXEC ON dbo.sp_TaoTK TO manager
------ADMIN
GRANT EXEC ON dbo.sp_TaoTK TO admin




--sp_themluong
------EMPLOYEE
DENY EXEC ON dbo.sp_ThemLuong TO employee
------STOREKEEPER
DENY EXEC ON dbo.sp_ThemLuong TO storekeeper
------MANAGER
GRANT EXEC ON dbo.sp_ThemLuong TO manager
------ADMIN
GRANT EXEC ON dbo.sp_ThemLuong TO admin


--st_luong
------EMPLOYEE
DENY EXEC ON dbo.st_LUONG TO employee
------STOREKEEPER
DENY EXEC ON dbo.st_LUONG TO storekeeper
------MANAGER
GRANT EXEC ON dbo.st_LUONG TO manager
------ADMIN
GRANT EXEC ON dbo.st_LUONG TO admin



--fn_TraLuongcheck
------EMPLOYEE
DENY EXEC ON dbo.fn_TraLuongCheck TO employee
------STOREKEEPER
DENY EXEC ON dbo.fn_TraLuongCheck TO storekeeper
------MANAGER
GRANT EXEC ON dbo.fn_TraLuongCheck TO manager
------ADMIN
GRANT EXEC ON dbo.fn_TraLuongCheck TO admin



--sp_traluong
------EMPLOYEE
DENY EXEC ON dbo.sp_TraLuong TO employee
------STOREKEEPER
DENY EXEC ON dbo.sp_TraLuong TO storekeeper
------MANAGER
GRANT EXEC ON dbo.sp_TraLuong TO manager
------ADMIN
GRANT EXEC ON dbo.sp_TraLuong TO admin


--v_NguyenLieu
------EMPLOYEE
DENY SELECT ON dbo.v_NguyenLieu TO employee
------STOREKEEPER
GRANT SELECT ON dbo.v_NguyenLieu TO storekeeper
------MANAGER
GRANT SELECT ON dbo.v_NguyenLieu TO manager
------ADMIN
GRANT SELECT ON dbo.v_NguyenLieu TO admin


--sp_nguyenlieuDGV
------EMPLOYEE
DENY EXEC ON dbo.sp_NguyenLieuDGV TO employee
------STOREKEEPER
GRANT EXEC ON dbo.sp_NguyenLieuDGV TO storekeeper
------MANAGER
GRANT EXEC ON dbo.sp_NguyenLieuDGV TO manager
------ADMIN
GRANT EXEC ON dbo.sp_NguyenLieuDGV TO admin


--sp_themnl
------EMPLOYEE
DENY EXEC ON dbo.sp_ThemNguyenLieu TO employee
------STOREKEEPER
GRANT EXEC ON dbo.sp_ThemNguyenLieu TO storekeeper
------MANAGER
DENY EXEC ON dbo.sp_ThemNguyenLieu TO manager-----------------------------
------ADMIN
GRANT EXEC ON dbo.sp_ThemNguyenLieu TO admin


--sp_suanguyenlieu
------EMPLOYEE
DENY EXEC ON dbo.sp_SuaNguyenLieu TO employee
------STOREKEEPER
GRANT EXEC ON dbo.sp_SuaNguyenLieu TO storekeeper
------MANAGER
DENY EXEC ON dbo.sp_SuaNguyenLieu TO manager-----------------------------
------ADMIN
GRANT EXEC ON dbo.sp_SuaNguyenLieu TO admin



--v_nhanvien
------EMPLOYEE
DENY SELECT ON dbo.v_NhanVien TO employee
------STOREKEEPER
DENY SELECT ON dbo.v_NhanVien TO storekeeper
------MANAGER
GRANT SELECT ON dbo.v_NhanVien TO manager-----------------------------
------ADMIN
GRANT SELECT ON dbo.v_NhanVien TO admin


--sp_themnv
------EMPLOYEE
DENY EXEC ON dbo.sp_ThemNhanVien TO employee
------STOREKEEPER
DENY EXEC ON dbo.sp_ThemNhanVien TO storekeeper
------MANAGER
GRANT EXEC ON dbo.sp_ThemNhanVien TO manager-----------------------------
------ADMIN
GRANT EXEC ON dbo.sp_ThemNhanVien TO admin


--sp_suanv
------EMPLOYEE
DENY EXEC ON dbo.sp_SuaNhanVien TO employee
------STOREKEEPER
DENY EXEC ON dbo.sp_SuaNhanVien TO storekeeper
------MANAGER
GRANT EXEC ON dbo.sp_SuaNhanVien TO manager-----------------------------
------ADMIN
GRANT EXEC ON dbo.sp_SuaNhanVien TO admin




--v_sanpham
------EMPLOYEE
GRANT SELECT ON dbo.v_SanPham TO employee
------STOREKEEPER
DENY SELECT ON dbo.v_SanPham TO storekeeper
------MANAGER
GRANT SELECT ON dbo.v_SanPham TO manager
------ADMIN
GRANT SELECT ON dbo.v_SanPham TO admin



--sp_themsp
------EMPLOYEE
DENY EXEC ON dbo.sp_ThemSanPham TO employee
------STOREKEEPER
DENY EXEC ON dbo.sp_ThemSanPham TO storekeeper
------MANAGER
DENY EXEC ON dbo.sp_ThemSanPham TO manager
------ADMIN
GRANT EXEC ON dbo.sp_ThemSanPham TO admin


--sp_suasp
------EMPLOYEE
DENY EXEC ON dbo.sp_SuaSanPham TO employee
------STOREKEEPER
DENY EXEC ON dbo.sp_SuaSanPham TO storekeeper
------MANAGER
DENY EXEC ON dbo.sp_SuaSanPham TO manager
------ADMIN
GRANT EXEC ON dbo.sp_SuaSanPham TO admin

