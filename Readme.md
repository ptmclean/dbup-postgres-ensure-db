# DbUp - Demonstration of issue with EnsureDatabaseExists

This repository demonstrates an [issue](https://github.com/DbUp/DbUp/issues/626) in database creation in version 4.6.0 of `dbup-postgresql`. When running this version a call to `EnsureDatabaseExists` fails with the following error...
```
Master ConnectionString => Host=localhost;Port=35432;Username=sa;Password=******;Database=test_db
Unhandled exception. Npgsql.PostgresException (0x80004005): 3D000: database "test_db" does not exist
   at Npgsql.NpgsqlConnector.DoReadMessage(Boolean async, DataRowLoadingMode dataRowLoadingMode, Boolean readingNotifications, Boolean isPrependedMessage)
   at Npgsql.NpgsqlConnector.ReadMessage(Boolean async, DataRowLoadingMode dataRowLoadingMode, Boolean readingNotifications)
   at Npgsql.NpgsqlConnector.ReadMessage(Boolean async, DataRowLoadingMode dataRowLoadingMode, Boolean readingNotifications)
   at Npgsql.NpgsqlConnector.Open(NpgsqlTimeout timeout, Boolean async, CancellationToken cancellationToken)
   at Npgsql.ConnectorPool.AllocateLong(NpgsqlConnection conn, NpgsqlTimeout timeout, Boolean async, CancellationToken cancellationToken)
   at Npgsql.NpgsqlConnection.Open(Boolean async, CancellationToken cancellationToken)
   at Npgsql.NpgsqlConnection.Open()
   at PostgresqlExtensions.PostgresqlDatabase(SupportedDatabasesForEnsureDatabase supported, String connectionString, IUpgradeLog logger, X509Certificate2 certificate)
   at PostgresqlExtensions.PostgresqlDatabase(SupportedDatabasesForEnsureDatabase supported, String connectionString, IUpgradeLog logger)
   at PostgresqlExtensions.PostgresqlDatabase(SupportedDatabasesForEnsureDatabase supported, String connectionString)
   at Program.<Main>$(String[] args) in /Users/petermclean/src/dbup-postgres-ensure-db/Program.cs:line 4
```

When running on 4.5.0 the following is output...
```
Master ConnectionString => Host=localhost;Port=35432;Username=sa;Password=***********;Database=postgres
Created database test_db
```

## How to run
To run this application, docker and dotnet 6 need to be available and the following commands run...
```
docker-compose up -d
dotnet run
```