# MuckScraper
*MuckScraper* is a web application in progress that will be built using ASP.NET MVC, Azure SQL Server database, and Azure Cloud hosting. 

- Intended to run on any browser in a desktop environment. 
- Only available as web application in early stages. No installation required.

<a name="toc"></a>
## Table of Contents
1. [What is MuckScraper?](#explanation)
2. [Why the Name?](#ms)
3. [User Stories](#stories)
4. [Use Cases](#ucase)
5. [Use-Case Diagram](#ucdgrm)
6. [Requirements Hierarchy](#reqs)
7. [Requirements Specification Table](#reqspec)
8. [Testing](#tst)
9. [Entity Relationship Diagram (Preliminary)](#erdrgm)
10. [Database Diagram](#dbdgrm)
11. [Prototype (First Draft)](#sketches)
12. [Technical Support Contact](#techsupport)

<a name="explanation"></a>
# What is MuckScraper?

*MuckScraper is a web application in development that will allow users to archive articles from the web for later reading and will promote news consumer literacy by compiling statistics of user reading habits and notifying them of identified patterns.* 

[Back To Top](#toc)

<a name="ms"></a>
## Why the name?
The name is a portmanteu of two terms: *"Muckraker"*, which is a term used to identify the revolutionary journalists of the Progressive Era that devoted their careers to shining a light on corruption, and *"Web scrape"*, which is a technique for sifting through a webpage and intelligently extracting and collecting useful data. 

The term "muckraker", as it is used today, characterizes journalists whose devotion to the field transcends any perceived limitations. It is used to portray journalists who do the job with unrelenting effort. These journalists' careers are so often overshadowed by the reputation of the publication that employs them, and, in today's polarized news world, this often mischaracterizes their work. This spawned the idea of creating an application that underscores journalist's reputations rather than the publications they write for. This warrants pulling, or scraping, applicable data from news articles to build in this capability, thus, MuckScraper seemed a like fitting title. 

[Back To Top](#toc)

<a name="stories"></a>
## User Stories

As a newpaper reader, I want an application that allows me to download articles for later viewing.

As a consumer, I want to see statistics that make me aware of my reading habits.

As a journalist, I need an application that emphasizes a journalist's reputation. 

[Back To Top](#toc)

<a name="ucase"></a>
## Use Cases

Given a news article, the application will parse the article separating HTML from plain text. When complete, the article will then be made available for viewing outside of the parent website.

Given a news article, the application will be able to intelligently identify key attributes to store as persistent data points that will be used to reveal user reading habits.

Given a user, the application will be able to display an individualized profile, article queue, and statistics page based on user activity.

Given a user, the article will need to require user to log in to access profile.

[Back To Top](#toc)

<a name="ucdgrm"></a>
## Use-Case Diagram 

![UML_MS](https://user-images.githubusercontent.com/21690878/110140615-21715880-7d89-11eb-8296-ce5001b127fc.png)

[Back To Top](#toc)


<a name="reqs"></a>
# Requirements Hierarchy:

1. The system shall download an alias of the article that is presented for later view.
    1. The system shall accept a news article as input and copy its text intelligently into a neatly formatted file held in storage.
        1. The system shall employ web scraping functionality that will allow it to parse a webpage and identify key elements that distinguish text from html.
        2. The system shall strip away extraneous html tags, salvaging only pertinent material from webpage.
        3. The system shall store saved text into a new file saved to the user's account.
    2. The system shall offer a user-friendly interface for viewing article aliases that have been saved.

2. The system shall monitor user habits.
    1. The system shall also intelligently identify certain aspects in a news article and keep track of its history in a historical database.
        1. The system shall extrapolate key characteristics of a news article, such as author, publication, and date, and log instances of this data in a database.
        2. The system shall update database with new values and recognize values that have already been seen by comparing it to other values in the database.
            1. The system shall increment data that already exists in database with every subsequent instance.
    2. The system shall display a front-end interface to the user which consists of various statistics that reflect reading habits.
        1. The system shall display user data in its most recent state.
            1. The system shall provide means to update program with an accurate view of the current state of data in the database.
        2. The system shall make calculations on user data that reflects the user's habits and display these figures to the user.
		
3. The system shall include functionality that emphasizes a journalist's credentials.
    1. The system will recognize journalists by name and display a wiki for the user to learn more about the journalist's background and reputation.
        1. The system will extrapolate the author's name while parsing through an article's contents.
        2. The system will utilize an API to search for the author and return a short wiki.
        3. The system will provide a link in the wiki that enables user's to further research the author via a new browser tab linked to an outside source.
    2. The system will keep record of a user's history of authors and notify them when a future uploaded article contains similarities.

<a name="reqspec"></a>
## Requirements Specification

|Req ID|Requirement|Test Method|
|----|------------------------|---------|
|1.| The system shall pull applicable information from article to populate object fields. | test |
|1.i.| The system shall accept a url and generate a news article object. | test |
|1.i.a.| The system shall make API call based on user url input. | demonstrate |
|1.i.b.| The system shall be capable of generating its own fields from API return. | test |
|1.i.c.| The system shall store article objects to a user's personal library. | test |
|1.ii.| The system can create users and allow them to manage and interact with their data. | test |
|1.ii.a| The system allows users to register and log in to application. | test |
|1.ii.b| The system shall only allow registered users to view their own libraries. | test |
|1.ii.c| The system shall allow user's to create, read, edit and delete articles to and from library. | test |
|1.iii.| The system shall offer a user-friendly interface with consistent pages. | demonstrate |
|2.| The system shall monitor user habits.| analysis |
|2.i.| The system shall be capable of recognizing values already seen by comparing them to other values in the database.| test |
|2.ii.a| The system shall display a front-end interface to the user which consists of various statistics that reflect reading habits.| demonstrate |
|2.ii.b| The system shall display user data in its most recent state. | test |
|2.ii.c.| The system shall make calculations on user data that reflects the user's habits and display these figures to the user. | test |
|3.| The system shall include functionality that emphasizes a journalist's credentials.| demonstrate |
|3.i.| The system will recognize journalists by name and display a wiki for the user to learn more about the journalist's background and reputation.| test |
|3.i.a.| The system will extrapolate the author's name while parsing through an article's contents.| test |
|3.i.b.| The system will utilize an API to search for the author and return a short wiki.| demonstrate |
|3.i.c.| The system will provide a link in the wiki that enables user's to further research the author via a new browser tab linked to an outside source.| demonstrate |
|3.ii.| The system will keep record of a user's history of authors and notify them when a future uploaded article contains similarities.| test |


<a name="tst"></a>
## Testing
|TestID|Req ID|Test Process|Status|Timestamp|Build/Version|
|----|----|-------------|------------|-------|----------|
|001|1.i.| System takes user input, calls API, stores applicable info to an object, and stores object to library. | tested |||
|002|1.ii.a| System allows users to register and log in. | tested |||
|003|1.ii.b| Users can only view their own libraries.| not tested |||
|004|1.ii.c| System allows users to perform CRUD operations on their libraries.| In progress |||
|005|1.iii.| System displays user friendly interface | demonstrated |||
|006|2.| System monitors user's habits.| not implemented |||
|007|3.| System emphasizes a journalist's credentials. | not implemented |||

[Back To Top](#toc)

<a name="erdrgm"></a>
## Entity Relationship Diagram

![ERD](https://user-images.githubusercontent.com/21690878/110140445-f4bd4100-7d88-11eb-99fb-6b1479b8bf3d.jpg)

[Back To Top](#toc)


<a name="dbdrgm"></a>
## Database Diagram

![DbDiagram](MuckScraperDbDatabaseDiagram.JPG)

[Back To Top](#toc)
<a name="sketches"></a>
## Prototype (First Draft)
![Follow this link to check out the first draft of my prototype...](https://github.com/Dantzzz/MuckScraper/blob/main/MS%20Prototype.pdf) 

[Back To Top](#toc)

<a name="techsupport"></a>
For questions, reporting bugs, or general technical support, please contact me at...
-----------------------
Email: dantz.farrow1@outlook.com

[Back To Top](#toc)
