﻿using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class Endereco
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string? Logradouro { get; set; }
        public string? Bairro { get; set; }
        public int Numero { get; set; }
    }
}