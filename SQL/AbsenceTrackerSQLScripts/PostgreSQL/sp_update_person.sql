-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE OR REPLACE FUNCTION dbo.sp_update_person (
    _username text,
    _first_name text,
    _last_name text,
    _patronymic text,
    _middle_name text,
    _email text,
    _full_name_for_documents text,
    _started_at timestamp without time zone,
    INOUT _person_id INT
    )
AS
$$
BEGIN
	UPDATE dbo.person
    SET username = _username, 
        first_name = _first_name, 
        last_name = _last_name, 
        patronymic = _patronymic, 
        middle_name = _middle_name, 
        email = _email, 
        full_name_for_documents = _full_name_for_documents, 
        started_at = _started_at
    WHERE person_id = _person_id;
END
$$
LANGUAGE PLPGSQL SECURITY DEFINER;