using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicDatabase.Data
{
    public class Albums
    {
        public int AlbumId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public int SongId { get; set; }
        [ForeignKey(nameof(SongId))]
        public List<Songs> Songs { get; set; } = new List<Songs>();
        public int ArtistId { get; set; }
        [ForeignKey(nameof(ArtistId))]
        public Artists Artists { get; set; }
    }
}
