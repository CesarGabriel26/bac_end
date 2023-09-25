using Models;

class Program
{
    public static void Main() {
        Console.Clear();
        
        /*//! Criando um objeto da classe pessoa
        //? Instanciando sem um mentodo construtor

        Pessoa pessoa1 = new Pessoa();

        pessoa1.Nome = "Pessoa1";
        pessoa1.Idade = 25;

        pessoa1.Cantar();

        //* Alternativa para criar um objeto sem construtor
        Pessoa pessoa2 = new Pessoa{
            Nome = "Pessoa2",
            Idade= 32
        };

        pessoa2.Cantar();*/
        Console.WriteLine(" ");

        Pessoa pessoa3 = new Pessoa("Pessoa3",25,"Pessoa3@Gmail.com");

        //pessoa3.Cantar();
        pessoa3.Status();

        Pessoa pessoa4 = new Pessoa("Pessoa4",90,"Pessoa4@Gmail.com");
        Console.WriteLine(" ");
        
        //pessoa4.Cantar();
        pessoa4.Status();

        Console.WriteLine(" ");
    }
    
}