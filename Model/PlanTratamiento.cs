using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ConsultorioAPI.Model
{
    public class PlanTratamiento
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public long IdUsuario { get; set; }
        public string? Diagnostico {get; set; }
        public string? Pronostico { get; set; }
        public string? Tratamiento{ get; set; }
        public DateTime Atencion { get; set; }
    }
}
