// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string nome;
int idade;
char sexo;
double salario;

Console.Write("Informe o seu nome: ");
nome = Console.ReadLine();

Console.Write("Informe a sua idade: ");
idade = Convert.ToInt16(Console.ReadLine());

Console.Write("Informe o seu sexo M ou F: ");
sexo = Convert.ToChar(Console.ReadLine());

Console.Write("Informe o seu salario: ");
salario = Convert.ToDouble(Console.ReadLine());

Console.ReadKey();//Aguarda clicar em uma tecla


