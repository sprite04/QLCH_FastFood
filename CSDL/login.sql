
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

--storekeeper
GRANT SELECT,INSERT,UPDATE,DELETE ON dbo.NGUYENLIEU TO storekeeper
GRANT SELECT ON dbo.NHANVIEN TO storekeeper
DENY INSERT, DELETE, UPDATE ON dbo.NHANVIEN TO storekeeper

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
GRANT SELECT,INSERT, UPDATE ON dbo.CHEBIEN TO manager
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
GRANT SELECT,INSERT,UPDATE,DELETE ON dbo.v_HoaDon TO admin
GRANT SELECT,INSERT,UPDATE,DELETE ON dbo.v_NguyenLieu TO admin
GRANT SELECT,INSERT,UPDATE,DELETE ON dbo.v_SanPham TO admin
GRANT SELECT,INSERT,UPDATE,DELETE ON dbo.v_NhanVien TO admin

--manager
GRANT SELECT,INSERT,UPDATE ON dbo.v_HoaDon TO manager
GRANT SELECT,INSERT,UPDATE ON dbo.v_NguyenLieu TO manager
GRANT SELECT,INSERT,UPDATE ON dbo.v_SanPham TO manager
GRANT SELECT,INSERT,UPDATE ON dbo.v_NhanVien TO manager
--employee
GRANT SELECT,INSERT,UPDATE,DELETE ON dbo.v_HoaDon TO employee
GRANT SELECT,INSERT,UPDATE,DELETE ON dbo.v_NguyenLieu TO employee
GRANT SELECT,INSERT,UPDATE,DELETE ON dbo.v_SanPham TO employee
GRANT SELECT,INSERT,UPDATE,DELETE ON dbo.v_NhanVien TO employee

--store keeper
GRANT SELECT,INSERT,UPDATE,DELETE ON dbo.v_HoaDon TO storekeeper
GRANT SELECT,INSERT,UPDATE,DELETE ON dbo.v_NguyenLieu TO storekeeper
GRANT SELECT,INSERT,UPDATE,DELETE ON dbo.v_SanPham TO storekeeper
GRANT SELECT,INSERT,UPDATE,DELETE ON dbo.v_NhanVien TO storekeeper



--stored procedure

--admin
GRANT EXEC ON SCHEMA::dbo TO admin;

--manager
GRANT EXEC ON SCHEMA::dbo TO manager;
--employee
GRANT EXEC ON dbo.sp_ChiTietDGV TO employee;
GRANT EXEC ON dbo.sp_ThemChiTietHD TO employee;
GRANT EXEC ON dbo.sp_ThemHoaDon TO employee;
GRANT EXEC ON dbo.sp_XoaHoaDon TO employee;

--store keeper
GRANT EXEC ON dbo.sp_NguyenLieuDGV TO storekeeper;

GRANT EXEC ON dbo.sp_ThemNguyenLieu TO storekeeper;

GRANT EXEC ON dbo.sp_SuaNguyenLieu TO storekeeper;
