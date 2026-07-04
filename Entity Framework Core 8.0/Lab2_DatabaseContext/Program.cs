using Lab2_DatabaseContext.Data;

Console.WriteLine("Lab 2: Setting Up the Database Context");

using var db = new AppDbContext();

Console.WriteLine("Database Context Configured Successfully!");