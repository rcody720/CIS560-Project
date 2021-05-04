
/*This procedure is responsible for finding the most popular directors according to the average scores of their directed movies,
partitioning them by the number of movies they've directed.*/

CREATE OR ALTER PROCEDURE Movies.DirectorRatings AS
WITH DirectorRanks(DirectorId, Rating, NumMovies, DirectorStatus) AS
(
    SELECT DISTINCT D.DirectorId, SUM(MR.Score) OVER(PARTITION BY D.DirectorId), (COUNT(MD.MovieId) OVER(PARTITION BY D.DirectorId)) AS NumMovies,
    Case
        WHEN (COUNT(MD.MovieId) OVER(PARTITION BY D.DirectorId)) > 10 THEN '1: Veteran Director'
        WHEN (COUNT(MD.MovieId) OVER(PARTITION BY D.DirectorId)) > 5 THEN '2: Experienced Director'
        WHEN (COUNT(MD.MovieId) OVER(PARTITION BY D.DirectorId)) > 1 THEN '3: Premering Director'
        WHEN (COUNT(MD.MovieId) OVER(PARTITION BY D.DirectorId)) = 0 THEN '4: No Movies'
    END AS DirectorStatus
    FROM Movies.Director D
        LEFT JOIN Movies.MovieDirector MD ON MD.DirectorId = D.DirectorId
        LEFT JOIN Movies.Movie M ON M.MovieId = MD.MovieId
        LEFT JOIN Movies.MovieReview MR ON MR.MovieId = M.MovieId
)

SELECT D.DirectorId, D.Firstname, D.FirstName, D.LastName, (DR.Rating / DR.NumMovies) AS DirectorRating, DR.DirectorStatus,
RANK() OVER(PARTITION BY DR.DirectorStatus ORDER BY DR.Rating / DR.NumMovies DESC) AS Popularity
FROM Movies.Director D
    RIGHT JOIN DirectorRanks DR ON DR.DirectorId = D.DirectorId
ORDER BY DirectorStatus