
/*This procedure is responsible for finding the current highest scored movies.*/

CREATE OR ALTER PROCEDURE Movies.GetRecentMovies AS
WITH MovieRating(MovieId, UserScore) AS 
(
    SELECT M.MovieId, (SUM(MR.Score)/COUNT(MR.Score)) AS UserScore 
    FROM Movies.Movie M
        JOIN Movies.MovieReview MR ON MR.MovieId = M.MovieId
    GROUP BY M.MovieId, M.MovieTitle
)

SELECT M.MovieId, M.MovieTitle, M.Rating, M.ReleaseDate, M.RuntimeMinutes, MR.UserScore,
RANK() OVER(PARTITION BY YEAR(M.ReleaseDate) ORDER BY MR.UserScore DESC) AS ThisYearRank
FROM Movies.Movie M
    JOIN MovieRating MR ON MR.MovieId = M.MovieId
    JOIN Movies.MovieTheater MT ON MT.MovieId = M.MovieId
GROUP BY M.MovieId, M.MovieTitle, MR.UserScore, M.ReleaseDate, M.ReleaseDate, M.RuntimeMinutes, M.Rating
ORDER BY UserScore DESC;
GO