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
        }
        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Cinema> Cinema { get; set; }

        public DbSet<Endereco> Endereco { get; set; }
    }
}
