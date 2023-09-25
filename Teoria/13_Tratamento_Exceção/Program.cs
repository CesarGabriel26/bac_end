public class Program
{
    public static void Main()
    {
        //! try serve para tratar um erro e não parar o programa
        //?Se ocorrer qualquer erro dentro do bloco try o sistema enterrompe a execeução do bloco
        //*E vai para  bloco cat

        try
        {
            Console.Clear();

            int numero = 10;

            Console.Write("Digite um numero :> ");

            numero = int.Parse(Console.ReadLine());

            Console.WriteLine($"Numero digitado {numero}");

            int resultado = 10 / numero;

            Console.WriteLine($"o resultado de 10 / {numero} = {resultado}");

        }
        //! Tratando exceção de overflow
        //? estouro de campo
        catch (OverflowException){
            Console.WriteLine($"Erro | este numero é maior que o suportado");
        }
        //! Tratando exceção de erro de formato
        catch (FormatException)
        {
            Console.WriteLine($"Erro digite um numero inteiro");
        }
        //! catch é o tratamento de erro, normalmente colocamos de acordo com as mensagens recebidas
        //? com o tipo de erro, para meelhorar a compreenção d o usuario
        catch (Exception Ex)
        {
            Console.Clear();

            Console.WriteLine(" ");
            Console.WriteLine($"OCORREU UM ERRO {Ex.Message}");
            Console.WriteLine(" ");
            
        }
        //!O finally é o bloco executado indenpendentemente se ocorrer erro ou não
        finally 
        {
            Console.WriteLine("Entrando no finally");
            
        }
    }
}