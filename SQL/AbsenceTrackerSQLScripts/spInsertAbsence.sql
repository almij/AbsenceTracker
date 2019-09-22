USE AbsenceTracker

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE dbo.spInsertAbsence
    @person_id INT,
    @absence_type_id INT,
    @effective_from DATE,
    @expires_on DATE,
    @days_worked_on_holidays INT,
    @absence_id INT = 0 OUTPUT
AS
BEGIN
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO dbo.absence(
        person_id,
        absence_type_id,
        effective_from,
        expires_on,
        days_worked_on_holidays
        )
    VALUES (
        @person_id,
        @absence_type_id,
        @effective_from,
        @expires_on,
        @days_worked_on_holidays
        )
    SELECT @absence_id = SCOPE_IDENTITY()
END
GO
