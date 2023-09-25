class Programa
{

    public static void Main()
    {
        for (int i = 0; i <= 10; i += 5)
        {
            Console.WriteLine($"O valor de i é :> {i}");
        }

        Console.WriteLine(" ");

        for (int Decrece = 10; Decrece >= 0; Decrece--)
        {
            Console.WriteLine($"O valor de Decrece é :> {Decrece}");
        }

        Console.WriteLine(" ");

        for (int Cont = 1; Cont <= 10; Cont++)
        {
            Console.WriteLine($"87 x {Cont} = {Cont * 87}");
        }

        Console.WriteLine(" ");

        //* Declarando um vetor com 34 posições
        string[] alunos = new string[34];

        //! atribuindo valores ao vetor
        alunos[1] = "Abner";
        alunos[2] = "Adalberto Kaio";
        alunos[3] = "Ana carolina";
        alunos[33] = "Samuel";

        foreach (string Aluno in alunos)
        {
            //Console.WriteLine(Aluno);
            if (Aluno != null)
            {
                Console.WriteLine(Aluno);
            }
        }

        int[] cadeiras = new int[5];
        cadeiras[0] = 5;
        cadeiras[4] = 34;
        cadeiras[1] = 69;
        cadeiras[2] = 99;
        cadeiras[3] = 50;

        int MaiorValor = 0;
        int MenorValor = 100;
        int Soma = 0;

        foreach (int cadeira in cadeiras)
        {
            if (cadeira < MenorValor)
            {
                MenorValor = cadeira;
            }

            if (cadeira > MaiorValor)
            {
                MaiorValor = cadeira;
            }
            

            Soma += cadeira;

        }

        Console.WriteLine($"Menor valor :> {MenorValor}");
        Console.WriteLine($"Maior valor :> {MaiorValor}");
        Console.WriteLine($"Soma dos valores :> {Soma}");
        
        Array.Sort(cadeiras);

        for (int cadeira = 0; cadeira < cadeiras.Length; cadeira++)
        {
            Console.WriteLine($"a cadeira {cadeira} corresponde ao valor {cadeiras[cadeira]}");
            
        }

    }

}