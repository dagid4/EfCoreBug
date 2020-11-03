using System;
using EfCoreBug;

await using var context = new MyContext();

await context.Database.EnsureCreatedAsync();

var garage = new Garage();

context.Add(garage);

await context.SaveChangesAsync();

var ferrari = new Ferrari();

garage.Cars.Add(ferrari);

ferrari.Special = new Special();

Console.WriteLine($"Special is null: {(ferrari.Special == null ? "YES" : "NO")}");

await context.SaveChangesAsync();

Console.WriteLine($"Special is null: {(ferrari.Special == null ? "YES" : "NO")}");