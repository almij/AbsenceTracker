-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE OR REPLACE PROCEDURE dbo.sp_insert_absence (
    _person_id INT,
    _absence_type_id INT,
    _effective_from DATE,
    _expires_on DATE,
    _days_worked_on_holidays INT,
    INOUT _absence_id INT = 0
    )
AS
$$
BEGIN
	INSERT INTO dbo.absence(
        person_id,
        absence_type_id,
        effective_from,
        expires_on,
        days_worked_on_holidays
        )
    VALUES (
        _person_id,
        _absence_type_id,
        _effective_from,
        _expires_on,
        _days_worked_on_holidays
        )
    RETURNING absence_id INTO _absence_id;
END
$$
LANGUAGE PLPGSQL SECURITY DEFINER;