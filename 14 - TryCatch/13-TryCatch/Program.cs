//Exemplo de TryCatch com numerador e denominador
//  O bloco try-catch em C# permite que você execute um bloco de código (o try) que pode gerar exceções. Se uma exceção ocorrer
//  durante a execução desse bloco, o fluxo do programa é transferido para um dos blocos catch, onde você pode lidar com a exceção 
//  de maneira apropriada.

using System.Globalization;

/* Exemplo 1 com valores inteiros */
try
{
    Console.Write("Digite o numerador: ");
    int numerador = int.Parse(Console.ReadLine());

    Console.Write("Digite o denominador: ");
    int denominador = int.Parse(Console.ReadLine());

    int resultado = numerador / denominador;
    Console.WriteLine($"O resultado da divisão é: {resultado}");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Erro: Não é possível dividir por zero.");
}
catch (FormatException)
{
    Console.WriteLine("Erro: Por favor, digite números válidos.");
}

Console.ReadKey();// Aguarda o usuário clicar em uma tecla para finalizar.


/* Exemplo 2 Com Casas decimais utilizando o Double e convertendo esses valores com o Try Parse */
/* Caso queira demonstrar, basta descomentar essa seção e comentar a seção acima do exemplo 1. */

//try
//{
//    Console.Write("Digite o numerador: ");
//    double numerador;
//    while (!double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out numerador))
//    {
//        Console.WriteLine("Erro: Por favor, digite um número válido.");
//        Console.Write("Digite o numerador: ");
//    }

//    Console.Write("Digite o denominador: ");
//    double denominador;
//    while (!double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out denominador))
//    {
//        Console.WriteLine("Erro: Por favor, digite um número válido.");
//        Console.Write("Digite o denominador: ");
//    }

//    double resultado = numerador / denominador;
//    Console.WriteLine($"O resultado da divisão é: {resultado}");
//}
//catch (DivideByZeroException)
//{
//    Console.WriteLine("Erro: Não é possível dividir por zero.");
//}

//Console.ReadKey();