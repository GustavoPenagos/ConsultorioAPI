using System.ComponentModel.DataAnnotations;

namespace ConsultorioAPI.Model
{
    public class Imagenes
    {
        [Key] 
        public int ID { get; set; }
        [Required]
        public int ID_Usuario { get; set; }
        public string? Imagen { get; set;}
        public DateTime? FechaCarga { get; set; } = DateTime.Now;
    }
}
