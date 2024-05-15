-- DDL
-- CREATE, ALTER, DROP

--CREATE DATABASE Chinook2;

-- sql dbs have basically "namespace" for tables, and other objects.
-- called schema.
CREATE SCHEMA School;
GO
-- in SQL Server, "dbo" is the default schema, the one that it assumes if you don't give one.
--SELECT * FROM dbo.Playlist;

-- tables for managing school/student/course/teacher
--DROP TABLE School.Course;
CREATE TABLE School.Course (
	Id NVARCHAR(30) NOT NULL PRIMARY KEY,
	Name NVARCHAR(150) NOT NULL,
	TeacherId INT NULL,
	StartDate DATE NOT NULL DEFAULT GETDATE(),
	EndDate DATE NOT NULL,
	CHECK (EndDate > StartDate)
);
ALTER TABLE School.Course
	DROP CONSTRAINT PK__Course__C92D71A7DDC37D47;
ALTER TABLE School.Course
	DROP COLUMN CourseId;

SELECT * FROM School.Course;

-- constraints in SQL Server
--   any column by default could contain NULL.
--   you can restrict this with "NOT NULL"
--   writing "NULL" makes that default explicit.

--   UNIQUE - prevent any duplicate values in that column.
--         good for candidate keys. can be applied to sets of columns
--         good for representing 1-to-1 relationships with FK.

--   PRIMARY KEY - set the primary key for the table
--      automatically implies UNIQUE and NOT NULL
--      but we'd usually write NOT NULL anyway just to be explicit

--   CHECK - put any expression in parentheses after this,
--        and that expression needs to be true for every row.

--   DEFAULT - sets a default value if an INSERT is done without one.
--      doesn't have to be constant - is evaluated at insert time.

--   IDENTITY(start,offset) - sets an auto-incrementing default number.
--		(default (1,1)) this constraint prevents manually inserting any value

--   FOREIGN KEY

--ALTER TABLE School.Course DROP CONSTRAINT FK_Course_TeacherId;
--DROP TABLE School.Teacher;
CREATE TABLE School.Teacher (
	Id INT NOT NULL PRIMARY KEY IDENTITY,
	Name NVARCHAR(100) NOT NULL CHECK (LEN(Name) > 0)
);

ALTER TABLE School.Course
	ADD CONSTRAINT FK_Course_TeacherId FOREIGN KEY (TeacherId)
		REFERENCES School.Teacher (Id);

INSERT INTO School.Teacher (Name) VALUES
	('Luke');
SELECT * FROM School.Teacher;
DELETE FROM School.Teacher WHERE Id > 1;

INSERT INTO School.Course (Id, Name, TeacherId, EndDate) VALUES
	('CS-101', 'Intro to C#', (SELECT Id FROM School.Teacher WHERE Name = 'Luke'),
		'2021-01-01');

SELECT * FROM School.Course;

-- multiplicity of a relationship between data/entities
--   1-to-1 (one-to-one)
		-- in SQL: put the data for both entities in the same table/row
		--      or, put it in a separate table, and have a UNIQUE FOREIGN KEY on one of them.

--   1-to-n (one-to-many)
		-- in SQL: two tables, with a FK on the "many" side.

--   n-to-n (many-to-many)
		-- in SQL: "sql doesn't support many-to-many relationship"
		--        we can simulate it with two 1-to-many relationships
		--    introduce a new table, give it two foreign keys to the two preexisting tables.
		--      we call this "join table" or "junction table"


CREATE TABLE School.Student (
	Id INT NOT NULL PRIMARY KEY IDENTITY,
	Name NVARCHAR(150) NOT NULL
);

--DROP TABLE School.CourseStudent;
CREATE TABLE School.CourseStudent (
	CourseId NVARCHAR(30) NOT NULL
		FOREIGN KEY REFERENCES School.Course (Id) ON DELETE CASCADE ON UPDATE CASCADE,
	StudentId INT NOT NULL
		FOREIGN KEY REFERENCES School.Student (Id) ON DELETE CASCADE ON UPDATE CASCADE
	PRIMARY KEY (CourseId, StudentId)
);

INSERT INTO School.Student (Name) VALUES
	('Nick'), ('Fred'), ('Mark');
	
INSERT INTO School.CourseStudent (CourseId, StudentId) VALUES
	('CS-101', (SELECT Id FROM School.Student WHERE Name = 'Nick'));
INSERT INTO School.CourseStudent (CourseId, StudentId) VALUES
	('CS-101', (SELECT Id FROM School.Student WHERE Name = 'Fred'));

DELETE FROM School.Student WHERE Name = 'Nick';

-- FK can be created with ON DELETE and ON UPDATE behaviors
--   to control what happens when the referenced PK value changes/is deleted.

SELECT * FROM School.CourseStudent;

-- indexes
-- data structures that we can have sql server maintain during writes
-- so that reads can be faster.

-- in SQL Server:
   -- clustered index
        -- tells sql server what order to 'physically' arrange the table in.
		-- can only be one
		-- by default, PRIMARY KEY sets CLUSTERED INDEX.
   -- nonclustered index
		-- maintains a separate data structure analogous to an index at the end of
		-- and enyclopedia
		-- we can have many of these.
		-- UNIQUE sets nonclustered index by default

-- you want indexes on the columns/sets of columns that you usually reference
-- in the JOIN or WHERE conditions. (foreign keys are a good candidate)

--Dictionary<int, Data>
--Dictionary<string, List<Data>>