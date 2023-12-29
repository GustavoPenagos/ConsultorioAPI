using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ConsultorioAPI.Model
{
    public class EstadoTratamiento
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public long IdUsuario { get; set; }
        public DateTime Fecha { get; set; }
        public string? Diente { get; set; }
        public string? TrataEfectuado { get; set;}
        public string? Doctor { get; set;}
        public string? Firma { get; set;}
        public DateTime Atencion { get; set; } = DateTime.Now;
    }
}
