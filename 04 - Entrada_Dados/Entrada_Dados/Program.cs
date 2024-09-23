// See https://aka.ms/new-console-template for more information

/* Falar sobre comentários depois de falar sobre entrada de Dados' e tem 3 formas 

//Forma 1

/*Forma2 

//Forma 3 é ctrl +k e  ctrl + c para comentar um bloco de código em específico
 */

string nome; //Tipo de Texto
int idade; // Tipo numérico

Console.Write("Insira o seu nome: "); //O Write pois o que o usuário escrever, ficará na frente do texto
nome = Console.ReadLine(); //Ler uma linha

Console.Write("Insira a sua idade: ");
//Antes disso eu vou colocar o texto como o do nome e depois coloco como está abaixo
//Procurar com os alunos a diferença entre int16, 32 e 64
idade = Convert.ToInt16(Console.ReadLine());


//Console.WriteLine(nome); //Exibe o valor da variável

Console.WriteLine("Seu nome é: " + nome + " e tem " + idade + " anos.");

Console.ReadKey(); //Aguarda pressionar uma tecla
