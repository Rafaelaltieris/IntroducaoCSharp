// See https://aka.ms/new-console-template for more information

// While = Enquanto uma condição for satisfeita, eu executo algo


//Exemplos 1. Depois é só descomentar ele para utilizar
//int posicao = 0;

//while (posicao < 6)
//{
//    Console.WriteLine(posicao);

//    posicao++;
//    //posicao = (posicao + 1)
//}


//Exemplo 2

//string[] diaSemana = new string[] {
//    "Segunda-Feira",
//    "Terça-Feira",
//    "Quarta-Feira",
//    "Quinta-Feira",
//    "Sexta-Feira",
//    "Sábado",
//    "Domingo"
//};

//int posicao = 0;

//while (posicao < diaSemana.Length)
//{
//    Console.WriteLine(diaSemana[posicao]);
//    posicao++;
//}


//Exemplo 3 com switch e While
Console.WriteLine("Saudação");
Console.WriteLine("1 - Olá, bom dia");
Console.WriteLine("2 - Olá, boa tarde");
Console.WriteLine("3 - Olá, boa noite");
Console.WriteLine("4 - Sair");

int opcao;
//Converte o valor que o usuário colocou em um inteiro e qualquer coisa
// que não seja um número irá retornar uma exceção de valor inválido.
int.TryParse(Console.ReadLine(), out opcao);


//
while (opcao != 4)
{
    switch(opcao)
    {
        case 1:
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Olá, bom dia");
            break;
        case 2:
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Olá, boa tarde");
            break;
        case 3:
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Olá, boa noite");
            break;
        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Valor Inválido");
            break;
    }

    Console.ResetColor(); //Restaura o menu para a cor padrão
    Console.WriteLine("Pressione uma tecla para continuar!");
    Console.ReadKey();
    Console.Clear(); // Limpa os textos do console


    Console.WriteLine("Saudação");
    Console.WriteLine("1 - Olá, bom dia");
    Console.WriteLine("2 - Olá, boa tarde");
    Console.WriteLine("3 - Olá, boa noite");
    Console.WriteLine("4 - Sair");

    //monitora novamente o valor que o usuário digitou
    int.TryParse(Console.ReadLine(), out opcao);
}


Console.ReadKey();