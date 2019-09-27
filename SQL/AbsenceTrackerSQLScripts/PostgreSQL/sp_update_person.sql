-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE OR REPLACE PROCEDURE dbo.sp_update_person (
    _username VARCHAR(50),
    _first_name VARCHAR(50),
    _last_name VARCHAR(100),
    _patronymic VARCHAR(50),
    _middle_name VARCHAR(50),
    _email VARCHAR(100),
    _full_name_for_documents VARCHAR(300),
    _started_at DATE,
    _person_id INT
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