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