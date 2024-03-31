using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OdontologiaWeb.Models
{
    public class Ant_Familiar
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public long ID_Usuario { get; set; }
        public int Cancer { get; set; }
        public int Sinusitis { get; set; }
        public int Organos_Sentidos { get; set; }
        public int Diabetes { get; set; }
        public int Infecciones { get; set; }
        public int Hepatitis { get; set; }
        public int Epilepsia { get; set; }
        public int TransGastricos { get; set; }
        public int Cardiopatias { get; set; }
        public int FiebReumatica { get; set; }
        public int TrataMedico { get; set; }
        public int Enfermedad_Respiratoria { get; set; }
        public int Hipertension { get; set; }
        public int AltCoagulatorias { get; set; }
        public int Transtorno_Neumologico { get; set; }
        public int Ten_Arterial { get; set; }
        public string? Otros { get; set; }
        public int Embarazo { get; set; }
        public int Meses { get; set; }
        public int Lactancia { get; set; }
        public int Frecuencia_Cepillado { get; set; }
        public int CedaDental { get; set; }
        public string? Observaciones { get; set; }
        public DateTime Atencion { get; set; } = DateTime.Now;
    }
}