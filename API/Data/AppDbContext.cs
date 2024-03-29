﻿using FilmesAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Endereco>()
                .HasOne(endereco => endereco.Cinema)
                .WithOne(cinema => cinema.Endereco)
                .HasForeignKey<Cinema>(cinema => cinema.EnderecoId);

            builder.Entity<Cinema>()
                .HasOne(cinema => cinema.Gerente)
                .WithMany(gerente => gerente.Cinemas)
                .HasForeignKey(cinema => cinema.GerenteId); 
        }

        public DbSet<Filme>? Filmes { get; set; }
        public DbSet<Cinema>? Cinemas { get; set; }
        public DbSet<Endereco>? Enderecos{ get; set; }
        public DbSet<Gerente>? Gerentes { get; set; }
    }
}
