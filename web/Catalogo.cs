using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web
{
    public class Catalogo : ICatalogo
    {
        public List<Livro> GetLivros()
        {
            var livros = new List<Livro>();
            livros.Add(new Livro("001", "Quem mexeu no meu teste ", 12.99m));
            livros.Add(new Livro("002", "Fique rico com C# ", 22.99m));
            livros.Add(new Livro("003", "Quem quer doce ", 1.99m));

            return livros;
        }
    }
}
