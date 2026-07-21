# Lab 3 - Web API using Custom Model, Authorization Filter and Exception Filter

## Objective

- Create a custom Employee model.
- Return a list of Employee objects.
- Use `AllowAnonymous`.
- Use `FromBody` in POST and PUT.
- Create a Custom Authorization Filter.
- Create a Custom Exception Filter.
- Test APIs using Swagger.

## API Endpoints

### GET

```
GET /api/Employee
```

### POST

```
POST /api/Employee
```

### PUT

```
PUT /api/Employee/{id}
```

## Authorization Header

```
Authorization : Bearer MyToken
```

## To Test Exception Filter

Uncomment the following line in `GetStandard()`:

```csharp
throw new Exception("Sample Exception");
```

Run the GET request again. An `ErrorLog.txt` file will be created with the exception details.

## Run

```bash
dotnet restore
dotnet run
```
