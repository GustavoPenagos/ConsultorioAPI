using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OdontologiaWeb.Models
{
    public class TipoDocumento
    {
        [Key]
        public  int IdDocumento { get; set; }
        public string? Documento { get; set; }
    }
}