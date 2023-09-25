namespace Models.ALunos {

    //? declarando a classe aluno
    public class Aluno {

        public string Nome { get; set; }
        public int Idade { get; set; }

        public Aluno(string Nome_,int Idade_){
            this.Nome = Nome_;
            this.Idade = Idade_;
        }
        
    }

}