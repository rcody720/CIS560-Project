CREATE OR ALTER PROCEDURE Person.CreatePerson
   @MovieName NVARCHAR(32),
   @Rating NVARCHAR(32),
   @RunTime INT,
   @ReleaseDate DATETIME,
   @MovieId INT OUTPUT
AS

INSERT Movies.Movie(MovieName, Rating, RunTime, ReleaseDate)
VALUES(@MovieName, @Rating, @RunTime, @ReleaseDate);

SET @MovieId = SCOPE_IDENTITY();
GO