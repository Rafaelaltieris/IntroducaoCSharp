// See https://aka.ms/new-console-template for more information

int idade;
Console.Write("Informe a sua idade: ");
int.TryParse(Console.ReadLine(), out idade);

char sexo;
Console.Write("Informe o seu sexo (M ou F): ");
char.TryParse(Console.ReadLine().ToUpper(), out sexo);
//Converte o char (que recebe apenas um caractér) em maiúsculo pela propriedade ToUpper()

bool temIngresso = true;
//Exemplo 2
if (temIngresso && idade >= 18 || sexo == 'F' && idade >= 18)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Olá, você pode entrar!");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Você não pode entrar!");
}


//Exemplo1
//if (idade >= 18 || sexo == 'f')
//{
//    Console.ForegroundColor = ConsoleColor.Green;
//    Console.WriteLine("Olá, você pode entrar!");
//}

//else
//{
//    Console.ForegroundColor= ConsoleColor.Red;
//    Console.WriteLine("Você não pode entrar!");
//}