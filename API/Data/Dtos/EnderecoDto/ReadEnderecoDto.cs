﻿using System.ComponentModel.DataAnnotations;

namespace API.Models.Dtos.EnderecoDto
{
    public class ReadEnderecoDto
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string? Logradouro { get; set; }
        public string? Bairro { get; set; }
        public int Numero { get; set; }
    }
}
