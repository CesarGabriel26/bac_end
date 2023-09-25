//! recebendo nome do aluno
Console.Clear();

Console.WriteLine(" ");
Console.Write("Digite o nome do aluno(a) :> ");
string Nome = Console.ReadLine();

Console.WriteLine(" ");
Console.Write("Digite o a primeira nota do aluno(a) :> ");
int Nota1 = int.Parse(Console.ReadLine());

Console.WriteLine(" ");
,00000000000000
Console.Write("Digite a segunda nota do aluno(a) :> ");
int Nota2 = int.Parse(Console.ReadLine());

Console.WriteLine(" ");
Console.Write("Digite a terceira nota do aluno(a) :> ");
int Nota3 = int.Parse(Console.ReadLine());
Console.WriteLine(" ");

float Media = (Nota1 + Nota2 + Nota3) / 3;

Console.WriteLine((Media >= 7)? $"O aluno(a) {Nome} esta apovado com uma media de {Media}" : $"O aluno(a) {Nome} esta reapovado com uma media de {Media}");
Console.WriteLine(" ");
