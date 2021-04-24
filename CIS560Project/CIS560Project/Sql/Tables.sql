CREATE SCHEMA [Movies] AUTHORIZATION [dbo];
GO

DROP TABLE IF EXISTS Movies.MovieGenre
DROP TABLE IF EXISTS Movies.MovieReview
DROP TABLE IF EXISTS Movies.MovieTheater
DROP TABLE IF EXISTS Movies.MovieDirector
DROP TABLE IF EXISTS Movies.MovieActor
DROP TABLE IF EXISTS Movies.Movie
DROP TABLE IF EXISTS Movies.Theater
DROP TABLE IF EXISTS Movies.Director
DROP TABLE IF EXISTS Movies.Actor
DROP TABLE IF EXISTS Movies.Genre
DROP TABLE IF EXISTS Movies.Reviewer

CREATE TABLE Movies.Movie
(
    MovieId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    MovieTitle NVARCHAR(128) NOT NULL,
    Rating NVARCHAR(32),
    RuntimeMinutes INT,
    ReleaseDate DATE
)

CREATE TABLE Movies.Theater
(
    TheaterId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    TheaterName NVARCHAR(64) NOT NULL,
    TicketPrice FLOAT NOT NULL
)

CREATE TABLE Movies.Genre
(
    GenreId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    GenreName NVARCHAR(32)
)

CREATE TABLE Movies.Director
(
    DirectorId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    FirstName NVARCHAR(32) NOT NULL,
    LastName NVARCHAR(32) NOT NULL
)

CREATE TABLE Movies.Actor
(
    ActorId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    FirstName NVARCHAR(32) NOT NULL,
    LastName NVARCHAR(32) NOT NULL
)

CREATE TABLE Movies.Reviewer
(
    ReviewerId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    [Username] NVARCHAR(32) NOT NULL
)

CREATE TABLE Movies.MovieGenre
(
    MovieId INT NOT NULL,
    GenreId INT NOT NULL,

    FOREIGN KEY(MovieId)
    REFERENCES Movies.Movie(MovieId),
    FOREIGN KEY(GenreId)
    REFERENCES Movies.Genre(GenreId)
)

CREATE TABLE Movies.MovieReview
(
    MovieId INT NOT NULL,
    ReviewerId INT NOT NULL,
    Score FLOAT,

    FOREIGN KEY(MovieId)
    REFERENCES Movies.Movie(MovieId),
    FOREIGN KEY(ReviewerId)
    REFERENCES Movies.Reviewer(ReviewerId)
)

CREATE TABLE Movies.MovieDirector
(
    MovieId INT NOT NULL,
    DirectorId INT NOT NULL,
    Salary INT

    FOREIGN KEY(MovieId)
    REFERENCES Movies.Movie(MovieId),
    FOREIGN KEY(DirectorId)
    REFERENCES Movies.Director(DirectorId)
)

CREATE TABLE Movies.MovieActor
(
    MovieId INT NOT NULL,
    ActorId INT NOT NULL,
    Salary INT NOT NULL,

    FOREIGN KEY(MovieId)
    REFERENCES Movies.Movie(MovieId),
    FOREIGN KEY(ActorId)
    REFERENCES Movies.Actor(ActorId)
)

CREATE TABLE Movies.MovieTheater
(
    MovieId INT NOT NULL,
    TheaterId INT NOT NULL,
    TicketsSold INT,
    ShowTime NVARCHAR(32),
    ShowingFromDate DATE,
    ShowingToDate DATE,

    FOREIGN KEY(MovieId)
    REFERENCES Movies.Movie(MovieId),
    FOREIGN KEY(TheaterId)
    REFERENCES Movies.Theater(TheaterId)
)