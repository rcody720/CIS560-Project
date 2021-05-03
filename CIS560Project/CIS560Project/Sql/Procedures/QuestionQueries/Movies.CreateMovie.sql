
/* This procedure is responsible for inserting a movie into the Movie table.*/

CREATE OR ALTER PROCEDURE Movies.CreateMovie
   @MovieName NVARCHAR(32),
   @Rating NVARCHAR(32),
   @RunTime INT,
   @ReleaseDate DATETIME,
   @MovieId INT OUTPUT
AS

INSERT Movies.Movie(MovieTitle, Rating, RuntimeMinutes, ReleaseDate)
VALUES(@MovieName, @Rating, @RunTime, @ReleaseDate);

SET @MovieId = SCOPE_IDENTITY();
GO
