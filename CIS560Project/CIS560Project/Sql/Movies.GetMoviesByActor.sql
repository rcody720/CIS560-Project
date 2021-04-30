CREATE OR ALTER PROCEDURE Movies.GetMoviesByActor
	@ActorFirst NVARCHAR(32),
	@ActorLast NVARCHAR(32)
AS

SELECT M.MovieId, M.MovieTitle, M.Rating, M.RuntimeMinutes, M.ReleaseDate
FROM Movies.Actor A
	INNER JOIN MovieActor MA ON A.ActorID = MA.ActorID
	INNER JOIN Movie M ON MA.MovieID = M.MovieID
WHERE A.FirstName = @ActorFirst AND A.LastName = @ActorLast