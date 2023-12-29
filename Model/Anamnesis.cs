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
        public int Id { get; set; }
        [Required]
        public long IdUsuario { get; set; }
        public string MotivoConsulta { get; set; }
        public string EmferActual { get; set; }
        public DateTime Atencion { get; set; } = DateTime.Now;
        }
}