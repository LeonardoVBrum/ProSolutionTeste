using DesafioProSolutionsAPI.Models;
using System.Data.Entity;


namespace DesafioProSolutionsAPI.Data
{
    public class ArquivoDbContext : DbContext
    {
        // Construtor que define a string de conexão a ser usada.

        // Construtor que chama a base com a string de conexão configurada no Web.config
        public ArquivoDbContext() : base("name=DesafioProSolutionsDb")
        {
        }

        // DbSet representa a tabela de arquivos no banco de dados
        public DbSet<ArquivosModel> Arquivos { get; set; }
    }
}


