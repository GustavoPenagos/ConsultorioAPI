using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OdontologiaWeb.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        public long ID_Usuario { get; set; }
        public int ID_Documento { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public int Edad { get; set; }
        public DateTime Fecha_Nacido { get; set; }
        public int Estado_Civil { get; set; }
        public string? Ocupacion { get; set; }
        public string? Aseguradora { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
        public int ID_Genero { get; set; }
        public int ID_Ciudad { get; set; }
        public int ID_Departamento { get; set; }
        public string? Oficina { get; set; }
        public string? Nombre_Acudiente { get; set; }
        public string? Referido { get; set; }
        public string? Observaciones { get; set; }
        public DateTime Atencion { get; set; } = DateTime.Now;

    }
}