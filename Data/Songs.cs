using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicDatabase.Data
{
    public class Songs
    {
        public int SongId { get; set; }
        [Required]
        public string SongName { get; set;}
        [Required]
        public DateOnly ReleaseDate { get; set; }
        public int ArtistId { get; set; }
        [ForeignKey(nameof(ArtistId))]
        public Artists Artists { get; set; }
        public int AlbumId { get; set; }
        [ForeignKey(nameof(AlbumId))]
        public Albums Album { get; set; }
    }
}
