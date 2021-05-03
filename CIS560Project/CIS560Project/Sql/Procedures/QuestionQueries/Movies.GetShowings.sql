
/*This procedure is responsible for finding all the movie titles, theater names, and showtimes for a given date.*/

CREATE OR ALTER PROCEDURE Movies.GetShowings 
    @Date DATE
AS

SELECT M.MovieTitle, T.TheaterName, MT.ShowTime
FROM Movies.MovieTheater MT
    JOIN Movies.Movie M ON M.MovieId = MT.MovieId
    JOIN Movies.Theater T ON T.TheaterId = MT.TheaterId
WHERE MT.ShowingFromDate < @Date AND MT.ShowingToDate > @Date