USE Muckscraper;

INSERT INTO Users 
VALUES (01, 'dantzzz', '02/14/2021', '**********', '02/14/2021', 1, 'dantz.farrow1@outlook.com')
SELECT * FROM Users

INSERT INTO Profiles
VALUES ('dantzzz', 'Dantz', 'Farrow', 'D','//filepath')
SELECT * FROM Profiles

INSERT INTO ArticleArchive
VALUES (01, 'dantzzz', 'Julie Wernau', 'Why Administering Covid-19 Shots Is So Hard', 'The Wall Street Journal', 'Newspaper', '02/14/2021', 'https://www.wsj.com/articles/why-administering-covid-19-shots-is-so-hard-11613322773?mod=hp_lead_pos7')
SELECT * FROM ArticleArchive

INSERT INTO UserStatistics
VALUES ('dantzzz', 1, 0, 0, 0, 1, 0, 1)
SELECT * FROM UserStatistics

SELECT * 
FROM Users U
JOIN Profiles P ON U.username = P.username
JOIN ArticleArchive A ON A.username = U.username
JOIN UserStatistics US ON US.username = A.username
