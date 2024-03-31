using System.ComponentModel.DataAnnotations;

namespace ConsultorioAPI.Model
{
    public class Citas
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public long ID_Usuario { get; set; }
        public DateTime  Fecha_Cita{ get; set; }
        public string? Hora_Cita { get; set; }

    }
}
