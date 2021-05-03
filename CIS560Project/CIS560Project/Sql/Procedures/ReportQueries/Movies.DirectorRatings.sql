CREATE OR ALTER PROCEDURE Movies.DirectorRatings AS
WITH DirectorRanks(DirectorId, Rating, NumMovies) AS
(
    SELECT DISTINCT D.DirectorId, SUM(MR.Score) OVER(PARTITION BY D.DirectorId), COUNT(MD.MovieId) OVER(PARTITION BY D.DirectorId)
    FROM Movies.Director D
        LEFT JOIN Movies.MovieDirector MD ON MD.DirectorId = D.DirectorId
        LEFT JOIN Movies.Movie M ON M.MovieId = MD.MovieId
        LEFT JOIN Movies.MovieReview MR ON MR.MovieId = M.MovieId
)

SELECT D.DirectorId, D.Firstname, D.FirstName, D.LastName, (DR.Rating / DR.NumMovies) AS DirectorRating,
RANK() OVER(ORDER BY DR.Rating / DR.NumMovies DESC) AS Popularity
FROM Movies.Director D
    RIGHT JOIN DirectorRanks DR ON DR.DirectorId = D.DirectorId
ORDER BY Popularity