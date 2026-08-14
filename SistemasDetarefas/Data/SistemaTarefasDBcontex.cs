using Microsoft.EntityFrameworkCore;
using SistemasDetarefas.Models;

namespace SistemasDetarefas.Data
{
    public class SistemaTarefasDBcontex : DbContext
    {
        public SistemaTarefasDBcontex(DbContextOptions<SistemaTarefasDBcontex> options) : base(options)
        {

        }

        public DbSet<UsuarioModel> Usuarios { get; set; }

        public DbSet<TarefaModel> Tarefas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        internal void SavedChanges()
        {
            throw new NotImplementedException();
        }
    }
}
