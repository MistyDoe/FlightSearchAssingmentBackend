# FlightSearchAssingmentBackend
Backend for the flight search application. The repository for frontend can be found [here](https://github.com/MistyDoe/FlightSearchAssingmentFrontEnd)

## Description
A back end of a full stack application for a flight search using SqLite as a database, Asp.Net Core for the backend, and Entity to assist in database handling
The endpoints are restricted to
* Search for flights that match the "From" and "To" search terms.
* After booking, the left seat count is updated in the database.

# Getting Started

## Build with

* Asp.Net Core
* Entity
* Sqlite

## Installing

1. Clone the repository

```
git clone https://github.com/MistyDoe/FlightSearchAssingmentBackend
```

2. Restore the dependencies.

**Important**
Before restoring, make sure you have dependencies installed.
 
 To install dependencies in console enter
 
```
dotnet add package Microsoft.EntityFrameworkCore
```

```
dotnet add package Microsoft.EntityFrameworkCore.Design
```
```
dotnet add package Microsoft.EntityFrameworkCore.Sqlite 
```
```
dotnet add package Newtonsoft.Json
```
If you are using Visual Studio you can use NuGet Manager found (Visual Studio 2022) in Tools >>  NuGet Package Manager >> Manage NuGet packages for this solution

If you already have all the dependencies installed, type

```
dotnet restore 
```

in the IDE console while inside the repository directory. 

## Executing the program
To run the backend type 

```
dotnet run
```
 in the console, while inside the repository directory. 
 
 To test the endpoints, while the application is running, go to https://localhost:7152/swagger/index.html
 
## Authors
Migle Urbonaite @MistyDoe
