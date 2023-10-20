using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ConsultorioAPI.Model
{
    public class CartaDentalAdulto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public long IdUsuario { get; set; }
        public string? c11 { get; set; }
        public string? c12 { get; set; }
        public string? c13 { get; set; }
        public string? c14 { get; set; }
        public string? c15 { get; set; }
        public string? c16 { get; set; }
        public string? c17 { get; set; }
        public string? c18 { get; set; }
        public string? c21 { get; set; }
        public string? c22 { get; set; }
        public string? c23 { get; set; }
        public string? c24 { get; set; }
        public string? c25 { get; set; }
        public string? c26 { get; set; }
        public string? c27 { get; set; }
        public string? c28 { get; set; }
        public string? c31 { get; set; }
        public string? c32 { get; set; }
        public string? c33 { get; set; }
        public string? c34 { get; set; }
        public string? c35 { get; set; }
        public string? c36 { get; set; }
        public string? c37 { get; set; }
        public string? c38 { get; set; }
        public string? c41 { get; set; }
        public string? c42 { get; set; }
        public string? c43 { get; set; }
        public string? c44 { get; set; }
        public string? c45 { get; set; }
        public string? c46 { get; set; }
        public string? c47 { get; set; }
        public string? c48 { get; set; }
        public DateTime Atencion { get; set; } = DateTime.Now;

    }
}
