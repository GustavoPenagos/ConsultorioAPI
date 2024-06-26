﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ConsultorioAPI.Model
{
    public class CartaDentalNino
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public long ID_Usuario { get; set; }
        public string? c51 { get; set; }
        public string? c52 { get; set; }
        public string? c53 { get; set; }
        public string? c54 { get; set; }
        public string? c55 { get; set; }
        public string? c61 { get; set; }
        public string? c62 { get; set; }
        public string? c63 { get; set; }
        public string? c64 { get; set; }
        public string? c65 { get; set; }
        public string? c71 { get; set; }
        public string? c72 { get; set; }
        public string? c73 { get; set; }
        public string? c74 { get; set; }
        public string? c75 { get; set; }
        public string? c81 { get; set; }
        public string? c82 { get; set; }
        public string? c83 { get; set; }
        public string? c84 { get; set; }
        public string? c85 { get; set; }
        public DateTime Atencion { get; set; } = DateTime.Now;
    }
}
