// See https://aka.ms/new-console-template for more information
string[] diaSemana = new string[] {
    "Segunda-Feira",
    "Terça-Feira",
    "Quarta-Feira",
    "Quinta-Feira",
    "Sexta-Feira",
    "Sábado",
    "Domingo"
};

for (int i = 0; i < diaSemana.Length ; i++)
{
    Console.WriteLine(diaSemana[i]);
}

Console.ReadKey();