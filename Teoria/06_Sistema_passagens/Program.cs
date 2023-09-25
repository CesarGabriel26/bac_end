class Program
{
    //! 43 pos ignoraremos a posição 0
    public static string[] Poltronas = new string[43];

    public static void Main() {
        Console.Clear();
        
        Console.WriteLine("Bem-vindo ao FoxBus");
        Console.WriteLine("-------------------");
        
        Console.WriteLine("Contamos com 42 Lugares disponiveis");
        
        Menu();

    }

    public static void Menu() {
        string opcao = "";

        do
        {
            Console.WriteLine("|-------------------  MENU  ------------------|");
            Console.WriteLine("|------------------- Digite ------------------|");
            Console.WriteLine("|   0 - Para Sair                             |");
            Console.WriteLine("|   1 - Para Comprar passagem                 |");
            Console.WriteLine("|   2 - Para Poltronas disponiveis            |");
            Console.WriteLine("|---------------------------------------------|");
            
            Console.Write("| :>");
            opcao = Console.ReadLine();
            Console.Clear();
            
            switch (opcao) {
                case "0":
                    Console.WriteLine("Obrigado, Volte sempre");
                    System.Threading.Thread.Sleep(1000);
                    break;
                case "1":
                    ComprarPassagem();
                    break;
                case "2":
                    PoltronasDisponiveis();
                    break;
                default:
                    Console.WriteLine("Opção invalida");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    break;
                
            }
            
        } while (opcao != "0");
        

    }

    public static void ComprarPassagem() {
        //? Perguntando ao usuario quantas passagens ele deseja comparar
        Console.Write("Quantas passagem deseja comprar? :> ");
        //? lendo e armazenando o valor digitado
        int nrPassagems = int.Parse(Console.ReadLine());

        //? criando um Loop pela quantidade de passagens que o usuario digitou
        for (int i = 0; i < nrPassagems; i++)
        {
            //? Requisitando que o usuario digite o numero da poltrona (1 a 42) que ele deseja
            Console.Write($"Digite o numero da poltrona para passagem {i} :> ");

            //? Lendo e armazenando o valor digitado pelo usuario em uma variavel do tipo int
            int nrAcento = int.Parse(Console.ReadLine());

            //! Checando se a poltrona escolhida não esta ocupada (se o valor nela é nulo)
            if (Poltronas[nrAcento] != null) {
                //! se o valor dela não for nulo avisaremos o usuario que ela esta ocupada
                Console.WriteLine("Este acento ja esta ocupado");
                //? retornando o i em -1 para que o usuario possa reescolher o numero da poltrona da quela passagem
                i--;
                //? esperando 1 segundo
                System.Threading.Thread.Sleep(1000);
                //? Limpando o console
                Console.Clear();
            }else{
                //! se o valor for nulo (poltrona vasia) o usuario podera requisitala

                //? Requisitando que o usuario digite o nome do passageiro que estara na poltrona
                Console.Write($"Digite o nome do passageiro para passagem {i} :>");
                //? lendo e armazenando o valor
                string NomePassageiro = Console.ReadLine();
                //?Chamando a função que marcara o nome dado para a poltrona escolhida
                MarcarPoutrona(nrAcento,NomePassageiro);
            }
        }
    }

    public static void MarcarPoutrona(int nrAcento, string NomePassageiro) {
        //? salvando | adicionando o nome recebido na posição da poltrona
        //todo || Exemplo: Poltronas[0] = "Pessoa0"
        Poltronas[nrAcento] = NomePassageiro;
    }

    public static void PoltronasDisponiveis(){
        Console.WriteLine("|------------------------------|");
        Console.WriteLine("|Lista de poltronas disponiveis|");
        Console.WriteLine("|------------------------------|");
        for (int i = 1; i < 42; i++)
        {
            if (Poltronas[i] == null)
            {
                Console.WriteLine($"Poltrona de numero {i} Esta disponivel");
            }
        }
        Console.WriteLine(" ");
        
    }
}

