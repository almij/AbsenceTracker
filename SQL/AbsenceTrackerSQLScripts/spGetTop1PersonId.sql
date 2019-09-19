USE AbsenceTracker
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE dbo.spGetTop1PersonId
AS
BEGIN
	SET NOCOUNT ON;

	SELECT TOP 1 person_id
	FROM dbo.person
END
GO
