using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OdontologiaWeb.Models
{
    public class Anamnesis
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public long ID_Usuario { get; set; }
        public string? Motivo_Consulta { get; set; }
        public string? Emfermedad_Actual { get; set; }
        public DateTime Atencion { get; set; } = DateTime.Now;
        }
}