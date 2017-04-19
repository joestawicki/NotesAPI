# NotesAPI

This RESTful API is a basis for powering a note-taking application.  It was implemented in C# using SQL Server Compact Edition to store the data and Microsoft's Entity Framework data retrieval using Microsoft's Web API.

## Installation Instructions

To Install this API, download NotesApiInstaller.msi and run the installer on a Windows machine

After this has been installed, navigate into the installation path (default is C:\Program Files (x86)\Joe Stawicki\Notes API) and run Notes.exe

This will start the service as a console application.  You can now run the service using http://localhost:9000.

The following HTTP methods are implemented:

### POST

POST /api/notes
body "note"

### GET

GET /api/notes/{id} - returns note with given id
GET /api/notes - returns all notes
GET /api/notes?query={query} - returns all notes with given query string
