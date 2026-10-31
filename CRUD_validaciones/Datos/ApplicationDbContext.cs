using Microsoft.EntityFrameworkCore;
using CRUD_validaciones.Models;

namespace CRUD_validaciones.Datos
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Categoria> Categoria { get; set; }
    }
}
