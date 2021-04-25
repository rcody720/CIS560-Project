WITH TicketsSold(MovieId, TicketSales) AS
(
    SELECT M.MovieId, SUM(MT.TicketsSold * T.TicketPrice) OVER(PARTITION BY MT.MovieId) AS 'TicketsSold'
    FROM Movies.Movie M
        JOIN Movies.MovieTheater MT ON MT.MovieId = M.MovieId
        JOIN Movies.Theater T ON T.TheaterId = MT.TheaterId
)

SELECT M.MovieTitle, TS.TicketSales AS TheaterSales,
RANK() OVER(ORDER BY TS.TicketSales DESC) AS TheaterSalesRank
FROM Movies.Movie M
    JOIN TicketsSold TS ON TS.MovieId = M.MovieId
GROUP BY M.MovieTitle, TS.TicketSales