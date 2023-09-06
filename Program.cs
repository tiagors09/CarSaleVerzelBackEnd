using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<CarDb>(opt => opt.UseInMemoryDatabase("CarsList"));
var app = builder.Build();

app.MapGet("/cars", async (CarDb db) => 
    await db.Cars.ToListAsync());

app.MapGet("/cars/{id}", async (int id, CarDb db) => 
    await db.Cars.FindAsync(id)
        is Car car
            ? Results.Ok(car)
            : Results.NotFound());

app.MapPost("/cars", async (Car car, CarDb db) => 
{
    db.Cars.Add(car);
    await db.SaveChangesAsync();

    return Results.Created($"/cars/{car.Id}", car);
});

app.MapPut("/cars/{id}", async (int id, Car inputCar, CarDb db) =>
{
    var car = await db.Cars.FindAsync(id);

    if (car is null) return Results.NotFound();

    car.Brand = inputCar.Brand;
    car.Model = inputCar.Model;
    car.Name = inputCar.Name;
    car.Photo = inputCar.Photo;

    await db.SaveChangesAsync();

    return Results.NoContent();
});

app.MapDelete("/cars/{id}", async (int id, CarDb db) =>
{
    if (await db.Cars.FindAsync(id) is Car car) 
    {
        db.Cars.Remove(car);
        await db.SaveChangesAsync();
        return Results.Ok(car);
    }

    return Results.NotFound();
});

app.Run();

public class Car 
{
    public int Id { get; set; }
    public string? Model { get; set; }
    public string? Brand { get; set; }
    public string? Photo { get; set; }
    public string? Name { get; set; }
}

class CarDb : DbContext
{
    public CarDb(DbContextOptions<CarDb> options)
        : base(options) { }
    
    public DbSet<Car> Cars => Set<Car>();
}