IF OBJECT_ID ( 'dbo.sp_InsertPersonalDetails', 'P' ) IS NOT NULL   
    DROP PROCEDURE dbo.sp_InsertPersonalDetails;  
GO  
CREATE PROCEDURE dbo.sp_InsertPersonalDetails 
	@FirstName varchar(50),
	@MiddleInitials char(1),
	@LastName varchar(50),
	@Gender varchar(10),
	@DOB date,
	@PermAddrRow1 varchar(500),
	@PermAddrRow2 varchar(500),
	@PermAddrCity varchar(500),
	@PermAddrZipCode char(5),
	@PermAddrState int,
	@PermAddrCountry int,	
	@TempAddrRow1 varchar(500),
	@TempAddrRow2 varchar(500),
	@TempAddrCity varchar(500),
	@TempAddrZipCode char(5),
	@TempAddrState int,
	@TempAddrCountry int
AS
BEGIN
	INSERT INTO dbo.PersonalDetails
	(
		FirstName,
		MiddleInitials,
		LastName,
		Gender,
		DOB,
		PermAddrRow1,
		PermAddrRow2,
		PermAddrCity,
		PermAddrZipCode,
		PermAddrState,
		PermAddrCountry,	
		TempAddrRow1,
		TempAddrRow2,
		TempAddrCity,
		TempAddrZipCode,
		TempAddrState,
		TempAddrCountry
	)
	VALUES
	(
		@FirstName,
		@MiddleInitials,
		@LastName,
		@Gender,
		@DOB,
		@PermAddrRow1,
		@PermAddrRow2,
		@PermAddrCity,
		@PermAddrZipCode,
		@PermAddrState,
		@PermAddrCountry,	
		@TempAddrRow1,
		@TempAddrRow2,
		@TempAddrCity,
		@TempAddrZipCode,
		@TempAddrState,
		@TempAddrCountry
	)
END
GO

GRANT EXEC on dbo.sp_InsertPersonalDetails to PUBLIC