Console.Clear();

Console.WriteLine("Digite o valor de X");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor de Y");
int y = int.Parse(Console.ReadLine());

// ! Exemplos de operação aritimetica
int soma = x + y;
int subtracao = x - y;
int multiplicacao = x * y;
int divisao = x / y;
int resto = x % y;

// ? console para exibir na tela as variaveis em cada linha
Console.WriteLine(" ");
Console.WriteLine($"Soma: {x} + {y} = {soma}");
Console.WriteLine($"Subtração: {x} - {y} = {subtracao}");
Console.WriteLine($"Multiplicação: {x} * {y} = {multiplicacao}");
Console.WriteLine($"Divisão: {x} / {y} = {divisao}");
Console.WriteLine($"Resto: {x} % {y} = {resto}");
Console.WriteLine(" ");

Console.WriteLine("=====================================================================");
Console.WriteLine("|                                                                   |");

int RestoXDivi2 = x % 2; // ? Checando se x é par (se é divisivel por 2)
int RestoyDivi2 = y % 2; // ? Checando se y é par (se é divisivel por 2)

if (RestoXDivi2 == 0) {
    Console.WriteLine($"| o numero {x} é par");
}else {
    Console.WriteLine($"| o numero {x} é inpar");
}
if (RestoyDivi2 == 0) {
    Console.WriteLine($"| o numero {y} é par");
}else {
    Console.WriteLine($"| o numero {y} é inpar");
}

Console.WriteLine("|                                                                   |");
Console.WriteLine("=====================================================================");
Console.WriteLine(" ");

// ? Operador ternario
// * condição ? se verdade : se não
Console.WriteLine((RestoyDivi2 == 0) ? $"{y} é um numero par (ternario)" : $"{y} não é um numero par (ternario)");
Console.WriteLine(" ");

//! aprendendo o switch case

 Console.WriteLine("Que dia é hoje ? (em numeros)");
int DiaSemana = int.Parse(Console.ReadLine()); 

switch (DiaSemana)
{
    case 1:
        Console.WriteLine("Hoje é domingo");
        break;
    case 2:
        Console.WriteLine("Hoje é Seunga");
        break;
    case 3:
        Console.WriteLine("Hoje é Terça");
        break;
    case 4:
        Console.WriteLine("Hoje é Quarta");
        break;
    case 5:
        Console.WriteLine("Hoje é Quinta");
        break;
    case 6:
        Console.WriteLine("Hoje é Sexta");
        break;

    default:
        Console.WriteLine("Hoje é sabado");
        break;
}
Console.WriteLine(" ");
