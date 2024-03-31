using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ConsultorioAPI.Model
{
    public class EstadoTratamiento
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public long ID_Usuario { get; set; }
        public DateTime Fecha { get; set; }
        public string? Diente { get; set; }
        public string? Tratamiento_Efectuado { get; set;}
        public string? Doctor { get; set;}
        public string? Firma { get; set;}
        public DateTime Atencion { get; set; } = DateTime.Now;
    }
}
