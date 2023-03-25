using System.ComponentModel.DataAnnotations;

namespace MovieStoreMvc.Models
{
    public class Genre
    {
        public int Id { get; set; }
        [Required]
        public string? GenreName { get; set; }
		public virtual ICollection<MovieGenre> MovieGenres { get; } = new List<MovieGenre>();

	}
}
