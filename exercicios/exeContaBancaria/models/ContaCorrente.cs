namespace Contas
{
    public class ContaCorrente
    {
     
        private string Titular { get; set;} = "";
        private float Saldo { get; set; } = 0;

        public ContaCorrente(string Usuario) {
            this.Titular = Usuario;
        }

        public void ConferirSaldo() {
            Console.WriteLine($"A conta pertencente a {Titular} posui R${Saldo} rais em seu saldo atualmente");
        }

        public void Sacar(float valor) {

            if (Saldo > valor)
            {
                Console.WriteLine($"Saque de R${valor} reais efetuado com exito");
                Saldo -= valor;
            }else {
                Console.WriteLine($"O valor digitado esta acima do saldo atual da conta");
            }            
        }

        public void Depositar(float valor) {
            Console.WriteLine($"Deposito de R${valor} reais efetuado com exito");
            Saldo += valor;
        }
     
    }

    
}