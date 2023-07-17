using Microsoft.EntityFrameworkCore;

namespace ConsultorioAPI.Model
{
    [Keyless]
    public class PlanTratamiento
    {
        public string? Id_Usuario { get; set; }
        public string? Diagnostico {get; set; }
        public string? Pronostico { get; set; }
        public string? Tratamiento{ get; set; }
        public DateTime Atencion { get; set; }
    }
}
