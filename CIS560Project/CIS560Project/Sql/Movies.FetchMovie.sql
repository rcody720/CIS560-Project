CREATE OR ALTER PROCEDURE Movies.FetchMovie
   @MovieId INT
AS

SELECT M.MovieName, M.Rating, M.RunTime, M.ReleaseDate
FROM Movies.Movie M
WHERE M.MovieId = @MovieId;
GO