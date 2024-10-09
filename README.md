# BlazedWebScrapper

NOTES

For the application to work, it is necessary to create a local database. To do this, go to the Tools tab in VisualStudio and select Nuget Package Console. In the console, type “update-database”. Then we can run the project normally.



DESCRIPTION

Scrapper for Airflight. The api searches azair.eu for the cheapest flights from Poland to Anywhere. The scraped data is formatted into objects and stored in a table in the local MSSQL database. Then a LINQ command is executed on the collected data to select the 5 best flights according to the algorithm and send their formatted form to email: zbigniew.sr@interia.pl. The above operation is performed every time we click the Flights tab on the right.



TECHNOLOGIES USED
- AgilityPack + CssSelector
- Entity Framework
- LINQ
- Blazor
- System.Net.Mail for sending emails
- MSSQL
