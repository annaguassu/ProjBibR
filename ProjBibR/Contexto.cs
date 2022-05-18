using Microsoft.EntityFrameworkCore;
using ProjBibR.Entidades;

namespace ProjBibR
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
