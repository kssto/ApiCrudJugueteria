using Db.Models;
using Microsoft.EntityFrameworkCore;

namespace Db.Datos.EFCore
{
    public class JugueteContext : DbContext
    {
        public JugueteContext(DbContextOptions<JugueteContext> options) : base(options) { }
        public DbSet<Juguete> Juguetes { get; set; }
    }
}
