// See https://aka.ms/new-console-template for more information

/**********************************************************************************
* 04) Faça um algoritmo que leia a idade de uma pessoa expressa em dias e mostre-a 
* expressa em anos, meses e dias. Considerar ano com 365 dias e mês com 30 dias.
**********************************************************************************/


int diasVida, idade, meses, dias = 0; 

Console.WriteLine("Quantos dias de vida você tem?");
diasVida = int.Parse(Console.ReadLine());

idade = diasVida / 365;
meses = diasVida / 30;
dias = diasVida % 30;

Console.WriteLine("Você tem : "+idade+" anos "+meses+" meses " +dias+ " dias de vida");







