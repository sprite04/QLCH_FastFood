
GO
DECLARE @var NVARCHAR(30)
SET @var = dbo.fn_RoleOfLogin('admin112')

EXEC(@var)

EXEC sp_helpuser admin
GO
SELECT *
FROM sys.sp_helpuser @name_in_db = NULL AS tb

GO

IF IS_ROLEMEMBER ('admin','USadmin111') = 1  
   print 'Current user is a member of the db_datareader role'  
ELSE 
	PRINT 'a'

SELECT CURRENT_USER;  
GO  




-------------------------------------------------------------------------
-------------------------------------------------------------------------
-------------------------------------------------------------------------
EXECUTE AS USER = 'USemployee1';  
GO  
SELECT CURRENT_USER;  
GO  
SELECT * FROM dbo.THONGKE_T
REVERT;  
GO  
SELECT CURRENT_USER;  
GO  
-------------------------------------------------------------------------
-------------------------------------------------------------------------