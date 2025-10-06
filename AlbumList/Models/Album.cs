using System.ComponentModel.DataAnnotations;

namespace AlbumList.Models
{
    public class Album
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public Genre MusicGenre { get; set; }
        public int TrackCount { get; set; }
        public int YearPublished { get; set; }
    }
}
