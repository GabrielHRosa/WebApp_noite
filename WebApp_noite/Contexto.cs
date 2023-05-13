using Microsoft.EntityFrameworkCore;
using WebApp_noite.Tabelas;

namespace WebApp_noite
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> opt)
             :base(opt) { }

        public DbSet<Categorias> Categorias { get; set; }

    }
}
