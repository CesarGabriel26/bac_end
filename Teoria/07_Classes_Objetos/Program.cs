using Sesi.Model;

class Program
{

    public static void Main()
    {
        Console.Clear();

        var aluno1 = new Aluno();

        //* Atribuindo valos ao aluno
        aluno1.Nome = "Samuel";
        aluno1.Idade = 16;
        aluno1.Turma = "2ºEm";

        //* Chamando o metodo da classe aluno
        aluno1.Apresentar();
        aluno1.AddFaltas(10);
        aluno1.ResumirFaltas();
        aluno1.AddFaltas(7);
        aluno1.ResumirFaltas();
        aluno1.JustificarFaltas(8);
        aluno1.ResumirFaltas();

        var aluno2 = new Aluno();

        //* Atribuindo valos ao aluno
        aluno2.Nome = "Otavio";
        aluno2.Idade = 16;
        aluno2.Turma = "1ºEm";

        //* Chamando o metodo da classe aluno
        aluno2.Apresentar();

        //* ListaDeAlunos();
    }

    public static void ListaDeAlunos()
    {
        Console.Clear();

        Console.WriteLine(" ");
        Console.WriteLine("Quantos alunos deseja registrar");
        int NumAlunos = int.Parse(Console.ReadLine());

        Aluno[] listaDeAlunos = new Aluno[NumAlunos];

        for (int i = 0; i < NumAlunos; i++)
        {
            var aluno = new Aluno();

            Console.WriteLine($"Digite o nome do aluno {i}");

            aluno.Nome = Console.ReadLine();

            Console.Clear();
            Console.WriteLine($"Digite a idade do aluno {i}");
            aluno.Idade = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine($"Digite a turma do aluno {i}");
            aluno.Turma = Console.ReadLine();

            Console.Clear();
            listaDeAlunos[i] = aluno;
            Console.WriteLine($"Aluno {i} registrado");
        }
        Console.Clear();
        Console.WriteLine(" ");

        for (int i = 0; i < listaDeAlunos.Length; i++)
        {
            Console.WriteLine($"Eu sou o aluno {i}, meu nome é {listaDeAlunos[i].Nome}, tenho {listaDeAlunos[i].Idade} anos e estudo na turma {listaDeAlunos[i].Turma}");
        }
    }
}