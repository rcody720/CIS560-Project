CREATE OR ALTER PROCEDURE Movies.GetMoviesByDirector
	@DirectorFirst NVARCHAR(32),
	@DirectorLast NVARCHAR(32)
AS

SELECT M.MovieId, M.MovieTitle, M.Rating, M.RuntimeMinutes, M.ReleaseDate
FROM Movies.Movie M
	JOIN Movies.MovieDirector MD ON MD.MovieId = M.MovieId
	JOIN Movies.Director D ON D.DirectorId = MD.DirectorId
WHERE D.FirstName = @DirectorFirst AND D.LastName = @DirectorLast