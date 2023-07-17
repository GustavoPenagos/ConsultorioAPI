using Microsoft.EntityFrameworkCore;

namespace ConsultorioAPI.Model
{
    [Keyless]
    public class EstadoTratamiento
    {
        public string? Id_Usuario { get; set; }
        public DateTime Fecha { get; set; }
        public string? Diente { get; set; }
        public string? Trata_Efectuado { get; set;}
        public string? Doctor { get; set;}
        public string? Firma { get; set;}
    }
}
