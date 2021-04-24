CREATE OR ALTER PROCEDURE Movies.RetrieveMovies
AS

SELECT M.MovieName, M.Rating, M.RunTime, M.ReleaseDate
FROM Movies.Movie M
GO