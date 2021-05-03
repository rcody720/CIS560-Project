
/*This procedure is responsible for retrieving all of the movies in the database.*/

CREATE OR ALTER PROCEDURE Movies.RetrieveMovies
AS

SELECT M.MovieId, M.MovieTitle, M.Rating, M.RuntimeMinutes, M.ReleaseDate
FROM Movies.Movie M
GO