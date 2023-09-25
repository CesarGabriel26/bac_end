using Contas;

class Program
{
    public static void Main()
    {
        Console.Clear();
        Console.WriteLine(" ");

        Console.Write("Digite o nome do Titular para acessar a conta :> ");
        string NomeDoTitular = Console.ReadLine();
        ContaCorrente NovaContaCorrente = new ContaCorrente(NomeDoTitular);

        string Comando = " ";

        do
        {
            Console.Clear();

            Console.WriteLine($"---{NomeDoTitular} seja bem-vindo(a) ao Bank!");
            Console.WriteLine(" ");
            Console.WriteLine("---Digite um dos comandos abaixo para proseguir");

            Console.WriteLine(" ");
            Console.WriteLine("--0 -> Sair");
            Console.WriteLine("--1 -> Depositar");
            Console.WriteLine("--2 -> Consultar Saldo");
            Console.WriteLine("--3 -> Sacar");
            Console.WriteLine(" ");

            Comando = Console.ReadLine();

            switch (Comando)
            {
                case "1":
                    Console.Clear();

                    Console.Write("Digite o valor de deposito (valor minimo R$10) :> ");

                    float ValorDigitado = float.Parse(Console.ReadLine());

                    if (ValorDigitado < 10)
                    {
                        Console.WriteLine("O valor digitado esta abaixo do minimo");
                        System.Threading.Thread.Sleep(1000);
                        break;

                    }
                    else
                    {
                        Console.WriteLine(" ");

                        NovaContaCorrente.Depositar(ValorDigitado);
                        System.Threading.Thread.Sleep(1000);
                    }

                    break;

                case "2":
                    Console.Clear();

                    NovaContaCorrente.ConferirSaldo();
                    System.Threading.Thread.Sleep(3000);

                    break;

                case "3":
                    Console.Clear();

                    Console.Write("Digite o valor de saque (valor minimo R$5) :> ");

                    float ValorDigitadoSaque = float.Parse(Console.ReadLine());

                    Console.WriteLine(" ");

                    NovaContaCorrente.Sacar(ValorDigitadoSaque);
                    System.Threading.Thread.Sleep(2000);

                    break;

                default:
                    break;
            }

        } while (Comando != "0");

        Console.Clear();

    }

}