using Models.Produtos;
using Models.Users;

namespace Models.Pedidos
{
    public class Pedido
    {
     
        private Produto? ProdutoPedido { get; set;}
        private int Quantidade { get; set;} = 0;
        private User? UserQueFezOPedido { get; set;}
     
        public Pedido(Produto produt, int QUanti, User Usuario) {
            this.ProdutoPedido = produt;
            this.Quantidade = QUanti;
            this.UserQueFezOPedido = Usuario;
        }

        public void PedidoStatos() {
            Console.WriteLine($"Produto : {ProdutoPedido} || Quantidade: {Quantidade} || UserQueFezOPedido: {UserQueFezOPedido}");
            
        }
    }
}