# MuckScraper
*MuckScraper* is a web application in progress that will be built using ASP.NET MVC, Azure SQL Server database, and Azure Cloud hosting. 

- Intended to run on any browser in a desktop environment. 
- Only available as web application in early stages. No installation required.

<a name="toc"></a>
## Table of Contents
1. [What is MuckScraper?](#explanation)
2. [The Name](#ms)
3. [User Stories](#stories)
4. [Use Cases](#ucase)
5. [Use-Case Diagram](#ucdgrm)
6. [Requirements](#reqs)
7. [Entity Relationship Diagram (Preliminary)](#erdrgm)
8. [Wireframe (Tentative Sketches)](#sketches)
9. [Technical Support Contact](#techsupport)

<a name="explanation"></a>
# What is MuckScraper?

*MuckScraper is a web application in development that will allow users to archive articles from the web for later reading and will promote news consumer literacy by compiling statistics of user reading habits and notifying them of identified patterns.* 

[Return](#toc)

<a name="ms"></a>
## Why the name?
The name is a portmanteu of two terms: *"Muckraker"*, which is a term used to identify the revolutionary journalists of the Progressive Era that devoted their careers to shining a light on corruption, and *"Web scrape"*, which is the technique of sifting through a webpage and intelligently collecting useful data. 

The term "muckraker", as it is used today, characterizes journalists whose devotion to the field transcends any perceived limitations. It is used to portray journalists who do the job with an unrelenting effort. These journalists' careers are so often overshadowed by the reputation of the publication that employs them, and, in today's polarized news world, this often mischaracterizes their work. This spawned the idea of creating an application that underscores journalist's reputations rather than the publications they write for. This warrants pulling, or scraping, applicable data from news articles to build in this capability, thus, MuckScraper seemed a like fitting title. 

[Return](#toc)

<a name="stories"></a>
## User Stories

As a newpaper reader, I want an application that allows me to download articles for later viewing.

As a consumer, I want to see statistics that make me aware of my reading habits.

As a journalist, I need an application that emphasizes a journalist's reputation. 

[Return](#toc)

<a name="ucase"></a>
## Use Cases

Given a news article, the application will parse the article separating HTML from plain text. When complete, the article will then be made available for viewing outside of the parent website.

Given a news article, the application will be able to intelligently identify key attributes to store as persistent data points that will be used to reveal user reading habits.

Given a user, the application will be able to display an individualized profile, article queue, and statistics page based on user activity.

Given a user, the article will need to require user to log in to access profile.

[Return](#toc)

<a name="ucdgrm"></a>
## Use-Case Diagram 

![image](https://user-images.githubusercontent.com/21690878/110075094-21486d00-7d37-11eb-91cf-294a615be559.png)

[Return](#toc)

# Requirements:

1. The system shall download an alias of the article that is presented for later view.
	1.1 The system shall accept a news article as input and copy its text intelligently into a neatly formatted file held in storage.
		1.1.1 The system shall employ web scraping functionality that will allow it to parse a webpage and identify key elements that distinguish text from html.
		1.1.2 The sysem shall strip away extraneous html tags, salvaging only pertinent material from webpage.
		1.1.3 The system shall store saved text into a new file saved to the user's account.
	1.2 The system shall offer an user-friendly interface for viewing article aliases that have been saved.

2. The system shall monitor user habits.
	2.1 The system shall also intelligently identify certain aspects in a news article and keep track of its history in a historical database.
		2.1.1 The system shall extrapolate key characteristics of a new article, such as author, publication, and date, and log instances of this data in a database.
		2.1.2 The system shall update database with new values and recognize values that have already been seen by comparing it to other values in the database.
			2.1.2.1 The system shall increment data that already exists in database with every subsequent instance.
	2.2 The system shall display a front-end interface to the user which consists of various statistics that reflect reading habits.
		2.2.1 The system shall display user data in its most recent state.
			2.2.1.1 The system shall provide means to update program with an accurate view of the current state of data in the database.
		2.2.2 The system shall make calculations on user data that reflect the user's habits and display these figures to the user.
		
3. The system shall include functionality that emphasizes a journalist's credentials.
	3.1 The system will recognize journalists by name and display a wiki for the user to learn more about the journalist's background and reputation.
		3.1.1 The system will extrapolate the author's name while parsing through an article's contents.
		3.1.2 The system will utilize an API to search for the author and return a short wiki.
		3.1.3 The system will provide a link in the wiki that enables user's to further research the author via a new browser tab linked to an outside source.
	3.2 The system will keep record of a user's history of authors and notify them when a future uploaded article contains similarities.

[Return](#toc)

















<a name="techsupport"></a>
For questions, reporting bugs, or general technical support, please contact me at...
-----------------------
Email: dantz.farrow1@outlook.com
