-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE OR REPLACE PROCEDURE dbo.sp_update_absence (
    _person_id INT,
    _absence_type_id INT,
    _effective_from DATE,
    _expires_on DATE,
    _days_worked_on_holidays INT,
    _absence_id INT
    )
AS
$$
BEGIN
	UPDATE dbo.absence
    SET person_id = _person_id,
        absence_type_id = _absence_type_id,
        effective_from = _effective_from,
        expires_on = _expires_on,
        days_worked_on_holidays = _days_worked_on_holidays
    WHERE absence_id = _absence_id;
END
$$
LANGUAGE PLPGSQL SECURITY DEFINER;