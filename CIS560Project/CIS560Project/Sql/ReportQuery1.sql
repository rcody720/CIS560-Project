WITH MovieRating(MovieId, Rating) AS 
(
    SELECT M.MovieId, (SUM(MR.Score)/COUNT(MR.Score)) AS Rating 
    FROM Movies.Movie M
        JOIN Movies.MovieReview MR ON MR.MovieId = M.MovieId
    GROUP BY M.MovieId, M.MovieTitle, Rating
)

SELECT M.MovieId, M.MovieTitle, M.ReleaseDate, M.RuntimeMinutes, MR.Rating,
RANK() OVER(PARTITION BY YEAR(M.ReleaseDate) ORDER BY MR.Rating DESC) AS ThisYearRank,
T.TheaterName
FROM Movies.Movie M
    JOIN MovieRating MR ON MR.MovieId = M.MovieId
    JOIN Movies.MovieTheater MT ON MT.MovieId = M.MovieId
    JOIN Movies.Theater T ON MT.TheaterId = T.TheaterId
WHERE YEAR(M.ReleaseDate) = YEAR(SYSDATETIME())
GROUP BY M.MovieId, M.MovieTitle, MR.Rating, M.ReleaseDate, M.ReleaseDate, M.RuntimeMinutes, T.TheaterName
ORDER BY Rating DESC;
GO

WITH MovieRating(MovieId, Rating) AS 
(
    SELECT M.MovieId, (SUM(MR.Score)/COUNT(MR.Score)) AS Rating 
    FROM Movies.Movie M
        JOIN Movies.MovieReview MR ON MR.MovieId = M.MovieId
    GROUP BY M.MovieId, M.MovieTitle, Rating
)

SELECT M.MovieId, M.MovieTitle, M.ReleaseDate, M.RuntimeMinutes, MR.Rating,
RANK() OVER(ORDER BY MR.Rating DESC) AS OverallRank,
T.TheaterName
FROM Movies.Movie M
    JOIN MovieRating MR ON MR.MovieId = M.MovieId
    JOIN Movies.MovieTheater MT ON MT.MovieId = M.MovieId
    JOIN Movies.Theater T ON MT.TheaterId = T.TheaterId
GROUP BY M.MovieId, M.MovieTitle, MR.Rating, M.ReleaseDate, M.ReleaseDate, M.RuntimeMinutes, T.TheaterName
ORDER BY OverallRank;
GO