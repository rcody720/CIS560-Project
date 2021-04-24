CREATE OR ALTER PROCEDURE Movies.RetrieveMovies
AS

SELECT M.MovieTitle, M.Rating, M.RuntimeMinutes, M.ReleaseDate
FROM Movies.Movie M
GO