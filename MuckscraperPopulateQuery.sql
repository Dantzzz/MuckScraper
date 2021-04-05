
--DROP DATABASE IF EXISTS MuckScraper;
--CREATE DATABASE Muckscraper;
USE Muckscraper;

DROP TABLE IF EXISTS Users;
CREATE TABLE Users
(
	UserId INT PRIMARY KEY,
	Username NVARCHAR(30),
	RegistrationDate DATETIME,
	[password] NVARCHAR(30),
	LastLoginDate DATETIME,
	Credentials BIT,
	PrimaryEmail NVARCHAR(50)
)

DROP TABLE IF EXISTS Profiles
CREATE TABLE Profiles
(
	UserId NVARCHAR(30) FOREIGN KEY,
	FirstName NVARCHAR(30) NOT NULL,
	LastName NVARCHAR(30) NOT NULL,
	MiddleName NVARCHAR(30),
	Photo NVARCHAR(80)
)


DROP TABLE IF EXISTS Article
CREATE TABLE Article
(
	ArticleId INT PRIMARY KEY,
	Title NVARCHAR(80) NOT NULL,
	SourceMedium NVARCHAR(80),
	AuthorFirstName NVARCHAR(50) NOT NULL,
	AuthorLastName NVARCHAR(50) NOT NULL,
	SourceUrl NVARCHAR NOT NULL,
	PublicationName NVARCHAR(50),
	UploadDate DATETIME,
	PublishDate DATETIME
)