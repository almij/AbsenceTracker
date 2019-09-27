-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE OR REPLACE FUNCTION dbo.sp_delete_absence (
    INOUT _absence_id INT
    )
AS
$$
BEGIN
	DELETE FROM dbo.absence
    WHERE absence_id = _absence_id;
END
$$
LANGUAGE PLPGSQL SECURITY DEFINER;