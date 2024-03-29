﻿using System.ComponentModel.DataAnnotations;

namespace API.Models.Dtos.CinemaDto
{
    public class CreateCinemaDto
    {
        [Required(ErrorMessage = "O campo Nome é obrigatório ")]
        public string? Nome { get; set; }
        public int EnderecoId { get; set; }
        public int GerenteId { get; set; }
    }
}
