using Microsoft.EntityFrameworkCore;

namespace Ginasio.Models
{
    public class GinDbContext : DbContext
    {
        public GinDbContext(DbContextOptions<GinDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Plano> Planos { get; set; }
        public DbSet<Inscricao> Inscricoes { get; set; }
        public DbSet<Pagamento> Pagamentos { get; set; }
        public DbSet<Aula> Aulas { get; set; }
        public DbSet<Agendamento> Agendamentos { get; set; }
        public DbSet<Equipamento> Equipamentos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>()
                .HasMany(u => u.Inscricoes)
                .WithOne(i => i.Usuario)
                .HasForeignKey(i => i.UsuarioId);

            modelBuilder.Entity<Usuario>()
                .HasMany(u => u.Pagamentos)
                .WithOne(p => p.Usuario)
                .HasForeignKey(p => p.UsuarioId);

            modelBuilder.Entity<Aula>()
                .HasOne(a => a.Instrutor)
                .WithMany()
                .HasForeignKey(a => a.InstrutorId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }

}
