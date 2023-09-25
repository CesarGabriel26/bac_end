using System.Collections.Generic;
using Models.ALunos;

public class Program
{
    public static void Main()
    {
        Console.Clear();

        /*

            ? Para criar uma lsita utilizamos o objeto 
            * List<T>

            % Que só se torna disponivel ao importarmos o namespace
            & System.Collections.Generic
        */

        //$ Criando uma Lista de numeros inteiros
        List<int> Numeros = new List<int>();

        //@ Usando o metodo Add para adicionar valores a lista
        Numeros.Add(10); //* Posição 0
        Numeros.Add(20); //* Posição 1
        Numeros.Add(30); //* Posição 2

        //% Acessando e Printando no console o valor armazenado no Index 0 da lista
        Console.WriteLine($"Numero na posição 0 : {Numeros[0]}");

        //# Exibindo no console quantos valores temos armazenados na lista
        Console.WriteLine($"Contagem de valores na lsita : {Numeros.Count} elementos");

        //& Fazendo um loop For Pelos valores
        //! e printando os valores encontrados na nossa lista
        foreach (var Numero in Numeros)
        {
            Console.WriteLine(Numero);
        }

        ListaDeNomes();
        ListaDeAlinos();
    }

    public static void ListaDeNomes()
    {
        Console.WriteLine(" ");

        List<string> Nomes = new List<string>();

        Nomes.Add("Manu");
        Nomes.Add("Samuel");
        Nomes.Add("Otavio");
        /*Nomes.Add("Abner");
        Nomes.Add("Enzo");
        Nomes.Add("Matheus");
        Nomes.Add("Yasmin");
        Nomes.Add("Cesar");*/


        Console.WriteLine($"Neste momento a {Nomes.Count} nomes armazenadaos");
        Console.WriteLine(" ");
        Console.WriteLine($"Nome armazenado na posição 0 : {Nomes[0]}");
        Console.WriteLine($"Nome armazenado na posição 1 : {Nomes[1]}");
        Console.WriteLine($"Nome armazenado na posição 2 : {Nomes[2]}");
        Console.WriteLine(" ");

        foreach (var Nome in Nomes)
        {
            Console.WriteLine($"{Nome}");
        }
        Console.WriteLine(" ");

        //&------------------------------------------------------------------------------------

        //! Criando lista ja preenchida com valores
        List<int> ListaDeNumeros = new List<int> { 1, 2, 3, 7, 8, 9 };
        Console.WriteLine($"Quantidade de elemento na lista de numeros {ListaDeNumeros.Count}");

        //@ Remover elementos
        ListaDeNumeros.Remove(5); // # Remove o Elemento/ Valor Expecificado 
        ListaDeNumeros.RemoveAt(1); // # Remove o Elemento no Index 1
        ListaDeNumeros.RemoveRange(2, 2); // # (Posição inicial,Quantidade de valores a remover)

        //$ Subistituir infos na lista
        ListaDeNumeros[0] = 58; // % Subistituindo o valor No Index 0 por 58

        foreach (var Numero_ in ListaDeNumeros)
        {
            Console.WriteLine($"{Numero_}");
        }
    }

    public static void ListaDeAlinos()
    {
        Console.WriteLine(" ");

        //% criando uma lista com objetos
        List<Aluno> ListaDeALunos = new List<Aluno>();

        //@ Criando um objeto alino e o adicionando a lista
        Aluno Aluno1 = new Aluno("Pedro", 16);
        ListaDeALunos.Add(Aluno1);

        ListaDeALunos.Add(new Aluno("Patricia", 18));
        ListaDeALunos.Add(new Aluno("Bob", 17));

        foreach (Aluno aluno in ListaDeALunos)
        {
            Console.WriteLine($"{aluno.Nome} de {aluno.Idade} anos");

        }

        Console.WriteLine(" ");

        //& Criando uma nova lista e a organixando pelo nome 
        var ordenacao = from aluno in ListaDeALunos orderby aluno.Nome select aluno.Nome;

        foreach (string aluno in ordenacao)
        {
            Console.WriteLine($"{aluno}");

        }

        Console.WriteLine(" ");

        //@ LINk usando sintaxe de consulta
        var ordenado = from aluno in ListaDeALunos
                       where aluno.Idade == 16
                       orderby aluno.Nome
                       select aluno.Nome;

        foreach (var item in ordenado)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine(" ");

        //@ LINk usando sintaxe de metodo
        var ordenado2 = from aluno in ListaDeALunos
                       where (aluno => aluno.Idade == 16)
                       orderby (aluno => aluno.Nome);

        foreach (var Aluno in ordenado2)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine(" ");
    }
}