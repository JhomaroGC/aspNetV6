using System.Diagnostics;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [Display(Name = "Nombre de la Película")]
        public string Title { get; set; } = string.Empty;

        [Display(Name = "Año")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Genero")]
        public string Genre { get; set; } = string.Empty;

        [Display(Name = "Precio (COP)")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        
        [Display(Name = "Calificacion")]
        public string Rating { get; set; }
    }
}