CREATE OR ALTER PROCEDURE Movies.CreateUserReview
   @Score FLOAT,
   @MovieTitle NVARCHAR,
   @Username NVARCHAR,
   @MovieId INT OUTPUT,
   @ReviewerId INT OUTPUT
AS

/*INSERT Movies.UserReviews(MovieID, ReviewerID, Score)
SELECT M.MovieID, R.ReviewerID, @Score
FROM Movies.Reviewer R
    CROSS JOIN Movies.Movie M
WHERE M.MovieTitle = @MovieTitle AND R.Username = @Username*/

WITH SourceCte(MovieID, ReviewerID, Score) AS 
(
    SELECT M.MovieID, R.ReviewerID, @Score
    FROM Movies.Reviewer R
        INNER JOIN Movies.UserReviews UR ON R.ReviewerID = UR.ReviewerID
        INNER JOIN Movies.Movie M ON M.MovieID = UR.MovieID
    WHERE M.MovieTitle = @MovieTitle AND R.Username = @Username
)

MERGE Movies.UserReviews T
USING SourceCte S ON T.MovieID = S.MovieID AND T.ReviewerID = S.ReviewerID
WHEN MATCHED THEN
    UPDATE
    SET 
        Score = S.Score
WHEN NOT MATCHED THEN
    INSERT(MovieID, ReviewerID, Score)
    VALUES(S.MovieID, S.ReviewerID, S.Score);
    SET @MovieId = S.MovieID,
        @ReviewerID = S.ReviewerID
GO