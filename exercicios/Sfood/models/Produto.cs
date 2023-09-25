namespace Models.Produtos
{
    public class Produto
    {
     
        public string Empresa { get; set;} = "";
        public string Nome { get; set;} = "";
        private string Id { get; set;} = "";
        public double Preco { get; set;} = 0;
        private double Hate { get; set;} = 0;

        public Produto(string Empresa_, string Nome_, string Id_,double Preco_,double Hate_) {
            this.Empresa = Empresa_;
            this.Nome = Nome_;
            this.Id = Id_;
            this.Preco = Preco_;
            this.Hate = Hate_;
        }
    }
}