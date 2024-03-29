USE [AbsenceTracker]
GO
/****** Object:  StoredProcedure [dbo].[spInsertPerson]    Script Date: 23-Sep-19 00:50:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_update_person]
    @username NVARCHAR(50),
    @first_name NVARCHAR(50),
    @last_name NVARCHAR(100),
    @patronymic NVARCHAR(50),
    @middle_name NVARCHAR(50),
    @email NVARCHAR(100),
    @full_name_for_documents NVARCHAR(300),
    @started_at DATE,
    @person_id INT
AS
BEGIN
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE dbo.person
    SET username = @username, 
        first_name = @first_name, 
        last_name = @last_name, 
        patronymic = @patronymic, 
        middle_name = @middle_name, 
        email = @email, 
        full_name_for_documents = @full_name_for_documents, 
        started_at = @started_at
    WHERE person_id = @person_id
END
