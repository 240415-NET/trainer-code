-- DDL
-- Data Definition Language

CREATE DATABASE MovieDb;

GO
CREATE SCHEMA Movie;
GO

-- CREATE TABLE
CREATE TABLE Movie.Movie (
	-- list of columns, constraints, etc.
	-- each column: name, and then type, and then contraints
	MovieId INT NOT NULL
);

SELECT * FROM Movie.Movie;

-- we can use ALTER TABLE to add/delete columns, modify things
ALTER TABLE Movie.Movie ADD
	Title NVARCHAR(200) NOT NULL;

-- DROP TABLE to delete tables entirely
DROP TABLE Movie.Movie;

-- constraints

-- NOT NULL: NULL not allowed in the column.
-- NULL: explicitly allowing NULL for documentation
--   (already there by default) (maybe not really a constraint)
-- PRIMARY KEY
--   (enforces uniqueness and NOT NULL, sets clustered index)
-- UNIQUE: the column cannot have any duplicate values
--   (can be set on sets of columns, as well as just one)
-- DEFAULT: provide a default value for this column.
--   (either this or NULL is necessary when adding a new column
--   to a table that already has data)
-- FOREIGN KEY
--   (can set "cascade" behavior... ON DELETE CASCADE, ON DELETE SET NULL, ON UPDATE ...)
-- CHECK:
--   catch all, any boolean expression you want to write
--   to validate the values in a row. is checked every time a row
--   is updated or inserted.
-- IDENTITY(start=1, increment=1):
--   useful for integer primary keys.
--   prevents inserts or updates on the column, and gives automatic
--   incrementing ID.
--   (it is possible to switch on IDENTITY_INSERT)

--DROP TABLE Movie.Movie;
CREATE TABLE Movie.Movie (
	MovieId INT NOT NULL IDENTITY,
	Title NVARCHAR(200) NOT NULL,
	ReleaseDate DATE NOT NULL,
	DateModified DATETIME2 NOT NULL DEFAULT(GETDATE()),
	Active BIT NOT NULL DEFAULT(1),
	CONSTRAINT PK_MovieId PRIMARY KEY (MovieId),
	CONSTRAINT U_Title_ReleaseDate UNIQUE (Title, ReleaseDate),
	CONSTRAINT CK_DateNotTooEarly CHECK (ReleaseDate > '1900')
);

INSERT INTO Movie.Movie (Title, ReleaseDate) VALUES
	('Avengers: Endgame', '2019');

INSERT INTO Movie.Movie (MovieId, Title, ReleaseDate) VALUES
	(8, 'asdf', '1019');

CREATE TABLE Movie.Genre (
	GenreId INT NOT NULL IDENTITY,
	Name NVARCHAR(100) NOT NULL UNIQUE,
	DateModified DATETIME2 NOT NULL DEFAULT(GETDATE()),
	Active BIT NOT NULL DEFAULT(1)
);

ALTER TABLE Movie.Genre ADD
	CONSTRAINT PK_GenreId PRIMARY KEY (GenreId);

INSERT INTO Movie.Genre (Name) VALUES
	('Action'); -- 1

ALTER TABLE Movie.Movie ADD
	GenreId INT NOT NULL DEFAULT(1),
	CONSTRAINT FK_Movie_Genre FOREIGN KEY (GenreId)
		REFERENCES Movie.Genre (GenreId)
		ON DELETE CASCADE;

ALTER TABLE Movie.Movie DROP
	CONSTRAINT DF__Movie__GenreId__5535A963;

-- computed columns

-- a computed column for the name and date in this format:
--    Name (Year)

--ALTER TABLE Movie.Movie DROP COLUMN FullName;
ALTER TABLE Movie.Movie ADD
	FullName AS (Title + ' (' + CONVERT(NVARCHAR, YEAR(ReleaseDate)) + ')');
-- there is PERSISTED option which will cache the value
-- and avoid recomputing it on every query.

SELECT * FROM Movie.Movie;

-- a view for new releases
GO
CREATE VIEW Movie.NewReleases AS
	SELECT * FROM Movie.Movie
	WHERE DATEDIFF(MONTH, ReleaseDate, GETDATE()) < 6;
GO
-- an option for views, WITH SCHEMABINDING
-- locks underlying table structure

SELECT * FROM Movie.NewReleases;
INSERT INTO Movie.Movie (Title, ReleaseDate, GenreId) VALUES
	('Avengers: Infinity War', '2018', 1);
SELECT * FROM Movie.NewReleases;
SELECT * FROM Movie.Movie;

-- variables
DECLARE @numberofmonths AS INT;
SET @numberofmonths = 6;

-- table-valued variables
DECLARE @my_table AS TABLE ( col1 INT, col2 INT );
INSERT INTO @my_table VALUES (4, 5);

SELECT * FROM @my_table;

-- user-defined functions
GO
CREATE FUNCTION Movie.MoviesReleasedInYear(@year INT)
RETURNS INT
AS
BEGIN
	DECLARE @result INT;

	SELECT @result = COUNT(*)
	FROM Movie.Movie
	WHERE YEAR(ReleaseDate) = @year;

	RETURN @result;
END
GO

SELECT Movie.MoviesReleasedInYear(2018);

-- functions that return rows from some particular table
GO
CREATE FUNCTION Movie.AllMoviesReleasedInYear(@year INT)
RETURNS TABLE
AS
	RETURN (
		SELECT *
		FROM Movie.Movie
		WHERE YEAR(ReleaseDate) = @year
	);
GO

SELECT * FROM Movie.AllMoviesReleasedInYear(2019);

-- functions are for read-only access, no modification of
-- table data permitted

-- triggers
-- for example, we can update "DateModified" column
-- every time any part of the row is changed.

--BEFORE, AFTER, INSTEAD OF
--UPDATE, INSERT, DELETE

GO
CREATE TRIGGER Movie.MovieDateModified ON Movie.Movie
AFTER UPDATE
AS
BEGIN
	-- inside the body here, we have access to two
	-- special table variables, Inserted and Deleted.
	UPDATE Movie.Movie
	SET DateModified = GETDATE()
	WHERE MovieId IN (SELECT MovieId FROM Inserted);
	-- Inserted has the new versions of the updated rows.
END

SELECT * FROM Movie.Movie;

UPDATE Movie.Movie
SET ReleaseDate = '2019-02-01'
WHERE MovieId = 1;

-- (stored) procedures
-- these allow modification to the database
-- but, they can only be executed with EXECUTE statement
-- they do not need to return anything

ALTER TABLE Movie.Movie ADD
	CONSTRAINT CK_NonEmptyTitle CHECK (Title != '');

GO
--DROP PROCEDURE Movie.RenameAllMovies;
CREATE PROCEDURE Movie.RenameAllMovies(@newname NVARCHAR(50), @rowschanged INT OUTPUT)
AS
BEGIN
	-- we have access to a lot of control flow stuff
	IF EXISTS (SELECT * FROM Movie.Movie)
	BEGIN
		BEGIN TRY
			UPDATE Movie.Movie
			SET Title = @newname;
			SELECT @rowschanged = COUNT(*) FROM Movie.Movie;
		END TRY
		BEGIN CATCH
			PRINT 'Not allowed to do that!';
			PRINT ERROR_MESSAGE();
			SET @rowschanged = 0;
		END CATCH
	END
	ELSE
	BEGIN
		SET @rowschanged = 0;
		-- errors in SQL have some metadata to them, 
		RAISERROR('no movies found', 16, 1);
		--THROW 'no movies found', 16, 1;
	END
END

-- we also have WHILE loops

DECLARE @rowschanged INT;

EXECUTE Movie.RenameAllMovies 'Aasdf', @rowschanged;

SELECT @rowschanged;