using System.ComponentModel.DataAnnotations;

namespace ConsultorioAPI.Model
{
    public class Imagenes
    {
        [Key] 
        public int Id { get; set; }
        [Required]
        public int Id_Usuario { get; set; }
        public string? Imagen { get; set;}
        public DateTime? Fecha_Carga { get; set; }
    }
}
