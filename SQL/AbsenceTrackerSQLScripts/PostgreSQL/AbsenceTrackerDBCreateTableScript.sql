--USE master;
--DROP DATABASE AbsenceTracker;
--CREATE DATABASE AbsenceTracker;

--USE AbsenceTracker;

CREATE TABLE dbo.department
(
    department_id INT GENERATED ALWAYS AS IDENTITY,
    department_name VARCHAR(100) NOT NULL,
    department_head_id INT,
		
    CONSTRAINT pk_department_id PRIMARY KEY (department_id)
);


CREATE TABLE dbo.project
(
    project_id int GENERATED ALWAYS AS IDENTITY,
    project_name VARCHAR(100) NOT NULL,
    project_head_id INT,
	
    CONSTRAINT pk_project_id PRIMARY KEY (project_id)
);


CREATE TABLE dbo.person
(
    person_id INT GENERATED ALWAYS AS IDENTITY,
    username VARCHAR(50) NOT NULL CONSTRAINT unique_person_username UNIQUE,
    password_hash BYTEA,
    first_name VARCHAR(50),
    last_name VARCHAR(100),
    patronymic VARCHAR(50),
    middle_name VARCHAR(50),
    email VARCHAR(100),
    full_name_for_documents VARCHAR(300),
    started_at DATE,
    department_id INT NULL,
		
    CONSTRAINT pk_person_id PRIMARY KEY (person_id)
);


CREATE TABLE dbo.personnel_substitution
(
    person_id INT NOT NULL,
    substitute_person_id INT NOT NULL,
	
    CONSTRAINT pk_substitute_combo PRIMARY KEY (person_id, substitute_person_id)
);


CREATE TABLE dbo.project_personnel
(
    project_id INT NOT NULL,
    person_id INT NOT NULL,

    CONSTRAINT pk_project_team_combo PRIMARY KEY (project_id, person_id)
);


CREATE TABLE dbo.supervision
(
    person_id INT NOT NULL,
    supervisor_person_id INT NOT NULL,

    CONSTRAINT pk_supervision_combo PRIMARY KEY (person_id, supervisor_person_id)
);


CREATE TABLE dbo.absence_type
(
    absence_type_id INT GENERATED ALWAYS AS IDENTITY,
    absence_type_name VARCHAR(100) NOT NULL CONSTRAINT unique_absence_type_name UNIQUE,
    is_day_off BIT NOT NULL,
    is_overtime BIT NOT NULL,
	
    CONSTRAINT pk_absence_type_id PRIMARY KEY (absence_type_id)
);


CREATE TABLE dbo.absence
(
    absence_id INT GENERATED ALWAYS AS IDENTITY,
    absence_type_id INT NOT NULL,
    person_id INT NOT NULL,
    effective_from DATE NOT NULL,
    expires_on DATE NOT NULL,
    days_worked_on_holidays INT CONSTRAINT default_absence_days_worked_on_holidays_zero DEFAULT 0,
	
    CONSTRAINT pk_absence_id PRIMARY KEY (absence_id),
    CONSTRAINT check_absence_effective_date_le_expiration_date CHECK(effective_from <= expires_on),
    CONSTRAINT unique_absence_person_id_effective_date_expiration_date UNIQUE (person_id, effective_from, expires_on)
);





ALTER TABLE dbo.department ADD
    CONSTRAINT fk_department_person FOREIGN KEY (department_head_id) REFERENCES dbo.Person(person_id);


ALTER TABLE dbo.project ADD
    CONSTRAINT fk_project_person FOREIGN KEY (project_head_id) REFERENCES dbo.Person(person_id);


ALTER TABLE dbo.person ADD
    CONSTRAINT fk_person_department FOREIGN KEY(department_id) REFERENCES dbo.department(department_id);


ALTER TABLE dbo.personnel_substitution ADD
    CONSTRAINT fk_substitute_person_1 FOREIGN KEY (person_id) REFERENCES dbo.Person(person_id);
ALTER TABLE dbo.personnel_substitution ADD
    CONSTRAINT fk_substitute_person_2 FOREIGN KEY (substitute_person_id) REFERENCES dbo.Person(person_id);


ALTER TABLE dbo.project_personnel ADD
    CONSTRAINT fk_project_team_project FOREIGN KEY (project_id) REFERENCES dbo.project(project_id);
ALTER TABLE dbo.project_personnel ADD
    CONSTRAINT fk_project_team_person FOREIGN KEY (person_id) REFERENCES dbo.person(person_id);


ALTER TABLE dbo.supervision ADD
    CONSTRAINT fk_supervision_person_1 FOREIGN KEY (person_id) REFERENCES dbo.person(person_id);
ALTER TABLE dbo.supervision ADD
    CONSTRAINT fk_supervision_person_2 FOREIGN KEY (supervisor_person_id) REFERENCES dbo.person(person_id);


ALTER TABLE dbo.absence ADD
    CONSTRAINT fk_absense_absence_type FOREIGN KEY (absence_type_id) REFERENCES dbo.absence_type(absence_type_id);
ALTER TABLE dbo.absence ADD
    CONSTRAINT fk_absence_person FOREIGN KEY (person_id) REFERENCES dbo.person(person_id);
