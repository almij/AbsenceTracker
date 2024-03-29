--USE master;
--DROP DATABASE AbsenceTracker;
CREATE DATABASE AbsenceTracker;
GO
USE AbsenceTracker;

CREATE TABLE dbo.department
(
    department_id INT NOT NULL IDENTITY,
    department_name NVARCHAR(100) NOT NULL,
    department_head_id INT,
		
    CONSTRAINT pk_department_id PRIMARY KEY (department_id)
);
GO

CREATE TABLE dbo.project
(
    project_id int NOT NULL IDENTITY,
    project_name nvarchar(100) NOT NULL,
    project_head_id INT,
	
    CONSTRAINT pk_project_id PRIMARY KEY (project_id),
);
GO

CREATE TABLE dbo.person
(
    person_id INT NOT NULL IDENTITY,
    username NVARCHAR(50) NOT NULL,
    password_hash BINARY(64),
    first_name NVARCHAR(50),
    last_name NVARCHAR(100),
    patronymic NVARCHAR(50),
    middle_name NVARCHAR(50),
    email NVARCHAR(100),
    full_name_for_documents NVARCHAR(300),
    started_at DATE,
    department_id INT NULL
		
    CONSTRAINT unique_person_username UNIQUE (username),
    CONSTRAINT pk_person_id PRIMARY KEY (person_id),
);
GO

CREATE TABLE dbo.personnel_substitution
(
    person_id INT NOT NULL,
    substitute_person_id INT NOT NULL,
	
    CONSTRAINT pk_substitute_combo PRIMARY KEY (person_id, substitute_person_id)
);
GO

CREATE TABLE dbo.project_personnel
(
    project_id INT NOT NULL,
    person_id INT NOT NULL,

    CONSTRAINT pk_project_team_combo PRIMARY KEY (project_id, person_id)
);
GO

CREATE TABLE dbo.supervision
(
    person_id INT NOT NULL,
    supervisor_person_id INT NOT NULL,

    CONSTRAINT pk_supervision_combo PRIMARY KEY (person_id, supervisor_person_id)
);
GO

CREATE TABLE dbo.absence_type
(
    absence_type_id INT NOT NULL IDENTITY,
    absence_type_name NVARCHAR(100) NOT NULL,
    is_day_off BIT NOT NULL,
    is_overtime BIT NOT NULL,
	
    CONSTRAINT pk_absence_type_id PRIMARY KEY (absence_type_id),
    CONSTRAINT unique_absence_type_name UNIQUE(absence_type_name)
);
GO

CREATE TABLE dbo.absence
(
    absence_id INT NOT NULL IDENTITY,
    absence_type_id INT NOT NULL,
    person_id INT NOT NULL,
    effective_from DATE NOT NULL,
    expires_on DATE NOT NULL,
    days_worked_on_holidays INT CONSTRAINT default_absence_days_worked_on_holidays_zero DEFAULT 0,
	
    CONSTRAINT pk_absence_id PRIMARY KEY (absence_id),
    CONSTRAINT check_absence_effective_date_le_expiration_date CHECK(effective_from <= expires_on),
    CONSTRAINT unique_absence_person_id_effective_date_expiration_date UNIQUE(person_id, effective_from, expires_on)
);
GO




ALTER TABLE dbo.department ADD
    CONSTRAINT fk_department_person FOREIGN KEY (department_head_id) REFERENCES dbo.Person(person_id)
GO

ALTER TABLE dbo.project ADD
    CONSTRAINT fk_project_person FOREIGN KEY (project_head_id) REFERENCES dbo.Person(person_id)
GO

ALTER TABLE dbo.person ADD
    CONSTRAINT fk_person_department FOREIGN KEY(department_id) REFERENCES dbo.department(department_id)
GO

ALTER TABLE dbo.personnel_substitution ADD
    CONSTRAINT fk_substitute_person_1 FOREIGN KEY (person_id) REFERENCES dbo.Person(person_id),
    CONSTRAINT fk_substitute_person_2 FOREIGN KEY (substitute_person_id) REFERENCES dbo.Person(person_id)
GO

ALTER TABLE dbo.project_personnel ADD
    CONSTRAINT fk_project_team_project FOREIGN KEY (project_id) REFERENCES dbo.project(project_id),
    CONSTRAINT fk_project_team_person FOREIGN KEY (person_id) REFERENCES dbo.person(person_id)
GO

ALTER TABLE dbo.supervision ADD
    CONSTRAINT fk_supervision_person_1 FOREIGN KEY (person_id) REFERENCES dbo.person(person_id),
    CONSTRAINT fk_supervision_person_2 FOREIGN KEY (supervisor_person_id) REFERENCES dbo.person(person_id)
GO

ALTER TABLE dbo.absence ADD
    CONSTRAINT fk_absense_absence_type FOREIGN KEY (absence_type_id) REFERENCES dbo.absence_type(absence_type_id),
    CONSTRAINT fk_absence_person FOREIGN KEY (person_id) REFERENCES dbo.person(person_id)
GO