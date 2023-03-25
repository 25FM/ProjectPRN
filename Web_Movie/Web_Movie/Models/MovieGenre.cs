using System.ComponentModel.DataAnnotations;

namespace MovieStoreMvc.Models
{
    public class MovieGenre
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int GenreId { get; set; }
		public virtual Genre Genre { get; set; } = null!;

		public virtual Movie Movie { get; set; } = null!;
	}
}
