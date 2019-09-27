-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE OR REPLACE PROCEDURE dbo.sp_insert_person (
    _username VARCHAR(50),
    _first_name VARCHAR(50),
    _last_name VARCHAR(100),
    _patronymic VARCHAR(50),
    _middle_name VARCHAR(50),
    _email VARCHAR(100),
    _full_name_for_documents VARCHAR(300),
    _started_at DATE,
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