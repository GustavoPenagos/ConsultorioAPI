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
        public int Id_Departamento { get; set; }
        public string? NombreDepartamento { get; set; }
    }
}