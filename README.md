# ProjectAPI

##About ProjectAPI
ProjectAPI is a school project where the group members: Daniel, Zeynab, Payam, Felipe and Zara were tasked to create a system for residential tenants that would
use tags to log information about resident entries and save the data in the database.

##How It Works
The project is built as a ASP.NET Core Web API project with Entity Framework Core that uses Controllers to make HTTP requests to the database and retrieve data 
such as: Information about Tenants' entries combined with details such as Date and Time of entry with the Door and Tag codes. 
 
The project is divided into three folders: 
Data with the database related information, 
Models with the main entities of the project,
Controllers with the controllers that make the HTTP requests.

##Usage
Here are the steps you need to take to run the application on your device:
1) Clone the repository from GitHub.
2) Add the correct SQL connection string that is used to establish the connection to your local server in appsettings.json
3) Create the database by opening the Package Manager Console in your Visual Studio and typing update-database to create the database on your local server.
4) Open SQL Server Management Studio(SSMS) or SQL Server Object Explorer in your Visual Studio to ensure that the database has been created.
