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
CREATE PROCEDURE [dbo].[sp_update_absence]
    @person_id INT,
    @absence_type_id INT,
    @effective_from DATE,
    @expires_on DATE,
    @days_worked_on_holidays INT,
    @absence_id INT
AS
BEGIN
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE dbo.absence
    SET person_id = @person_id,
        absence_type_id = @absence_type_id,
        effective_from = @effective_from,
        expires_on = @expires_on,
        days_worked_on_holidays = @days_worked_on_holidays
    WHERE absence_id = @absence_id
END
