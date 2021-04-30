CREATE OR ALTER PROCEDURE Movies.CreateUserReview
   @Score FLOAT,
   @MovieTitle NVARCHAR,
   @Username NVARCHAR,
   @MovieId INT OUTPUT,
   @ReviewerId INT OUTPUT
AS

WITH SourceCte(MovieID, ReviewerID, Score) AS 
(
    SELECT M.MovieID, R.ReviewerID, @Score
    FROM Movies.Movie M
        INNER JOIN Movies.Reviewer R ON R.Username = @Username
    WHERE M.MovieTitle = @MovieTitle
)

MERGE Movies.MovieReview T
USING SourceCte S ON T.MovieID = S.MovieID AND T.ReviewerID = S.ReviewerID
WHEN MATCHED THEN
    UPDATE
    SET 
        Score = S.Score,
        @MovieId = S.MovieID,
        @ReviewerId = S.ReviewerID
WHEN NOT MATCHED THEN
    INSERT(MovieID, ReviewerID, Score)
    VALUES(S.MovieID, S.ReviewerID, S.Score);
GO