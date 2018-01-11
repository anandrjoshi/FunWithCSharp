IF OBJECT_ID ( 'dbo.sp_GetAllUSStates', 'P' ) IS NOT NULL   
    DROP PROCEDURE dbo.sp_GetAllUSStates;  
GO  
CREATE PROCEDURE dbo.sp_GetAllUSStates 
AS
BEGIN
	SELECT USStates_ID, State_Abbrev, State_Description
	FROM dbo.USStates
END
GO
