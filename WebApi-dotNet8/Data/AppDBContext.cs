using Microsoft.EntityFrameworkCore;
using WebApi_dotNet8.Models;

namespace WebApi_dotNet8.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)//opções/informações de conexão
        {

        }

        //quando criar a conexão com banco de dados, algumas tabelas já serão criadas
        public DbSet<AutorModel> Autores { get; set; } //cada propriedade dentro do modelo, será transformada em uma coluna
        public DbSet<LivroModel> Livro { get; set; } //cada propriedade dentro do modelo, será transformada em uma coluna

    }
}
