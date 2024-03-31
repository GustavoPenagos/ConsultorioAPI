using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OdontologiaWeb.Models
{
    public class Estomatologico
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public long ID_Usuario { get; set; }
        public int Labios { get; set; }
        public int Encias { get; set; }
        public int Paladar { get; set; }
        public int Carrillos { get; set; }
        public int Lengua { get; set; }
        public int Musculos { get; set; }
        public int Piso_Boca { get; set; }
        public int Oro_farige { get; set; }
        public int Frenillos { get; set; }
        public int Maxilares { get; set; }
        public int GlanSalivales { get; set; }
        public DateTime Atencion { get; set; } = DateTime.Now;
    }
}