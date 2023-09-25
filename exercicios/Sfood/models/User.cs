namespace Models.Users
{
    public class User
    {
     
        public string Nome { get; set;} = "";
        private string Id { get; set;} = "";
        public string Email { get; set;} = "";
        private string Senha { get; set;} = "";
        private string Endereco { get; set;} = "";

        public User(string Nome_,string Id_,string Email_,string Senha_,string Endereco_) {
            this.Nome = Nome_;
            this.Id = Id_;
            this.Email = Email_;
            this.Senha = Senha_;
            this.Endereco = Endereco_;
        }
     
    }
}