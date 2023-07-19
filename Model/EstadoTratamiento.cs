using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ConsultorioAPI.Model
{
    public class EstadoTratamiento
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public long Id_Usuario { get; set; }
        public DateTime Fecha { get; set; }
        public string? Diente { get; set; }
        public string? Trata_Efectuado { get; set;}
        public string? Doctor { get; set;}
        public string? Firma { get; set;}
        public DateTime Atencion { get; set; }
    }
}
