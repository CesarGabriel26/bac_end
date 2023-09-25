
/*
!Formato de um metodo em C#
publick static void NomeDaFuncao(parametro){
}
*/

class Sesi
{
    public static void Main()
    {
        /*Console.Clear();
        Mensagem("Muito foda essa aula « ♣☼©♫");

        ImprimirDataEHOra();

        ContarAte10(540);
        

        Console.WriteLine($"Soma de 5 + 5 = {Somar(5,5)}");
        Console.WriteLine($"5²= {Potencia(5,2)}");*/

        JogoDeSdivinharNumeors();
    }

    //Metodo sem retorno || com paramertor
    public static void Mensagem(string mensagem)
    {
        Console.WriteLine(mensagem);
    }

    //Metodo sem retorno || Sem parametro
    public static void ImprimirDataEHOra()
    {
        Console.WriteLine(DateTime.Now.ToString());

    }

    /******************************************************************************/

    //Metodo com retorno || com parametros
    public static int Somar(int a, int b)
    {
        return a + b;
    }

    public static double Potencia(int numero, int Expoente)
    {
        return Math.Pow(numero, Expoente);
    }

    //Metodo sem retorno || sem parametros
    public static void ContarAte10(int contador)
    {

        while (contador > 0)
        {
            Console.WriteLine(contador);
            contador--;
            System.Threading.Thread.Sleep(100);
        }
    }

    public static void JogoDeSdivinharNumeors()
    {
        Console.Clear();

        Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * *");
        Console.WriteLine("             BEM VINDO AO JOGO             ");
        Console.WriteLine("Sorteei um nº de 1 a 20, tente adivinha-lo!");
        Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * *");

        Console.WriteLine(" ");

        Random rnd = new Random();
        int NSorteado = rnd.Next(20);
        int NDigitado = -1;

        int tentativas = 10;

        do
        {

            Console.Write("Digite um numero :> ");
            NDigitado = int.Parse(Console.ReadLine());

            if (NDigitado > NSorteado)
            {
                Console.Clear();
                
                Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * *");
                Console.WriteLine("             BEM VINDO AO JOGO             ");
                Console.WriteLine("Sorteei um nº de 1 a 20, tente adivinha-lo!");
                Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * *");

                Console.WriteLine(" ");


                Console.WriteLine($"O numero que pensei é menor do que {NDigitado}");
            }
            else if (NDigitado < NSorteado)
            {
                Console.Clear();
                
                Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * *");
                Console.WriteLine("             BEM VINDO AO JOGO             ");
                Console.WriteLine("Sorteei um nº de 1 a 20, tente adivinha-lo!");
                Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * *");

                Console.WriteLine(" ");

                Console.WriteLine($"O numero que pensei é maior do que {NDigitado}");
            }
            tentativas--
        } while (NDigitado != NSorteado || tentativas <= 0);

        Console.WriteLine($"Parabans o numero escolhido era {NSorteado}");


    }
}
