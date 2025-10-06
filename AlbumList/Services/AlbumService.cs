using AlbumList.Data;
using AlbumList.Models;
using Microsoft.EntityFrameworkCore;

namespace AlbumList.Services
{
    public class AlbumService
    {
        private ApplicationDbContext _context;

        public AlbumService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Album>> GetAlbums()
        {
            var result = _context.Album.ToList();
            if (result == null)
            {
                throw new Exception("No albums found");
            }
            return result;
        }

        public async Task<Album> GetAlbumById(int id)
        {
            var result = await _context.Album.FirstOrDefaultAsync(x => x.Id == id);
            if (result == null)
            {
                throw new Exception("No album found");
            }
            return result;
        }

        public async Task AddAlbum(Album album)
        {
            await _context.Album.AddAsync(album);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAlbum(int id)
        {
            var albumToBeRemoved = await GetAlbumById(id);
            _context.Remove(albumToBeRemoved);
            await _context.SaveChangesAsync();
        }
    }
}
