SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE dbo.spInsertPerson
    @username NVARCHAR(50),
    @first_name NVARCHAR(50),
    @last_name NVARCHAR(100),
    @patronymic NVARCHAR(50),
    @middle_name NVARCHAR(50),
    @email NVARCHAR(100),
    @full_name_for_documents NVARCHAR(300),
    @started_at DATE,
    @person_id INT = 0 OUTPUT
AS
BEGIN
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO dbo.person (
        username, 
        first_name, 
        last_name, 
        patronymic, 
        middle_name, 
        email, 
        full_name_for_documents, 
        started_at)
    VALUES (
        @username, 
        @first_name, 
        @last_name, 
        @patronymic, 
        @middle_name, 
        @email, 
        @full_name_for_documents, 
        @started_at
        )
    SELECT @person_id = SCOPE_IDENTITY()
END
GO
