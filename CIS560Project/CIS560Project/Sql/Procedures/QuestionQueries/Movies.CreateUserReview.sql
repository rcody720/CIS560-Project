
/*This procedure is responsible for merging user reviews.*/

CREATE OR ALTER PROCEDURE Movies.CreateUserReview
   @Score FLOAT,
   @MovieTitle NVARCHAR(128),
   @Username NVARCHAR(32)
AS

DECLARE @ReviewerId INT;

WITH SourceCte(MovieID, ReviewerID, Score) AS 
(
    SELECT M.MovieID, R.ReviewerId, @Score
    FROM Movies.Movie M
        LEFT JOIN Movies.Reviewer R ON R.Username = @Username
    WHERE M.MovieTitle = @MovieTitle
)

MERGE Movies.MovieReview T
USING SourceCte S ON T.MovieID = S.MovieID AND T.ReviewerId = S.ReviewerID
WHEN MATCHED 
    AND(
        T.ReviewerId <> s.ReviewerID
        )THEN
    UPDATE
    SET 
        Score = S.Score
WHEN NOT MATCHED THEN
    INSERT(MovieID, ReviewerID, Score)
    VALUES(S.MovieID, S.ReviewerID, @Score);
GO