// See https://aka.ms/new-console-template for more information

/****************************************************************************************************************************
30) O departamento que controla o índice de poluição do meio ambiente mantém 3 grupos de indústrias que são altamente 
poluentes do meio ambiente. O índice de poluição aceitável varia de 0,05 até 0,25. Se o índice sobe para 0,3 as indústrias 
do 1o grupo são intimadas a suspenderem suas atividades, se o índice cresce para 0,4 as do 1o e 2o grupo são intimadas a 
suspenderem suas atividades e se o índice atingir 0,5 todos os 3 grupos devem ser notificados a paralisarem suas atividades. 
Escrever um algoritmo que lê o índice de poluição medido e emite a notificação adequada aos diferentes grupos de empresas.
****************************************************************************************************************************/

float indice;

Console.WriteLine("+--------------------------+");
Console.WriteLine("Informe o indice de poluição");
Console.WriteLine("+--------------------------+");

indice = float.Parse(Console.ReadLine());

if (indice > 5 && indice <= 25)
{
    Console.WriteLine("+--------------------------+");
    Console.WriteLine("Índice de poluição aceitável");
    Console.WriteLine("+--------------------------+");
}
else if (indice > 25 && indice <= 30) 
{
    Console.WriteLine("+-----------------------------------+");
    Console.WriteLine("Grupo 1 Favor suspender as atividades");
    Console.WriteLine("+-----------------------------------+");
}
else if (indice > 30 && indice <= 49)
{
    Console.WriteLine("+--------------------------------------------+");
    Console.WriteLine("Grupo 1 e Gupo 2 Favor suspender as atividades");
    Console.WriteLine("+--------------------------------------------+");
}
else if (indice >= 50)
{
    Console.WriteLine("+----------------------------------------------------------+");
    Console.WriteLine("Grupo 1 Gupo 2 e Grupo 3 Favor suspender todas as atividades");
    Console.WriteLine("+----------------------------------------------------------+");
}
else
{
    Console.WriteLine("+----------------------------------------------+");
    Console.WriteLine("Atenção!!! Digite um índice igual ou maior que 5");
    Console.WriteLine("+----------------------------------------------+");
}
