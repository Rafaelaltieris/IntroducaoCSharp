string nome = "Prof ° Rafael Altieris";
int idade  = 23;

//Char recebe apenas um caractér, e tem que ser com o apóstrofo ('')
char sexo = 'M';

//Padrão americano é de que se utiliza o ponto no lugar de virgula
double salario = 2.500;
bool cadastrado = true; //assume dois valores true || false


//Forma 1 com Concatenação (+). Exemplo está abaixo e basta descomentar e mostrar o resultado
//Console.WriteLine($"Meu nome é: " + nome);

//Forma 2 com $ antes da virgula e chaves com o nome da variável desejada. Exemplo está abaixo e basta descomentar e mostrar o resultado
//Console.WriteLine($"Meu nome é: {nome}");


//Nome e Idade com concatenação
//Console.WriteLine("Meu nome é: " + nome + " e tenho: " + idade + " anos");

//Exibe o valor de uma variável. Saída de dados
Console.WriteLine(salario);

/*aguarda que o usuário pressione qualquer tecla no console.
Ele é comumente utilizado para pausar a execução de um programa até que o usuário interaja com o console.
 */

Console.ReadKey();
