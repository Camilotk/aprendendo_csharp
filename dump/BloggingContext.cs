using Microsoft.EntityFrameworkCore;

// Tutorial: https://docs.microsoft.com/pt-br/ef/core/get-started/netcore/new-db-sqlite
// Tutorial: http://www.npgsql.org/efcore/

namespace TesteEntity
{
    /*
     * DbContext é uma classe central do Entity Framework. Ela representa uma
     * abstração do banco de dados dentro da aplicação e é por meio dela que 
     * acessamos as tabelas (na forma de listas) e os registros (na forma de 
     * objetos).
     */
    public class BloggingContext : DbContext
    {
        /*
         * A classe DbSet representa uma coleção de objetos que será mapeada
         * como registros do banco de dados.
         * Cada DbSet representa uma tabela que será mapeada no Banco de Dados
         * neste caso teremos as tabelas: Blogs e Posts
         */ 
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=blogging.db");
        }
    }
}