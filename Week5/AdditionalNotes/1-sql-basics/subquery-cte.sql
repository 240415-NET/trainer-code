-- subqueries are another way to combine data from multiple tables
-- besides joins and set operators.

-- every JOIN query can be converted into a subquery-based query.

-- we just use queries inside other queries... with the help of some operators
-- IN, NOT IN, ANY, ALL, EXISTS

-- every track that has never been purchased.
SELECT TrackId, Name
FROM Track
WHERE TrackId NOT IN (
	SELECT TrackId
	FROM InvoiceLine
);

-- the track that has been bought the most times
-- (break ties with lower track id)
SELECT Name
FROM Track
WHERE TrackId = (
	SELECT TOP(1) TrackId
	FROM InvoiceLine
	GROUP BY TrackId
	ORDER BY SUM(Quantity) DESC, TrackId
);

-- similar to subquery is "common table expression" (CTE)
WITH PurchasedTracks AS (
	SELECT TrackId
	FROM InvoiceLine
)
SELECT TrackId, Name
FROM Track
WHERE TrackId NOT IN (
	SELECT * FROM PurchasedTracks
);

-- ANY/ALL

-- the artist(s) who made the album with the longest title
SELECT *
FROM Artist
WHERE ArtistId IN (
	SELECT ArtistId
	FROM Album
	WHERE LEN(Title) >= ALL (
		SELECT LEN(Title) FROM ALbum
	)
);

