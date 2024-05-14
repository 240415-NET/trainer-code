-- On the Chinook DB, practice writing queries with the following exercises

-- List all customers (full name, customer id, and country) who are not in the USA

-- List all customers from Brazil

-- List all sales agents

-- Retrieve a list of all countries in billing addresses on invoices

-- Retrieve how many invoices there were in 2009, and what was the sales total for that year?
    -- (challenge: find the invoice count sales total for every year using one query)

-- how many line items were there for invoice #37

-- how many invoices per country?

-- Retrieve the total sales per country, ordered by the highest total sales first.



-- JOINS CHALLENGES
-- Show all invoices of customers from brazil (mailing address not billing)

-- Show all invoices together with the name of the sales agent for each one

-- Show all playlists ordered by the total number of tracks they have

-- Which sales agent made the most sales in 2009?

-- How many customers are assigned to each sales agent?

-- Which track was purchased the most ing 20010?

-- Show the top three best selling artists.

-- Which customers have the same initials as at least one other customer?



-- solve these with a mixture of joins, subqueries, CTE, and set operators.
-- solve at least one of them in two different ways, and see if the execution
-- plan for them is the same, or different.

-- 1. which artists did not make any albums at all?

-- 2. which artists did not record any tracks of the Latin genre?

-- Artist has ArtistID and NAME
-- Track has AlbumID, GenreID
-- Album has ArtistID and AlbumID
-- Genre has GenreID and Name (Latin = 7)

SELECT COUNT(DISTINCT Artist.Name + Genre.Name)
FROM Track 
INNER JOIN Album on Track.AlbumId = Album.AlbumID
INNER JOIN Artist on Album.ArtistID = Artist.ArtistId
INNER JOIN Genre on Track.GenreID = Genre.GenreId
WHERE Genre.Name != 'Latin';

-- 3. which video track has the longest length? (use media type table)

-- 4. find the names of the customers who live in the same city as the
--    boss employee (the one who reports to nobody)

-- 5. how many audio tracks were bought by German customers, and what was
--    the total price paid for them?

-- 6. list the names and countries of the customers supported by an employee
--    who was hired younger than 35.


-- DML exercises

-- 1. insert two new records into the employee table.

-- 2. insert two new records into the tracks table.

-- 3. update customer Aaron Mitchell's name to Robert Walter

-- 4. delete one of the employees you inserted.

-- 5. delete customer Robert Walter.



--schema 
-- dbo is the default schema

-- Create Schema newschema;
-- CREATE TABLE NewTable;
-- SELECT * FROM newschema.NewTable;


SELECT * FROM dbo.Customer;

SELECT FirstName From Customer WHERE LEN(FirstName) = 6;

-- User-Defined Functions
-- Functions CAN NOT modify the data of a table, they are "read-only"
-- Only really useful for SELECT statements

Go --use GO to "batch" your statements
CREATE FUNCTION dbo.TotalNumberOfCustomers()
RETURNS INT
AS
    BEGIN  
        DECLARE @result INT;
        SELECT @result = COUNT(*) FROM dbo.Customer;
        RETURN @result;
    END
GO

SELECT dbo.TotalNumberOfCustomers();

SELECT COUNT(*) FROM dbo.Customer;


GO
CREATE FUNCTION dbo.CustomersWithFirstNameLengthOf( @length INT )
RETURNS TABLE -- Stored / user defined functions can return an entire table
AS
    RETURN( SELECT * FROM dbo.Customer WHERE LEN(FirstName) = @length);
GO

-- use the select statement on the return from the function, because IT IS A TABLE!
SELECT FirstName FROM dbo.CustomersWithFirstNameLengthOf(7);


-- Stored Procedures are similar to a function, except that they CAN modify the database.
GO
CREATE OR ALTER PROCEDURE dbo.UpdateAllCustomers(@postalcode INT, @modified INT OUTPUT) -- use OUTPUT as a parameter to take the place of a RETURN
AS
BEGIN
    BEGIN TRY
        IF (NOT EXISTS (SELECT * FROM dbo.Customer))
        BEGIN
            RAISERROR ('No data found in table',15, 1);
        END
        SET @modified = (SELECT COUNT(*) FROM dbo.Customer);
        UPDATE dbo.Customer SET PostalCode = @postalcode;
    END TRY
    BEGIN CATCH
        PRINT 'ERROR'
    END CATCH
END
GO


SELECT PostalCode FROM dbo.Customer;

DECLARE @result INT;
EXECUTE dbo.UpdateAllCustomers 98765, @result OUTPUT;
SELECT @result;

SELECT PostalCode FROM dbo.Customer;


-- Triggers

-- Some code that will run instead of, or after
-- you insert, update, or delete to a specified table

GO
CREATE TRIGGER Playlist.DateModified ON Playlist.Name
AFTER UPDATE
AS
    BEGIN
        UPDATE Playlist.Name
        SET DateModified = SYSUTCDATETIME() -- the SQL way to retireve the current system date time convert to the UTC region
        WHERE Id IN (SELECT Id FROM Inserted) --triggers get access to two special table-valued variables, Inserted and Deleted.
    END
GO

GO
CREATE TRIGGER PreventDelete ON dbo.Playlist
INSTEAD OF DELETE
AS
    BEGIN TRY
    BEGIN
        RAISERROR('Delete not authorized', 15, 1)
    END
    END TRY
    BEGIN CATCH
        PRINT 'ERROR'
    END CATCH
GO