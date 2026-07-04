using Lab3_Migrations.Data;

Console.WriteLine("Lab 3: Using EF Core CLI to Create and Apply Migrations");

using var db = new AppDbContext();

Console.WriteLine("DbContext Ready!");