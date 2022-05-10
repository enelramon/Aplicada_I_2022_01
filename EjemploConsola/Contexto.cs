using Microsoft.EntityFrameworkCore;

public class Contexto: DbContext
{
    public DbSet<Categorias> Categorias { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(@"data source=data.db");
    }
}
