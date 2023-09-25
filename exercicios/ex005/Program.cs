class Churras
{

    public static void Main()
    {
        Console.Clear();

        ListaDoChurrasco();
        SonhosDeConsumo();

    }


    public static void ListaDoChurrasco()
    {
        string[] ListaChurras = new string[6];

        for (int item = 0; item < ListaChurras.Length; item++)
        {
            Console.Write($"Digite qual sera o Item {item} da lista do churras :> ");

            ListaChurras[item] = Console.ReadLine();
        }

        Console.WriteLine(" ");
        Console.WriteLine("================== Lista do Churrasco ==================");
        Console.WriteLine(" ");

        Array.Sort(ListaChurras);

        for (int ItemChurras = 0; ItemChurras < ListaChurras.Length; ItemChurras++)
        {
            Console.WriteLine($"O item {ItemChurras} da lsita é {ListaChurras[ItemChurras]}");
        }

        Console.WriteLine(" ");

    }

    public static void SonhosDeConsumo()
    {
        string[] ListaSonho = new string[3];
        int[] ListaPreco = new int[3];

        float Soma = 0;

        for (int item = 0; item < ListaSonho.Length; item++)
        {

            Console.Write($"Digite qual sera o sonho {item} da lista do sonhos :> ");
            ListaSonho[item] = Console.ReadLine();
            Console.Write($"Digite qual sera o Custo para sonho {item} da lista do valor R$ :> ");
            ListaPreco[item] = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            Console.WriteLine("=================================================================================");
            Console.WriteLine(" ");

        }

        Console.WriteLine(" ");
        Console.WriteLine("==================== Lista De Sonhos ===================");
        Console.WriteLine(" ");

        for (int ItemListaSonho = 0; ItemListaSonho < ListaSonho.Length; ItemListaSonho++)
        {
            Console.WriteLine($"Para o sonho {ListaSonho[ItemListaSonho]} vc gastaria {ListaPreco[ItemListaSonho]}");
            Soma += ListaPreco[ItemListaSonho];
        }

        Console.WriteLine($"No total seria necessarios {Soma} dinheiros");

        Console.WriteLine(" ");

    }

}