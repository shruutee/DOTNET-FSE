# Lab 2 - Web API with Swagger

## Objective

- Create an ASP.NET Core Web API.
- Configure Swagger documentation.
- Test APIs using Swagger UI and Postman.
- Modify the route from `Employee` to `Emp`.

## Features

- GET Employees
- POST Employee
- Swagger Documentation
- ProducesResponseType Attribute
- Custom Route (`api/Emp`)

## Run

```bash
dotnet restore
dotnet run
```

## Swagger URL

```
https://localhost:7000/swagger
```

## API Endpoints

```
GET  /api/Emp
POST /api/Emp
```

## Testing

### Swagger
- Open `/swagger`
- Click **Try it Out**
- Execute GET and POST requests.

### Postman
- GET: `https://localhost:7000/api/Emp`
- POST: `https://localhost:7000/api/Emp`
