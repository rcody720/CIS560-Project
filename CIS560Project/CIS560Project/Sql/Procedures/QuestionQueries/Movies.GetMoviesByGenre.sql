CREATE OR ALTER PROCEDURE Movies.GetMoviesByGenre
	@Genre NVARCHAR
AS

SELECT M.MovieTitle, M.Rating, M.RuntimeMinutes, M.ReleaseDate
FROM Movies.Genre G
	INNER JOIN Movies.MovieGenre MG ON G.GenreID = MG.GenreID
	INNER JOIN Movies.Movie M ON MG.MovieID = M.MovieID
WHERE G.GenreName = @Genre