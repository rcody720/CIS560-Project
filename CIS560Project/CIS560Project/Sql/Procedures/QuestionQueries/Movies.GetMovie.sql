CREATE OR ALTER PROCEDURE Movies.GetMovie
   @MovieName NVARCHAR(128)
AS

SELECT M.MovieTitle, M.Rating, M.RuntimeMinutes, M.ReleaseDate
FROM Movies.Movie M
WHERE M.MovieTitle = @MovieName;
GO