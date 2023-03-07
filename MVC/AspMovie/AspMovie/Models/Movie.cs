using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AspMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [StringLength(60,MinimumLength =3)]
        [Required]
        public string? Title { get; set; }
        [Display(Name ="Release Date")]
        [Range(1,100)]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string? Genre { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(5)]
        [Required]
        [Column(TypeName ="decimal(18,2)")]
        public decimal Price { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]

        public string? Rating { get; set; }
    }
}
