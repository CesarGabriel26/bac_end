//! classe pai que sera herdarada pelo filho - SuperClasse
abstract class Animal
{
    public string cor { get; set; }

    public virtual void EmitirSom()
    {
        Console.WriteLine("Animal esta emitindo som");

    }
}
//! classe filha que herdara da classe Animal
//? recebera todos os atribulto e metodos da classe Animal
class Cachorro : Animal
{
    public string TipoDePelo { get; set; }

    public void Latir()
    {
        Console.WriteLine("O cachorro esta latindo");
    }
}

class Gato : Animal
{
    public string TipoDePelo { get; set; }

    public override void EmitirSom()
    {
        Console.WriteLine("O gato esta emitindo som");

    }

}

class program
{

    public static void Main()
    {
        Console.Clear();

        /*Animal animalgenerico = new Animal();
        animalgenerico.EmitirSom();*/

        Cachorro MeuCachorro = new Cachorro();
        MeuCachorro.TipoDePelo = "caramelo";
        MeuCachorro.Latir();

        var MeuGato = new Gato();
        MeuGato.EmitirSom();
    }
}