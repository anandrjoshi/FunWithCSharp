IF OBJECT_ID ( 'dbo.sp_GetAllCountries', 'P' ) IS NOT NULL   
    DROP PROCEDURE dbo.sp_GetAllCountries;  
GO  
CREATE PROCEDURE dbo.sp_GetAllCountries 
AS
BEGIN
	SELECT Country_ID, Country_Abbrev, Country_Description
	FROM dbo.Country
END
GO

GRANT EXEC on dbo.sp_GetAllCountries to PUBLIC
