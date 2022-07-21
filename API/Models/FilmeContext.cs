using FilmesAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Models
{
    public class FilmeContext : DbContext
    {
        public FilmeContext(DbContextOptions<FilmeContext> options) : base(options)
        {

        }

        public DbSet<Filme>? Filmes { get; set; }
    }
}
