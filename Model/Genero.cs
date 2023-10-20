﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OdontologiaWeb.Models
{
    public class Genero
    {
        [Key]
        public int IdGenero { get; set; }
        public string? Sexo { get; set;}
    }
}