using Desafio_1b.Models;
using Microsoft.EntityFrameworkCore;

namespace Desafio_1b.Data
{
    public class FormularioContext : DbContext
    {
        public FormularioContext(DbContextOptions<FormularioContext> options) : base(options)
        {
        }

        public DbSet<Campos> Campos { get; set; }
    }
}
