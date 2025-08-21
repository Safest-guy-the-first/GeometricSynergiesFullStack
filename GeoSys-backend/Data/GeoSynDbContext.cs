using GeoSys_backend.Models;
using Microsoft.EntityFrameworkCore;

namespace GeoSys_backend.Data
{
    public class GeoSynDbContext:DbContext
    {
        public DbSet<UserModel> UsersTable { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var path = "C:\\Users\\David Oyem\\source\\repos\\GeometricSynergies\\GeoSys-backend\\Data\\GeoSynDatabase";
            optionsBuilder.UseSqlite($"Data Source = {path}");
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserModel>().HasKey(s => s.id);
        }

        public GeoSynDbContext(DbContextOptions<GeoSynDbContext> options):base(options)
        {
                
        }
    }
}
