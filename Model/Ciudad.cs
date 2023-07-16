using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OdontologiaWeb.Models
{

    public class Ciudad
    {
        [Key]
        public int Id_Ciudad { get; set; }
        public string? Municipio { get; set; }
        public int Estado { get; set; }
        public int Id_Departamento { get; set; }
    }
}