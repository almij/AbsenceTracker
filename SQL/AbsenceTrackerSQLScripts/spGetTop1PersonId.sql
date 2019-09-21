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
CREATE PROCEDURE dbo.spGetPerson_Top1
AS
BEGIN
	SET NOCOUNT ON;

	SELECT TOP 1 *
	FROM dbo.person
END
GO
