//! o NameSpace é o nome que usaremos apra fazer referencia quando o chamarmos em outra classe
namespace Sesi.Model {

    //? declarando a classe aluno
    public class Aluno {

        //* Declarando nossos atributos da classe
        
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Turma { get; set; }

        private int nrFaltas { get; set; }

        public void Apresentar() {
            Console.WriteLine($"Meu nome é {Nome}, tenho {Idade} anos e estudo na turma {Turma}");
            
        }

        public void AddFaltas(int nr) {
            nrFaltas += nr;
        }

        public void JustificarFaltas(int nr) {
            nrFaltas -= nr;
        }

        public void ResumirFaltas() {
            Console.WriteLine($"O aluno {Nome} tem {nrFaltas} falta(s)");
        }

    }

}