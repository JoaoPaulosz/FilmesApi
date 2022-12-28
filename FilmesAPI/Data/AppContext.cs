using FilmesAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace FilmesAPI.Data
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions<AppContext> opt) : base(opt)
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
        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Cinema> Cinema { get; set; }

        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Gerente> Gerentes { get; set; }
    }
}
