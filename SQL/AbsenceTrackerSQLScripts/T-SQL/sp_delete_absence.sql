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
CREATE PROCEDURE [dbo].[sp_delete_absence]
    @absence_id INT
AS
BEGIN
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE FROM dbo.absence
    WHERE absence_id = @absence_id
END
