using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using FilmesAPI.Models;

namespace API.Models
{
    public class Cinema
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = $"O campo Nome é obrigatório ")]
        public string? Nome { get; set; }
        public int EnderecoId { get; set; }
        public virtual Endereco? Endereco { get; set; }
        [JsonIgnore]
        public virtual Gerente? Gerente { get; set; }
        [JsonIgnore]
        public int GerenteId { get; set; }
        public virtual List<Filme>? Filmes { get; set; }
    }
}