using System.ComponentModel.DataAnnotations;

namespace ConsultorioAPI.Model
{
    public class Convecciones
    {
        [Key]
        public int ID { get; set; }
        public string? Conveccion { get; set; }
    }
}
