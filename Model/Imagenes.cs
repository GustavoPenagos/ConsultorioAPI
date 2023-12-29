using System.ComponentModel.DataAnnotations;

namespace ConsultorioAPI.Model
{
    public class Imagenes
    {
        [Key] 
        public int Id { get; set; }
        [Required]
        public int IdUsuario { get; set; }
        public string? Imagen { get; set;}
        public DateTime? FechaCarga { get; set; } = DateTime.Now;
    }
}
