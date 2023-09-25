using Models.Produtos;
using System.Collection.Generic;

namespace Models.Categorias
{
    public class Categoria
    {

        private string Nome { get; set; } = "";
        private List<Produto> ListaProdutos { get; set; } = new List<Produto>();

        public Categoria(string NomeCategoria) {
            this.Nome = NomeCategoria;
        }

        public Produto[] TodosProfutos()
        {
            return ListaProdutos;
        }

        public Produto ProdutoPorID(int id)
        {
            return ListaProdutos[id];
        }

        public void AddProduto(Produto Produto)
        {
            _ = ListaProdutos.Append(Produto);
        }

        public void Status() {
            Console.WriteLine($"Nome: {Nome} || ListaProdutos: {ListaProdutos}");
            
        }

    }



}