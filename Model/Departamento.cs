using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OdontologiaWeb.Models
{
    public class Departamento
    {
        [Key]
        public int ID { get; set; }
        public int ID_Departamento { get; set; }
        public string? Nombre_Departamento { get; set; }
    }
}