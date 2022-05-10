using DbUp;

var connectionString = "Host=localhost;Port=35432;Username=sa;Password=Password123;Database=test_db";
EnsureDatabase.For.PostgresqlDatabase(connectionString);
