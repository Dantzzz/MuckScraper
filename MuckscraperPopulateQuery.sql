
--DROP DATABASE IF EXISTS MuckScraper;
--CREATE DATABASE Muckscraper;
USE Muckscraper;

DROP TABLE IF EXISTS Users;
CREATE TABLE Users
(
	userid INT PRIMARY KEY,
	username NVARCHAR(30),
	registrationdate DATETIME,
	[password] NVARCHAR(30),
	lastlogin DATETIME,
	userrights BIT,
	email NVARCHAR(50)
)

DROP TABLE IF EXISTS Profiles
CREATE TABLE Profiles
(
	username NVARCHAR(30) PRIMARY KEY,
	firstname NVARCHAR(30) NOT NULL,
	lastname NVARCHAR(30) NOT NULL,
	middlename NVARCHAR(30),
	photo NVARCHAR(80)
)


DROP TABLE IF EXISTS ArticleArchive
CREATE TABLE ArticleArchive
(
	archiveid INT PRIMARY KEY,
	username NVARCHAR(30),
	author NVARCHAR(50) NOT NULL,
	title NVARCHAR(80) NOT NULL,
	publication NVARCHAR(50),
	[type] NVARCHAR(80),
	publishdate DATETIME,
	[URL] nvarchar(300)
)

DROP TABLE IF EXISTS UserStatistics;
CREATE TABLE UserStatistics
(
	username NVARCHAR(30) PRIMARY KEY,
	unread INT NOT NULL,
	[read] INT NOT NULL,
	liked INT NOT NULL,
	disliked INT NOT NULL,
	saved INT NOT NULL,
	shared INT NOT NULL,
	total INT NOT NULL
)