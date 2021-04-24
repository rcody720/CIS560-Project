CREATE OR ALTER PROCEDURE Movies.GetMovie
   @MovieName NVARCHAR(128)
AS

SELECT M.MovieName, M.Rating, M.RunTime, M.ReleaseDate
FROM Movies.Movie M
WHERE M.MovieName = @MovieName;
GO