
GO
USE QLBH_FastFood
CREATE login account1   WITH PASSWORD = '123' --test



--admin
CREATE login admin1   WITH PASSWORD = '123' 
CREATE USER USadmin1 FOR LOGIN admin1 
CREATE login admin2   WITH PASSWORD = '123' 
CREATE USER USadmin2 FOR LOGIN admin2  
CREATE login admin3   WITH PASSWORD = '123' 
CREATE USER USadmin3 FOR LOGIN admin3
Exec sp_addrole @rolename = 'admin'
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
Exec sp_addrole @rolename = 'employee'
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
--(Thieu Quan)
--shift manager 
CREATE login shiftmanager1   WITH PASSWORD = '123'  
CREATE USER USshiftmanager1 FOR LOGIN shiftmanager1
Exec sp_addrole @rolename = 'shiftmanager'
Exec sp_addrolemember @rolename = 'shiftmanager', @membername = 'USshiftmanager1'


--permission on table

--employee
GRANT SELECT,INSERT,UPDATE,DELETE ON SANPHAM TO employee
GRANT SELECT,INSERT,UPDATE,DELETE ON HOADON TO employee
GRANT SELECT,INSERT,UPDATE,DELETE ON NGUYENLIEU TO employee
GRANT SELECT,INSERT,UPDATE,DELETE ON CHEBIEN TO employee
GRANT SELECT,INSERT,UPDATE,DELETE ON CHITIET_HD TO employee
GRANT SELECT ON dbo.NHANVIEN TO employee

--storekeeper
GRANT SELECT,INSERT,UPDATE,DELETE ON dbo.NGUYENLIEU TO storekeeper
GRANT SELECT ON dbo.NHANVIEN TO storekeeper

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

--shift manager
--EMGERCY
GRANT SELECT,INSERT,UPDATE,DELETE ON dbo.CA TO shiftmanager
GRANT SELECT,INSERT,UPDATE,DELETE ON dbo.CHEBIEN TO shiftmanager
GRANT SELECT,INSERT,UPDATE,DELETE ON dbo.CHUCVU TO shiftmanager
GRANT SELECT,INSERT,UPDATE,DELETE ON dbo.DIEMDANH TO shiftmanager
GRANT SELECT,INSERT,UPDATE,DELETE ON dbo.HOADON TO shiftmanager
GRANT SELECT,INSERT,UPDATE,DELETE ON dbo.LUONG TO shiftmanager
GRANT SELECT,INSERT,UPDATE,DELETE ON dbo.NHANVIEN TO shiftmanager
GRANT SELECT,INSERT,UPDATE,DELETE ON dbo.THONGKE_T TO shiftmanager
GRANT SELECT ON dbo.SANPHAM TO shiftmanager
GRANT SELECT ON dbo.CHITIET_HD TO shiftmanager
GRANT SELECT ON dbo.NGUYENLIEU TO shiftmanager

--permission on view

--admin
GRANT SELECT,INSERT,UPDATE,DELETE ON dbo.v_HoaDon TO admin
GRANT SELECT,INSERT,UPDATE,DELETE ON dbo.v_NguyenLieu TO admin
GRANT SELECT,INSERT,UPDATE,DELETE ON dbo.v_SanPham TO admin
GRANT SELECT,INSERT,UPDATE,DELETE ON dbo.v_NhanVien TO admin

--employee
GRANT SELECT,INSERT,UPDATE,DELETE ON dbo.v_HoaDon TO admin
GRANT SELECT,INSERT,UPDATE,DELETE ON dbo.v_NguyenLieu TO admin
GRANT SELECT,INSERT,UPDATE,DELETE ON dbo.v_SanPham TO admin
GRANT SELECT,INSERT,UPDATE,DELETE ON dbo.v_NhanVien TO admin

--store keeper
GRANT SELECT,INSERT,UPDATE,DELETE ON dbo.v_HoaDon TO storekeeper
GRANT SELECT,INSERT,UPDATE,DELETE ON dbo.v_NguyenLieu TO storekeeper
GRANT SELECT,INSERT,UPDATE,DELETE ON dbo.v_SanPham TO storekeeper
GRANT SELECT,INSERT,UPDATE,DELETE ON dbo.v_NhanVien TO storekeeper

--Shif manager:
GRANT SELECT,INSERT,UPDATE,DELETE ON dbo.v_HoaDon TO shiftmanager
GRANT SELECT,INSERT,UPDATE,DELETE ON dbo.v_NguyenLieu TO shiftmanager
GRANT SELECT,INSERT,UPDATE,DELETE ON dbo.v_SanPham TO shiftmanager
GRANT SELECT,INSERT,UPDATE,DELETE ON dbo.v_NhanVien TO shiftmanager

--stored procedure

--admin
GRANT EXEC ON SCHEMA::dbo TO admin;

--employee
GRANT EXEC ON dbo.sp_ChiTietDGV TO employee;
GRANT EXEC ON dbo.sp_ThemChiTietHD TO employee;
GRANT EXEC ON dbo.sp_ThemHoaDon TO employee;
GRANT EXEC ON dbo.sp_XoaHoaDon TO employee;

--store keeper
GRANT EXEC ON dbo.sp_NguyenLieuDGV TO storekeeper;

GRANT EXEC ON dbo.sp_ThemNguyenLieu TO storekeeper;

GRANT EXEC ON dbo.sp_SuaNguyenLieu TO storekeeper;

--shift manager
GRANT EXEC ON dbo.sp_Ca TO shiftmanager
GRANT EXEC ON dbo.sp_ChiTietDGV TO shiftmanager
GRANT EXEC ON dbo.sp_DiemDanh TO shiftmanager
GRANT EXEC ON dbo.sp_Login TO shiftmanager
GRANT EXEC ON dbo.sp_NguyenLieuDGV TO shiftmanager
GRANT EXEC ON dbo.sp_SuaNhanVien TO shiftmanager
GRANT EXEC ON dbo.sp_ThemCa TO shiftmanager
GRANT EXEC ON dbo.sp_ThemChiTietHD TO shiftmanager
GRANT EXEC ON dbo.sp_ThemDiemDanh TO shiftmanager
GRANT EXEC ON dbo.sp_ThemHoaDon TO shiftmanager
GRANT EXEC ON dbo.sp_ThemNhanVien TO shiftmanager
GRANT EXEC ON dbo.sp_XoaDiemDanh TO shiftmanager
GRANT EXEC ON dbo.sp_XoaHoaDon TO shiftmanager