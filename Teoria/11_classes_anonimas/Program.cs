public class Program
{
    public static void Main()
    {
        var pssoa1 = new {
            nome = "a",
            idade = 30
        };
        var pssoa2 = new {
            nome = "b",
            idade = 55
        };

        Console.WriteLine($"A pessoa é {pssoa1.nome} e tem {pssoa1.idade} anos");
        Console.WriteLine($"A pessoa é {pssoa2.nome} e tem {pssoa2.idade} anos");
        
        //Criar 2 objetos de calsse anonima de carro
        var Palho = new {
            Modelo = "Palho",
            Ano = "2016"
        };

        var Fusca = new {
            Modelo = "Fusca",
            Ano = "2000"
        };

        Console.WriteLine($"A o carro é do modelo {Palho.Modelo} e é do ano de {Palho.Ano}");
        Console.WriteLine($"A o carro é do modelo {Fusca.Modelo} e é do ano de {Fusca.Ano}");
    }   

}