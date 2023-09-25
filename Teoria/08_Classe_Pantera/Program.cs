using Animal.Model;

class Program
{
    public static void Main() {
        Console.Clear();
        
        var pantera = new Pantera();

        pantera.Tamanho = 2,55M;
        pantera.Peso = 80;
        pantera.Cor = "Rosa";
        pantera.Especie = "Unknow";
        pantera.Alimentacao = "Carne";

        pantera.Correr();

        Console.WriteLine(" ");
        
        pantera.Cacar();

        Console.WriteLine(" ");

        pantera.Reproduzir();

        Console.WriteLine(" ");
        //!Função cirada para exibir as propriedades do objeto no console
        pantera.Status();

        Console.WriteLine(" ");
    }
}