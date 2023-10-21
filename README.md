# HelloDotNet

## HelloWebApi

### EntityFramework: DB connection

_The following steps assume that you have already configured your entity models and DbContext (ApplicationDbContext)._

1) Add a connection string

_File: appsettings.json_
```
...
"ConnectionStrings": {
  "{dbName}": "Server=.; Database={dbName}; User Id={userName}; Password={userPassword}; MultipleActiveResultSets=true; TrustServerCertificate=true;"
},
...
```

2) Read the connection string and configure the DB connection

_File: Program.cs_
```
...
var connectionString = builder.Configuration.GetConnectionString("{dbName}");
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));
...
```

3) Add a DB migration
   - Open the `Package Manager Console` in the Visual Studio: Ctrl + `
   - Execute the command: `Add-Migration {migration name, e.g. AddDevicesTable}` to generate a migration
   - Execute the command: `Update-Database` to apply the migration

4) Run the application and perform any request.
