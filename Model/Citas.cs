﻿using System.ComponentModel.DataAnnotations;

namespace ConsultorioAPI.Model
{
    public class Citas
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public long IdUsuario { get; set; }
        public DateTime  FechaCita{ get; set; }
        public string? HoraCita { get; set; }

    }
}
