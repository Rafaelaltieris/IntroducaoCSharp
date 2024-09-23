/* Exemplo de switch em c# */

Console.WriteLine("Escolha um número de 1 a 5:");
int numeroEscolhido = int.Parse(Console.ReadLine());

switch (numeroEscolhido)
{
    case 1:
        Console.WriteLine("Você escolheu o número 1.");
        break;
    case 2:
        Console.WriteLine("Você escolheu o número 2.");
        break;
    case 3:
        Console.WriteLine("Você escolheu o número 3.");
        break;
    case 4:
        Console.WriteLine("Você escolheu o número 4.");
        break;
    case 5:
        Console.WriteLine("Você escolheu o número 5.");
        break;
    default:
        Console.WriteLine("Número fora do intervalo permitido.");
        break;
}
Console.WriteLine("Digite uma tecla para encerrar o programa!");
Console.ReadKey();