/*
//! Decralando uma variavel int(Inteira) sem matribuir valor
int num1;

// * Declaranto uma variavel int(inteira) atribuindo um valor
int num2 = 5;
// * printando a variavel num 2 || Retorno -> 5
Console.WriteLine(num2);

// * Declarando uma variavel tipo String(texto)
string NomeAluno = "Cesar";

// * Declarando uam varivel boll(Boleana -> true or false)
bool atribuindo = false;

// ? Declarando uma variavel do tipo double -> com varias casas decimais
double coordenadas = 1.458614515562552;
// ? Variavel do tipo decimal -> utilizada para valores com poucas casas decimais
decimal valor = 1.80m;
*/

int idade = 16;
string MeuNome = "Cesar Gabriel";
Console.Clear();
Console.WriteLine(" ");
Console.WriteLine($"Meu nome é {MeuNome} e tenho {idade} anos");
Console.WriteLine(" ");

Console.WriteLine("em qual cidade vc nasceu?");
//! Read line serve apenas para receber informação do usuario (texto digitado no console)
string Cidade = "a"; //Console.ReadLine(); //! E armazenalo em uma variavel
Console.WriteLine(" ");
Console.WriteLine($"Voce nasceu em {Cidade}, uau que incrivel eu vim de {Cidade} tambem");