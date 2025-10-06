using AlbumList.Data;
using AlbumList.Models;
using Microsoft.EntityFrameworkCore;

namespace AlbumList.Seed
{
    public class AlbumSeed
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                //If Db contains any data no data is seeded
                if(context.Album.Any())
                {
                    return;
                }

                //If AlbumDb is empty following Albums are added
                context.Album.AddRange(
                    new Album
                    {
                        Band = "Danzig",
                        AlbumName = "Lucifuge",
                        MusicGenre = Genre.Rock,
                        TrackCount = 11,
                        YearPublished = 1990
                    },
                    new Album
                    {
                        Band = "Iron Maiden",
                        AlbumName = "The Number of the Beast",
                        MusicGenre = Genre.Rock,
                        TrackCount = 8,
                        YearPublished = 1982
                    },
                    new Album
                    {
                        Band = "Judas Pries",
                        AlbumName = "Painkiller",
                        MusicGenre = Genre.Rock,
                        TrackCount = 10,
                        YearPublished = 1990
                    },
                    new Album
                    {
                        Band = "SPOCK",
                        AlbumName = "Earth Orbit",
                        MusicGenre = Genre.Synth,
                        TrackCount = 17,
                        YearPublished = 1997
                    },
                    new Album
                    {
                        Band = "Depeche Mode",
                        AlbumName = "Exciter",
                        MusicGenre = Genre.Synth,
                        TrackCount = 13,
                        YearPublished = 2001
                    },
                    new Album
                    {
                        Band = "E-Type",
                        AlbumName = "Last Man Standing",
                        MusicGenre = Genre.Pop,
                        TrackCount = 13,
                        YearPublished = 1998
                    }
                    );

                context.SaveChanges();
            }
        }
    }
}
