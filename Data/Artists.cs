using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicDatabase.Data
{
    public class Artists
    {
        public int ArtistId { get; set; }
        [Required]
        public string ArtistName { get; set;}
        [Required]
        public string RealName { get; set;}
        [Required]
        public int Age { get; set; }
        public int SongId { get; set; }
        [ForeignKey(nameof(SongId))]
        public Songs Songs { get; set; }
        public int AlbumId { get; set; }
        [ForeignKey(nameof(AlbumId))]
        public Albums Albums { get; set; }
    }
}
