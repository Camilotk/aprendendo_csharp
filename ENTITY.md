# Entity Framework Core
O Entity Framework Core é a ferramente de criação, edição e manipulação de Banco de Dados por ORM [¹](https://pt.stackoverflow.com/a/138943) do .NET Core. Podemos utilizar o Entity Framework Core para trabalhar com qualquer base de dados, seja ela SQLServer, MariaDB, Oracle, SQLite, PostgreSQL ou MYSQL utilizando o mesmo fluxo de trabalho e utilizando-se de abstrações do mais alto nível para transformar o modelo orientado à objetos do projeto em relações na Base de Dados, todo esse trabalho é feito pelo Framework, permitindo que o programador preocupe-se mais com a modelagem do projeto orientado à objetos e menos com a Base de Dados que está utilizando.  

## Tutorial
1. Para utilizar o Entity, primeiro devemos criar um Projeto, caso ainda não tenha feito-o, basta utilizar o comando **dotnet new** para isso.
```
dotnet new console -o TesteEntity
```
2. Acessar o Diretório do Projeto
```bash
cd ConsoleApp
```
3. Para usar o EF Core, instale o pacote do provedor do banco de dados para o qual você deseja direcionar, cada banco possui um pacote diferente para fazer a conexão, no caso do Postgres usamos o npgsql. Caso tenha dúvidas sobre como instalar um pacote no projeto pode acessar o Tutorial do [NuGET](https://github.com/Camilotk/aprendendo_csharp/blob/master/NUGET.md) aqui.
```
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL
dotnet add package Microsoft.EntityFrameworkCore.Tools
```
4. Confira no arquivo *.csproj* se as seguintes referências foram adicionadas.
```xml
 <ItemGroup>
    <PackageReference Include="Microsoft.EntityFrameworkCore" Version="2.2.6" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.Design" Version="2.2.6" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.Tools" Version="2.2.6">
      <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
      <PrivateAssets>all</PrivateAssets>
    </PackageReference>
    <PackageReference Include="Npgsql.EntityFrameworkCore.PostgreSQL" Version="2.2.4" />
  </ItemGroup>
```
5. Crie uma Classe *Context* que contêm as configurações de acesso e tabelas do banco.<br>
**BloggingContext.cs**<br>
```C#
using Microsoft.EntityFrameworkCore;

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
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=NOME_DATABASE;Username=postgres;Password=XXXX");
    }
}
```
6. Crie as Classes que representam a abstração dos dados que serão adicionados nas Tabelas.<br>
**Blog.cs**<br>
```C#
using System.Collections.Generic;

namespace TesteEntity
{
    public class Blog
    {
        /*
         * A propriedade BlogId será usada como chave primária da tabela que será 
         * gerada no banco. Essa nomenclatura é >reconhecida por padrão pelo 
         * Entity Framework e em seu lugar poderia ser usado Id
         */
        public int BlogId { get; set; }
        // Propriedade que armazena a URL
        public string Url { get; set; }

        // Uma Lista de Objetos Posts
        public ICollection<Post> Posts { get; set; }
    }
}
```
**Post.cs**<br>
```C#
namespace TesteEntity
{
      public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
```
5. Criar as migrações (_migrations_)(²)[https://docs.microsoft.com/pt-br/ef/core/managing-schemas/migrations/index] para criar e atualizar o banco de dados.<br>
*Cria o banco e tabelas*<br>
```
dotnet ef migrations add InitialCreate
```
*Aplica as atualizações*<br>
```
dotnet ef database update
```
6. Criar o **Main.cs** onde iremos executar algumas inserções e buscas no Banco.<br>
<p> <b>Main.cs</b> </p>
```C#
using System;

namespace TesteEntity
{
     public class Program
    {
        public static void Main()
        {
            using (var db = new BloggingContext())
            {

                // Adiciona um novo Objeto Blog à collection Blogs, isso depois
                // é mapeado no ORM transformando a Collectione em Tabela e o
                // Objeto em Input 
                db.Blogs.Add(new Blog { Url = "http://blogs.msdn.com/adonet" });
                // Salva as mudanças
                var count = db.SaveChanges();
                Console.WriteLine("{0} records saved to database", count);

                Console.WriteLine();
                // Acessa a lista de Blogs e retorna o endereço
                Console.WriteLine("All blogs in database:");
                foreach (var blog in db.Blogs)
                {
                    Console.WriteLine(" - {0}", blog.Url);
                }
            }
        }
    }
}
```
7. Executar o comando **dotnet run** e ver se teve a saída de acordo.<br>
```
dotnet run
```
<br>
**Saída:**
<br>

```
ConsoleApp.SQLite>dotnet run
1 records saved to database

All blogs in database:
- http://blogs.msdn.com/adonet
```
