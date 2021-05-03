CREATE OR ALTER PROCEDURE Movies.EarningsRankingsBasedOnRuntime AS
WITH TheaterSales(MovieId, TicketSales, MovieLength) AS
(
    SELECT DISTINCT M.MovieId, SUM(MT.TicketsSold * T.TicketPrice) OVER(PARTITION BY MT.MovieId) AS 'TicketsSold',
    CASE
    WHEN M.RuntimeMinutes < 90 THEN 'The Movie is Less Than 90 Minutes'
    WHEN M.RuntimeMinutes >= 90 AND M.RuntimeMinutes <= 120 THEN 'This Movie is Between 90 and 120 Minutes'
    WHEN M.RuntimeMinutes >120 THEN 'This Movie is Longer Than 120 minutes'
END AS MovieLength
    FROM Movies.Movie M
        JOIN Movies.MovieTheater MT ON MT.MovieId = M.MovieId
        JOIN Movies.Theater T ON T.TheaterId = MT.TheaterId
)

SELECT M.MovieTitle, TS.TicketSales, TS.MovieLength,
RANK() OVER(PARTITION BY MovieLength ORDER BY TicketSales DESC) AS MovieRank
FROM Movies.Movie M
    JOIN TheaterSales TS ON TS.MovieId = M.MovieId