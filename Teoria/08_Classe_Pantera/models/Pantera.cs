namespace Animal.Model
{
    class Pantera {
        public decimal Tamanho { get; set; }
        public int Peso { get; set; }
        public string Cor { get; set; }
        public string Especie { get; set; }
        public string Alimentacao { get; set; }

        public void Correr() {
            Console.WriteLine("A pantera Esta correndo");
        }

        public void Cacar() {
            Console.WriteLine("A pantera Esta Caçando");
        }

        public void Reproduzir() {
            Console.WriteLine("A pantera Esta Resproduzindo ");
        }

        /*Escrever no console as informaçõpes do objeto pertencente a classe*/
        public void Status() {
            Console.WriteLine($"Tamanho: {Tamanho}");
            Console.WriteLine($"Peso: {Peso}");
            Console.WriteLine($"Cor: {Cor}");
            Console.WriteLine($"Especie: {Especie}");
            Console.WriteLine($"Alimentacao: {Alimentacao}");
        }

    }
}