using Microsoft.EntityFrameworkCore;

namespace Entities
{
    public class editorialContext : DbContext
    {
        public editorialContext(DbContextOptions<editorialContext> options) : base(options)
        {

        }
        public DbSet<titulos> titulos { get; set; }
        public DbSet<Editorial> Editoriales { get; set; }
        public DbSet<Cargos> Cargos { get; set; }
        public DbSet<Almacenes> Almacenes { get; set; }
        public DbSet<Autores> Autores { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<titulos>().ToTable("titulo");
            modelBuilder.Entity<Editorial>().ToTable("Editorial");
            modelBuilder.Entity<Cargos>().ToTable("Cargo");
            modelBuilder.Entity<Almacenes>().ToTable("Almacen");
            modelBuilder.Entity<Autores>().ToTable("Autor");
        }
    }
}