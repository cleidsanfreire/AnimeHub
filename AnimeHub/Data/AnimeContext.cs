using AnimeHub.Models;
using Microsoft.EntityFrameworkCore;

namespace AnimeHub.Data
{
    public class AnimeContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Anime> Animes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=AnimeHub;Username=postgres;Password=d0703");
        }
    }
}
