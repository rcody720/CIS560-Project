CREATE OR ALTER PROCEDURE Movies.GetMoviesByDirector
	@DirectorFirst NVARCHAR,
	@DirectorLast NVARCHAR
AS

SELECT M.MovieTitle, M.Rating, M.RuntimeMinutes, M.ReleaseDate
FROM Movies.Director D
	INNER JOIN MovieDirector MD ON M.DirectorID = MD.DirectorID
	INNER JOIN Movie M ON MD.MovieID = M.MovieID
WHERE D.FirstName = @DirectorFirst AND D.LastName = @DirectorLast