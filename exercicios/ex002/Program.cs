Console.Clear();
Console.Write("Digite sua placa :> ");

string Placa = Console.ReadLine();

int ultimodigito = int.Parse(Placa.Substring(6));

switch (ultimodigito)
{
    case 1:
        Console.WriteLine($"Seu dia de rodízio no transito de SP :> segunda");
        break;
    case 2:
        Console.WriteLine($"Seu dia de rodízio no transito de SP :> segunda");
        break;

    case 3:
        Console.WriteLine($"Seu dia de rodízio no transito de SP :> terça");
        break;
    case 4:
        Console.WriteLine($"Seu dia de rodízio no transito de SP :> terça");
        break;

    case 5:
        Console.WriteLine($"Seu dia de rodízio no transito de SP :> quarta");
        break;
    case 6:
        Console.WriteLine($"Seu dia de rodízio no transito de SP :> quarta");
        break;

    case 7:
        Console.WriteLine($"Seu dia de rodízio no transito de SP :> quinta");
        break;
    case 8:
        Console.WriteLine($"Seu dia de rodízio no transito de SP :> quinta");
        break;

    default:
        Console.WriteLine($"Seu dia de rodízio no transito de SP :> sexta");
        break;
}
