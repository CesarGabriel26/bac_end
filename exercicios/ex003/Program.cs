Console.Write("Escreva o numero do mes :> ");
int mes = int.Parse(Console.ReadLine());

switch (mes)
{
    case 1:
        Console.Write("O mes 1 é Janeiro,e em 2023 ele tem 31 dias");
        break;
    case 2:
        Console.Write("O mes 2 é Fevereiro,e em 2023 ele tem 28 dias");
        break;
    case 3:
        Console.Write("O mes 3 é Março,e em 2023 ele tem 31 dias");
        break;
    case 4:
        Console.Write("O mes 4 é Abril,e em 2023 ele tem 30 dias");
        break;
    case 5:
        Console.Write("O mes 5 é Maio,e em 2023 ele tem 31 dias");
        break;
    case 6:
        Console.Write("O mes 6 é Junho,e em 2023 ele tem 30 dias");
        break;
    case 7:
        Console.Write("O mes 7 é Julho,e em 2023 ele tem 31 dias");
        break;
    case 8:
        Console.Write("O mes 8 é Agosto,e em 2023 ele tem 30 dias");
        break;
    case 9:
        Console.Write("O mes 9 é Setembro,e em 2023 ele tem 31 dias");
        break;
    case 10:
        Console.Write("O mes 10 é Outubro,e em 2023 ele tem 30 dias");
        break;
    case 11:
        Console.Write("O mes 11 é Novembro,e em 2023 ele tem 31 dias");
        break;
    case 12:
        Console.Write("O mes 12 é Dezembro,e em 2023 ele tem 30 dias");
        break;
    
    default:
        Console.Write("Adicione um mes valido");
        break;
}
