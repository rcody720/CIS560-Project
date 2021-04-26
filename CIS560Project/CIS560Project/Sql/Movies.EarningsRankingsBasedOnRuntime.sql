WITH TheaterSales(MovieId, TicketSales) AS
(
    SELECT DISTINCT M.MovieId, SUM(MT.TicketsSold * T.TicketPrice) OVER(PARTITION BY MT.MovieId) AS 'TicketsSold'
    FROM Movies.Movie M
        JOIN Movies.MovieTheater MT ON MT.MovieId = M.MovieId
        JOIN Movies.Theater T ON T.TheaterId = MT.TheaterId
)

SELECT M.MovieTitle, TS.TicketSales,
RANK() OVER(ORDER BY TS.TicketSales) AS 'Less than 90 minute movies'
FROM Movies.Movie M
    JOIN TheaterSales TS ON TS.MovieId = M.MovieId
WHERE M.RuntimeMinutes < 90;
GO

WITH TheaterSales(MovieId, TicketSales) AS
(
    SELECT DISTINCT M.MovieId, SUM(MT.TicketsSold * T.TicketPrice) OVER(PARTITION BY MT.MovieId) AS 'TicketsSold'
    FROM Movies.Movie M
        JOIN Movies.MovieTheater MT ON MT.MovieId = M.MovieId
        JOIN Movies.Theater T ON T.TheaterId = MT.TheaterId
)
SELECT M.MovieTitle, TS.TicketSales, 
RANK() OVER(ORDER BY TS.TicketSales) AS 'Between 90 and 120 minute movies'
FROM Movies.Movie M
    JOIN TheaterSales TS ON TS.MovieId = M.MovieId
WHERE M.RuntimeMinutes >= 90 AND M.RuntimeMinutes <= 120;
GO

WITH TheaterSales(MovieId, TicketSales) AS
(
    SELECT DISTINCT M.MovieId, SUM(MT.TicketsSold * T.TicketPrice) OVER(PARTITION BY MT.MovieId) AS 'TicketsSold'
    FROM Movies.Movie M
        JOIN Movies.MovieTheater MT ON MT.MovieId = M.MovieId
        JOIN Movies.Theater T ON T.TheaterId = MT.TheaterId
)
SELECT M.MovieTitle, TS.TicketSales, M.RuntimeMinutes,
RANK() OVER(ORDER BY TS.TicketSales) AS 'More than 120 minute movies'
FROM Movies.Movie M
    JOIN TheaterSales TS ON TS.MovieId = M.MovieId
WHERE M.RuntimeMinutes > 120;
GO