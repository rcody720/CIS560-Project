
/*This procedure is responsible for finding a movie with the given MovieId.*/

CREATE OR ALTER PROCEDURE Movies.FetchMovie
   @MovieId INT
AS

SELECT M.MovieTitle, M.Rating, M.RuntimeMinutes, M.ReleaseDate
FROM Movies.Movie M
WHERE M.MovieId = @MovieId;
GO