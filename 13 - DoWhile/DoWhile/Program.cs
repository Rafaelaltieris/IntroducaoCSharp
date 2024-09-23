int opcao;

do
{
    Console.WriteLine("Menu:");
    Console.WriteLine("1. Exibir uma mensagem");
    Console.WriteLine("2. Fazer uma soma");
    Console.WriteLine("3. Sair");
    Console.Write("Escolha uma opção: ");
    int.TryParse(Console.ReadLine(), out opcao);

    switch (opcao)
    {
        case 1:
            Console.WriteLine("Olá! Você escolheu exibir uma mensagem.");
            break;
        case 2:
            Console.Write("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"A soma é: {num1 + num2}");
            break;
        case 3:
            Console.WriteLine("Saindo do programa...");
            break;
        default:
            Console.WriteLine("Opção inválida! Tente novamente.");
            break;
    }

    Console.WriteLine(); // Linha em branco para melhor visualização
} while (opcao != 3);

Console.ReadKey();