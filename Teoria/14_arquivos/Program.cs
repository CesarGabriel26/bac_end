using System.IO;

class Program
{
    public static string FilePath = "Arquivos/Arquivo.txt";
    public static void Main()
    {
        Console.Clear();
        
        GravarArquivo();
        LerArquivo();
    }

    public static void GravarArquivo()
    {
        try
        {
            using (StreamWriter arquivo = new StreamWriter(FilePath, true))
            {
                Console.Write("Digite algo:");
                arquivo.WriteLine(Console.ReadLine());
                Console.WriteLine("Arquivo atualizado");

            }

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro : {ex.Message}");
        }
    }
    public static void LerArquivo()
    {
        try
        {
            if(File.Exists(FilePath) == false)
            {
                File.Create(FilePath);
            }

            using (StreamReader arquivo = new StreamReader(FilePath))
            {
                string Linha;
                while ((Linha = arquivo.ReadLine()) != null)
                {
                    Console.WriteLine(Linha);
                    
                }
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro : {ex.Message}");
        }
    }
}