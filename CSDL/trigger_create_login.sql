
GO
--tao login
ALTER FUNCTION fn_CreateQueryLogin (@role NVARCHAR(20), @password NVARCHAR(20), @username NVARCHAR(20))
RETURNS NVARCHAR(100) 
AS
BEGIN
	DECLARE @loginname NVARCHAR(40)
	DECLARE @query NVARCHAR(100)
	SET @loginname = @role + @username
	IF NOT EXISTS 
		(SELECT name  
		 FROM sys.server_principals
		 WHERE name = QUOTENAME(@loginname,''''))
		BEGIN
			SET @query = 'CREATE login '+ @loginname + ' WITH PASSWORD = ' + quotename( @password,'''')--crete ... password = '123'
		END 
	ELSE
			SET @query = NULL
	RETURN @query
END


GO
--tao user
--PRINT dbo.fn_CreateQueryLogin('admin','2324','123')
go
CREATE FUNCTION fn_CreateQueryUser (@role NVARCHAR(20), @username NVARCHAR(20))
RETURNS NVARCHAR(100) 
AS
BEGIN

	DECLARE @loginname NVARCHAR(40)
	DECLARE @fullusername NVARCHAR(40)

	DECLARE @query NVARCHAR(100)
	SET @loginname = @role + @username
	SET @fullusername = 'US'+@loginname
	
	IF NOT EXISTS 
		(SELECT name  
		 FROM sysusers
		 WHERE name = QUOTENAME(@fullusername,''''))
		BEGIN
			SET @query = 'CREATE USER '  +@fullusername+ ' FOR LOGIN '+ @loginname;
		END 
	ELSE
			SET @query = NULL
	RETURN @query
END

GO
--them user vao role
ALTER FUNCTION fn_CreateQueryAddRole (@role NVARCHAR(20), @username NVARCHAR(20))
RETURNS NVARCHAR(100) 
AS
BEGIN

	DECLARE @loginname NVARCHAR(40)
	DECLARE @fullusername NVARCHAR(40)

	DECLARE @query NVARCHAR(100)

	SET @loginname = @role + @username
	SET @fullusername = 'US'+@loginname
	SET @query = 'Exec sp_addrolemember @rolename = '+QUOTENAME(@role, '''') +', @membername = ' + QUOTENAME(@fullusername, '''')
	RETURN	@query
END
GO
--Exec sp_addrolemember @rolename = 'employee', @membername = 'USemployee1'
--print dbo.fn_CreateQueryAddRole ('admin','112')



----------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------
--------------------------------------trigger-------------------------------------------------
----------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------


go
ALTER TRIGGER tg_CreateLogin_ins ON dbo.NHANVIEN
FOR INSERT
AS
    DECLARE @username NVARCHAR(30)
	DECLARE @pass NVARCHAR(30)
	DECLARE @role NVARCHAR(30)
	DECLARE @temp int
	SET @pass = '123'
	SET @username  = CAST((SELECT MaNV FROM Inserted) AS NVARCHAR(30))
	SET @temp = (SELECT MaCV FROM Inserted)
	IF @temp = 1
		SET @role = 'employee'
	ELSE IF @temp = 2
		SET @role = 'storekeeper'
	ELSE IF @temp = 3
		SET @role = 'manager'
	ELSE IF @temp = 4
		SET @role = 'admin'
	ELSE 
		SET @role = NULL 

	DECLARE @query_createLogin NVARCHAR(100)
	DECLARE @query_createUS NVARCHAR(100)
	DECLARE @query_AddRole NVARCHAR(100)
	IF @role  IS NOT NULL AND @pass  IS NOT NULL AND @username  IS NOT NULL 
		BEGIN
		
			SET @query_createLogin = (dbo.fn_CreateQueryLogin(@role,@pass,@username))
			
			SET @query_createUS = dbo.fn_CreateQueryUser(@role,@username)

			SET @query_AddRole = dbo.fn_CreateQueryAddRole(@role,@username)
			
			IF @query_createLogin  IS NOT NULL AND @query_createUS  IS NOT NULL AND @query_AddRole  IS NOT NULL 
			BEGIN
				EXEC (@query_createLogin)
				EXEC (@query_createUS)
				EXEC (@query_AddRole)
			END
		END
     

