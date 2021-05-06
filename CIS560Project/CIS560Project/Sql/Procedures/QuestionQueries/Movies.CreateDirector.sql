
/*This procedure is responsible for inserting a director*/

CREATE OR ALTER PROCEDURE Movies.CreateDirector
	@DirectorFirst NVARCHAR(32),
	@DirectorLast NVARCHAR(32)
AS

INSERT Movies.Director(FirstName, LastName)
SELECT @DirectorFirst, @DirectorLast
WHERE NOT EXISTS (SELECT * FROM Movies.Director D WHERE D.FirstName = @DirectorFirst AND D.LastName = @DirectorLast)