/* To prevent any potential data loss issues, you should review this script in detail before running it outside the context of the database designer.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
--ALTER TABLE dbo.Country
--	DROP CONSTRAINT UK_Country_Country_Abbrev
--GO
--ALTER TABLE dbo.Country
--	DROP CONSTRAINT PK_Country_ID
--GO
--ALTER TABLE dbo.Country ADD CONSTRAINT
--	PK_Country_ID PRIMARY KEY CLUSTERED 
--	(
--	Country_ID
--	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

--GO
--ALTER TABLE dbo.Country ADD CONSTRAINT
--	UK_Country_Country_Abbrev UNIQUE NONCLUSTERED 
--	(
--	Country_ID
--	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

--GO
ALTER TABLE dbo.Country SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.USStates SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.PersonalDetails
	(
	PersonalDetails_ID int NOT NULL IDENTITY (1, 1),
	FirstName varchar(50) NOT NULL,
	MiddleInitials char(1) NULL,
	LastName varchar(50) NULL,
	Gender varchar(10) NULL,
	DOB date NULL,
	PermAddrRow1 varchar(500) NULL,
	PermAddrRow2 varchar(500) NULL,
	PermAddrCity varchar(500) NULL,
	PermAddrZipCode char(5) NULL,
	PermAddrState int NULL,
	PermAddrCountry int NULL,
	TempAddrRow1 varchar(500) NULL,
	TempAddrRow2 varchar(500) NULL,
	TempAddrCity varchar(500) NULL,
	TempAddrZipCode char(5) NULL,
	TempAddrState int NULL,
	TempAddrCountry int NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.PersonalDetails ADD CONSTRAINT
	CK_PersonalDetails_Gender CHECK (Gender = 'Male' or Gender = 'Female')
GO
ALTER TABLE dbo.PersonalDetails ADD CONSTRAINT
	CK_PersonalDetails_PermAddrZip CHECK (PermAddrZipCode LIKE '[0-9][0-9][0-9][0-9][0-9]')
GO
ALTER TABLE dbo.PersonalDetails ADD CONSTRAINT
	CK_PersonalDetails_TempAddrZipCode CHECK (TempAddrZipCode LIKE '[0-9][0-9][0-9][0-9][0-9]')
GO
ALTER TABLE dbo.PersonalDetails ADD CONSTRAINT
	PK_PersonalDetails PRIMARY KEY CLUSTERED 
	(
	PersonalDetails_ID
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.PersonalDetails ADD CONSTRAINT
	FK_PersonalDetails_USStates_PermAddrState FOREIGN KEY
	(
	PermAddrState
	) REFERENCES dbo.USStates
	(
	USStates_ID
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.PersonalDetails ADD CONSTRAINT
	FK_PersonalDetails_USStates_TempAddrState FOREIGN KEY
	(
	TempAddrState
	) REFERENCES dbo.USStates
	(
	USStates_ID
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.PersonalDetails ADD CONSTRAINT
	FK_PersonalDetails_Country_PermAddrCountry FOREIGN KEY
	(
	PermAddrCountry
	) REFERENCES dbo.Country
	(
	Country_ID
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.PersonalDetails ADD CONSTRAINT
	FK_PersonalDetails_Country_TempAddrCountry FOREIGN KEY
	(
	TempAddrCountry
	) REFERENCES dbo.Country
	(
	Country_ID
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.PersonalDetails SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
