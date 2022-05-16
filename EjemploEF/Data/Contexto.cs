using Microsoft.EntityFrameworkCore;
namespace EjemploEF.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Categorias> Categorias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlite(@"data source= DataBase\Prestamos.db");
        }
    }
}
