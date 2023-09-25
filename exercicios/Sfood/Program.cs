using Models.Categorias;
using Models.Pedidos;
using Models.Produtos;
using Models.Users;

class Program
{
    public static void Main()
    {
        Console.WriteLine(" ");
        
        User User1 = new User("A", "u001", "asdasd@gmail.com", "abublé", "8597-58");

        Produto Produto1 = new Produto("Mac", "BigMac", "p001", 15.88, 4.5);

        Categoria Lanches = new Categoria("Lanches");

        Lanches.AddProduto(Produto1);

        Pedido Pedido1 = new Pedido(Produto1,2,User1);

        Pedido1.PedidoStatos();
        Lanches.Status();

        Console.WriteLine(" ");
    }

}