using Microsoft.EntityFrameworkCore;
using EFCurso.Models;
namespace EFCurso.Database
{
    public class ApplicationDBContext : DbContext
    {

        public DbSet<Funcionario> Funcionarios {get; set;}
        public DbSet<Categoria> Categorias { get; set; }

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options){}
    }
}