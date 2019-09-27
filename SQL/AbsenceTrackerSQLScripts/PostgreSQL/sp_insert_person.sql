-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE OR REPLACE FUNCTION dbo.sp_insert_person (
    _username text,
    _first_name text,
    _last_name text,
    _patronymic text,
    _middle_name text,
    _email text,
    _full_name_for_documents text,
    _started_at timestamp without time zone,
    INOUT _person_id INT = 0
    )
AS
$$
BEGIN
	INSERT INTO dbo.person (
        username, 
        first_name, 
        last_name, 
        patronymic, 
        middle_name, 
        email, 
        full_name_for_documents, 
        started_at)
    VALUES (
        _username, 
        _first_name, 
        _last_name, 
        _patronymic, 
        _middle_name, 
        _email, 
        _full_name_for_documents, 
        _started_at
        )
	RETURNING person_id INTO _person_id;
END
$$
LANGUAGE PLPGSQL SECURITY DEFINER;