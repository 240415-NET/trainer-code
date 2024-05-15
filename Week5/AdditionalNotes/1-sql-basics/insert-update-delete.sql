-- INSERT, UPDATE, and DELETE
-- the rest of DML

SELECT Name
FROM SalesLT.ProductModel;

-- INSERT
-- when we insert into a table, we need to provide a value for
-- all columns that are not nullable and that have no default configured.
INSERT INTO SalesLT.ProductModel (Name, CatalogDescription) VALUES
	('Coffee pot S', NULL),
	('Coffee pot M', NULL),
	('Coffee pot L', NULL);

-- add a duplicate product for the product with the longest name.
-- (well, it would if that column did not have UNIQUE constraint.)
INSERT INTO SalesLT.ProductModel (Name, CatalogDescription)
	SELECT TOP(1) Name, CatalogDescription FROM SalesLT.ProductModel
	ORDER BY LEN(Name) DESC;

-- update EVERY product's name
UPDATE SalesLT.ProductModel
SET Name = 'Coffee pot XS'

-- update one product's name
UPDATE SalesLT.ProductModel
SET Name = 'Coffee pot XS'
WHERE Name = 'Coffee pot S';

-- delete ALL rows of table
DELETE FROM SalesLT.ProductModel;

-- delete one product
DELETE FROM SalesLT.ProductModel
WHERE Name = 'Coffee pot L';

-- DML is all the commands that work directly with rows.

-- TRUNCATE TABLE

-- empty the table of all rows
-- (leaving behind column definitions, constraints, triggers, etc.)
TRUNCATE TABLE SalesLT.Customer;

