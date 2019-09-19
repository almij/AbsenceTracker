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
CREATE PROCEDURE dbo.spGetPerson_ById
	@Id int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT *
	FROM dbo.person
	WHERE person_id = @Id
END
GO
