class Program
{
    public static void Main()
    {
        Console.Clear();
        SomaComDoWhile();

        /*Console.Write("Digite um numero para saber a taboada dele :> ");
        int NumeroParaTaboada = int.Parse(Console.ReadLine());
        TabuadaComWhile(NumeroParaTaboada);

        Console.Write("Digite um numero para saber qual sera o dobro dele :> ");
        float NumeroParaODobro = float.Parse(Console.ReadLine());
        Console.WriteLine(Dobro(NumeroParaODobro));

        Console.Write("Digite um numero para saber qual sera a metade dele :> ");
        float NumeroParaAMetade = float.Parse(Console.ReadLine());
        Console.WriteLine(Metade(NumeroParaAMetade));

        Console.Write("Deseja continuar? y/n :> ");
        DesejaContinuar = Console.ReadLine();*/

    }

    public static string Metade(float Num)
    {
        return $"O metade de {Num} é {Num / 2}";
    }

    public static string Dobro(float Num)
    {
        return $"O dobro de {Num} é {Num * 2}";
    }

    public static void TabuadaComWhile(int Num)
    {
        int contador = 0;

        while (contador < 10)
        {
            contador++;

            Console.WriteLine($"{Num} X {contador} = {Num * contador}");

        }

    }

    public static void SomaComDoWhile()
    {
        float menor = 10;
        float Maior = 0;
        float soma = 0;

        do
        {
            Console.WriteLine(" ");

            Console.Write("Escreva um numero Positivo :> ");
            int Num1 = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            /*Console.Write("Escreva um numero Positivo :> ");
            int Num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");*/

            if (Num1 < 0)
            {
                break;
            }

            if (Num1 > Maior)
            {
                Maior = Num1;
            }else if (Num1 < menor){
                menor = Num1;
            }

            
            Console.WriteLine($"{soma} + {Num1} = {soma + Num1} || Maior numero digitado: {Maior} || menor numero digitado: {menor} || SOMA ATUAL: {soma}");
            soma += Num1;
            Console.WriteLine(" ");

        } while (true);

        Console.WriteLine(" ");
        Console.WriteLine("Numero negativo detectado, saindo do loop");
        Console.WriteLine(" ");




    }
}