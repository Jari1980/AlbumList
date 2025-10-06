

using AlbumList.Data;
using AlbumList.Seed;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("AlbumDb")));
var app = builder.Build();

//Seeding Albums
using (var scope = app.Services.CreateScope())
{
    AlbumSeed.Initialize(scope.ServiceProvider);
}


app.MapGet("/", () => "Hello World!");

app.Run();
