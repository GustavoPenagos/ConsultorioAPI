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
        public  int ID_Documento { get; set; }
        public string? Documento { get; set; }
    }
}