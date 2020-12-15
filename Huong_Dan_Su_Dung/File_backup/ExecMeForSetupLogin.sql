--!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!--
--!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!--
--!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!--
--!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!--
-----ONLY execute this file when the database QLBH_FastFood already restored-----
--!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!--
--!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!--
--!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!--
--!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!--


GO
USE QLBH_FastFood
GO

--LOGIN ADMIN1
IF NOT EXISTS 
		(SELECT name  
		 FROM sys.server_principals
		 WHERE name = 'admin1')
	BEGIN
		CREATE login admin1   WITH PASSWORD = '123'
	END 
ELSE
	BEGIN
		DROP LOGIN admin1
		CREATE login admin1   WITH PASSWORD = '123'
	END
DROP USER USadmin1
CREATE USER USadmin1 FOR LOGIN admin1 
Exec sp_addrolemember @rolename = 'admin', @membername = 'USadmin1'


--LOGIN EMPLOYEE1
CREATE login employee1   WITH PASSWORD = '123'  
DROP USER USemployee1
CREATE USER USemployee1 FOR LOGIN employee1
Exec sp_addrolemember @rolename = 'employee', @membername = 'USemployee1'

--LOGIN STKP1
CREATE login stkp1   WITH PASSWORD = '123'  
DROP USER USstkp1
CREATE USER USstkp1 FOR LOGIN stkp1
Exec sp_addrolemember @rolename = 'storekeeper', @membername = 'USstkp1'


--LOGIN MANAGER1
CREATE login manager1   WITH PASSWORD = '123'  
DROP USER USmanager1
CREATE USER USmanager1 FOR LOGIN manager1
Exec sp_addrolemember @rolename = 'manager', @membername = 'USmanager1'



