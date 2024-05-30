using RepasoAPI.Estudiante.Domain.Model.Aggregates;
using RepasoAPI.Shared.Infrastructure.Persistence.EFC.Configuration.Extensions;
using EntityFrameworkCore.CreatedUpdatedDate.Extensions;
using Microsoft.EntityFrameworkCore;

namespace RepasoAPI.Shared.Infrastructure.Persistence.EFC.Configuration
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.AddCreatedUpdatedInterceptor();
            base.OnConfiguring(builder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Estudiantes>().ToTable("estudiantes");
            builder.Entity<Estudiantes>().HasKey(e => e.ID);
            builder.Entity<Estudiantes>().Property(e => e.ID).IsRequired().ValueGeneratedOnAdd();

            builder.Entity<Estudiantes>().Property(e => e.NombreUsuario).IsRequired().HasMaxLength(100);

            builder.Entity<Estudiantes>().Property(e => e.IdSede).HasMaxLength(50);

            builder.Entity<Estudiantes>().Property(e => e.IdCarrera).HasMaxLength(50);
        
            builder.Entity<Estudiantes>().Property(e => e.NombreEstudiante).HasMaxLength(100);

            builder.Entity<Estudiantes>().Property(e => e.Edad).HasMaxLength(3);

            builder.Entity<Estudiantes>().Property(e => e.Dni).IsRequired().HasMaxLength(15);

            builder.Entity<Estudiantes>().Property(e => e.Correo).HasMaxLength(100);

            builder.Entity<Estudiantes>().Property(e => e.Celular).HasMaxLength(20);

            builder.UseSnakeCaseNamingConvention();
        }
    }
}