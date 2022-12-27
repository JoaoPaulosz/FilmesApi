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
        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Cinema> Cinema { get; set; }

    }
}
