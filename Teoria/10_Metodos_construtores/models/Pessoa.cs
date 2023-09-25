namespace Models
{
    public class Pessoa
    {

        private string Nome { get; set; }
        private int Idade { get; set; }

        private string Email { get; set;}
        private int AnoDeNacimento { get; set;}

        public Pessoa(string NomeDaPessoa,int IdadeDaPessoa, string EmailDaPessoa) {
            this.Nome = NomeDaPessoa;
            this.Idade = IdadeDaPessoa;
            this.Email = EmailDaPessoa;
            this.AnoDeNacimento = (DateTime.Now.Year - IdadeDaPessoa);
        }

        public void Cantar() {
            Console.WriteLine($"{Nome} esta cantando");
        }

        public void Status() {
            Console.WriteLine($"Infos da pessoa:");
            Console.WriteLine($"---Nome  : {Nome}");
            Console.WriteLine($"---Idade : {Idade}");
            Console.WriteLine($"---Email : {Email}");
            Console.WriteLine($"---AnoDeNacimento : {AnoDeNacimento}");
        }

        
    }
}