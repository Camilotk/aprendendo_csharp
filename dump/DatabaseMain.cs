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

