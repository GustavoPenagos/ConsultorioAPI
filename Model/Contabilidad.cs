using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ConsultorioAPI.Model
{
    public class Contabilidad
    {
        [Key]
        public int Id { get; set; }
        public long IdUsuario { get; set; }
        public double Valor { get; set; }
        public double Abono { get; set; }
        public double Saldo { get; set; }
        public DateTime FechaRegistro { get; set; } 

    }
}
