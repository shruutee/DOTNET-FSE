# Lab 1 - First Web API using .NET Core

## Objective

Create a simple ASP.NET Core Web API with CRUD operations.

## HTTP Methods Used

- GET
- POST
- PUT
- DELETE

## Status Codes

- 200 OK
- 400 Bad Request

## Run

```bash
dotnet restore
dotnet run
```

Open Swagger:

```
https://localhost:7000/swagger
```

## Sample Endpoints

```
GET    /api/values
GET    /api/values/1
POST   /api/values
PUT    /api/values/1
DELETE /api/values/1
```
