using Microsoft.EntityFrameworkCore;
using EFCurso.Models;
namespace EFCurso.Database
{
    public class ApplicationDBContext : DbContext
    {

        public DbSet<Funcionario> Funcionarios {get; set;}
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options){}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Ativando o LazyLoading.
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Metodo será chamado sempre que vc for gerar suas entidades.

            //Mudar o nome da tabela.
            modelBuilder.Entity<Produto>().ToTable("Produtos_Alt");

            //Midar atributos da tabela
            modelBuilder.Entity<Produto>().Property(p => p.Nome).IsRequired();
            modelBuilder.Entity<Produto>().Property(p => p.Nome).HasMaxLength(50);

        }

    }
}