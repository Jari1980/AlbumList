

using AlbumList.Data;
using AlbumList.Models;
using AlbumList.Seed;
using AlbumList.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AlbumDb")));
builder.Services.AddScoped<AlbumService>();
//Cors
builder.Services.AddCors();
var app = builder.Build();

//Enabling Cors
app.UseCors(builder => builder
.AllowAnyOrigin()
.AllowAnyMethod()
.AllowAnyHeader()
);

//Seeding Albums
using (var scope = app.Services.CreateScope())
{
    AlbumSeed.Initialize(scope.ServiceProvider);
}

app.MapGet("/albums", async ([FromServices] AlbumService albumService) =>
{
    var albums = await albumService.GetAlbums();
    return Results.Ok(albums);
});

app.MapGet("/albums/{id}", async (int id, [FromServices] AlbumService albumService) =>
{
    var album = await albumService.GetAlbumById(id);
    return Results.Ok(album);
});

app.MapPost("/albums", async (Album album, [FromServices] AlbumService albumService) =>
{
    await albumService.AddAlbum(album);
    return Results.Created();
});

app.MapDelete("/albums/{id}", async (int id, [FromServices] AlbumService albumService) =>
{
    await albumService.DeleteAlbum(id);
    return Results.NoContent();
});

app.Run();
