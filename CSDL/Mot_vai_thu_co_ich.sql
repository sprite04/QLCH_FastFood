
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

ALTER TABLE dbo.NHANVIEN DROP COLUMN MatKhau




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

GO
CREATE PROCEDURE dbo.AssignUserToTicket
(
     @updateAuthor varchar(100)
    , @assignedUser varchar(100)
    , @ticketID bigint
)
AS
BEGIN
    BEGIN TRANSACTION;
    SAVE TRANSACTION MySavePoint;
    SET @updateAuthor = 'user1';
    SET @assignedUser = 'user2';
    SET @ticketID = 123456;

    BEGIN TRY
        UPDATE dbo.tblTicket 
        SET ticketAssignedUserSamAccountName = @assignedUser 
        WHERE (ticketID = @ticketID);

        INSERT INTO [dbo].[tblTicketUpdate]
            (
            [ticketID]
            ,[updateDetail]
            ,[updateDateTime]
            ,[userSamAccountName]
            ,[activity]
            )
        VALUES (
            @ticketID
            , 'Assigned ticket to ' + @assignedUser
            , GetDate()
            , @updateAuthor
            , 'Assign'
            );
        COMMIT TRANSACTION 
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
        BEGIN
            ROLLBACK TRANSACTION MySavePoint; -- rollback to MySavePoint
        END
    END CATCH
END;
GO