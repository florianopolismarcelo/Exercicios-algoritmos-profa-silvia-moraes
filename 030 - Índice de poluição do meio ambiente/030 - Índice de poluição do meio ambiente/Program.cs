﻿// See https://aka.ms/new-console-template for more information

/****************************************************************************************************************************
30) O departamento que controla o índice de poluição do meio ambiente mantém 3 grupos de indústrias que são altamente 
poluentes do meio ambiente. O índice de poluição aceitável varia de 0,05 até 0,25. Se o índice sobe para 0,3 as indústrias 
do 1o grupo são intimadas a suspenderem suas atividades, se o índice cresce para 0,4 as do 1o e 2o grupo são intimadas a 
suspenderem suas atividades e se o índice atingir 0,5 todos os 3 grupos devem ser notificados a paralisarem suas atividades. 
Escrever um algoritmo que lê o índice de poluição medido e emite a notificação adequada aos diferentes grupos de empresas.
****************************************************************************************************************************/


float indice;
String grupo1, grupo2, grupo3;

Console.WriteLine("+----------------------------------------------------+");
Console.WriteLine("Digite o índice de poluição medido: 0.3 - 0.4 ou 0.5  ");
Console.WriteLine("");
Console.WriteLine("O índice de poluição aceitável varia de 0.05 até 0.25.");
Console.WriteLine("+----------------------------------------------------+");
indice = float.Parse(Console.ReadLine());

if (indice == 0.3 )
{
    Console.WriteLine("Grupo 1 Favor suspender as atividades");
}
if (indice > 0.3 && indice <= 0.4)
{
    Console.WriteLine("Grupo 1 e Gupo 2 Favor suspender as atividades");
}
if (indice == 5.0)
{
    Console.WriteLine("Grupo 1 - Gupo 2 e Grupo 3 Favor suspender todas as atividades");
}



