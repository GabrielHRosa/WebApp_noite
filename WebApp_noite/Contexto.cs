using Microsoft.EntityFrameworkCore;

namespace WebApp_noite
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> opt)
             :base(opt) { }

    }
}
