using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OdontologiaWeb.Models
{
    [Keyless]
    public class Anamnesis
    {
        public string? Id_Usuario { get; set; }
        public string? Motivo_Consulta { get; set; }
        public string? Emf_Actual { get; set; }
        public DateTime Atencion { get; set; }
    }
}