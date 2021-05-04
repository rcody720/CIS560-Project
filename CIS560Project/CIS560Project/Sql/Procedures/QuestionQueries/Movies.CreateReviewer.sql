CREATE OR ALTER PROCEDURE Movies.CreateReviewer
    @Username NVARCHAR(32)
AS

INSERT Movies.Reviewer(Username)
SELECT @Username
WHERE NOT EXISTS (SELECT * FROM Movies.Reviewer R WHERE R.Username = @Username)