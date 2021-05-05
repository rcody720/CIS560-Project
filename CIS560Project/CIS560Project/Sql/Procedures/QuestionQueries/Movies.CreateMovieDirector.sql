
/*This procedure is responsible for inserting the link between a movie and a director.*/

CREATE OR ALTER PROCEDURE Movies.CreateMovieDirector
	@DirectorFirst NVARCHAR(32),
	@DirectorLast NVARCHAR(32),
	@DirectorSalary FLOAT,
	@MovieTitle NVARCHAR(128)
AS

WITH SourceCTE(MovieID, DirectorID, Salary) AS
(
	SELECT M.MovieID, D.DirectorID, @DirectorSalary
	FROM Movies.Movie M
		LEFT JOIN Movies.Director D ON D.FirstName = @DirectorFirst AND D.LastName = @DirectorLast
	WHERE M.MovieTitle = @MovieTitle
)

INSERT Movies.MovieDirector(MovieID, DirectorID, Salary)
SELECT S.MovieID, S.DirectorID, S.Salary
FROM SourceCTE S