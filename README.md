# Proyecto NetCore

Technology
- Dotnet Core 3.1
- SQL Server
- NUnit

Migration Execute:

Create new migration
```cmd
add-migration {nombre} -Context {contexto}
```

Delete last migration
```cmd
remove-migration
```

Update migration
```cmd
update-database {nombre} -Context {contexto}
```
Recommendation:
Use Postman or SOAP UI for test API's
