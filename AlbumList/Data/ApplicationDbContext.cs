using AlbumList.Models;
using Microsoft.EntityFrameworkCore;

namespace AlbumList.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<Album> Album { get; set; }
    }
}
