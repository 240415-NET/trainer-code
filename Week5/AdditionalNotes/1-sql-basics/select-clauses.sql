-- SELECT clauses
	-- SELECT
	-- FROM
	-- WHERE

--SELECT (some set of columns)
--FROM (a table)
--WHERE (the column values meet some condition)

-- get the full names of everyone whose name is John
SELECT FirstName, LastName
FROM SalesLT.Customer
WHERE FirstName = 'John';

-- "the SELECT list" can have any expression

-- (in SQL, indexes are 1-based)
SELECT 1 AS One, CURRENT_TIMESTAMP, SUBSTRING(FirstName, 1, 1), FirstName + ' ' + LastName AS [Full Name]
FROM SalesLT.Customer
WHERE FirstName = 'John';

-- in T-SQL, we can "escape spaces" in an identifier with double quotes or with brackets.

-- the number of times each first name occurs.
SELECT COUNT(*) AS Number, FirstName
FROM SalesLt.Customer
GROUP BY FirstName;

-- COUNT((anything)), when GROUP BY is around,
-- means, the number of rows that were combined into the given result row.

-- when we use GROUP BY, several rows are combined into one, when
-- they share the same values for all the "GROUP BY" listed columns.

-- GROUP BY runs after WHERE, so aggregate functions are not allowed in WHERE.
-- if we want to filter AGAIN, after the aggregation,
-- we have HAVING.

-- the number of times each first name (except John) occurs, if at least 3.
SELECT COUNT(*) AS Number, FirstName
FROM SalesLt.Customer
WHERE FirstName != 'John'
GROUP BY FirstName
HAVING COUNT(*) >= 3;

-- ORDER BY to sort the result set.

-- number of duplicates of first names besides John, if at least 3,
-- sorted by number and by first name alphabetically.
SELECT COUNT(*) AS Number, FirstName
FROM SalesLt.Customer
WHERE FirstName != 'John'
GROUP BY FirstName
HAVING COUNT(*) >= 3
ORDER BY Number DESC, FirstName;

-- if we wanted descending order for any of the orderings,
-- we would add "DESC"

-- DISTINCT filters 100% duplicate rows from the result.

-- TOP(n)
--   e.g. to get the max result for some value, order by that value DESC, then use TOP(1)

-- logical order of execution of a SELECT statement

-- 1. FROM
-- 2. WHERE
-- 3. GROUP BY
-- 4. HAVING
-- 5. SELECT
-- 6. ORDER BY
