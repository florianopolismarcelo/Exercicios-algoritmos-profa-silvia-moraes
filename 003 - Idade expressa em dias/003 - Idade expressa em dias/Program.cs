// See https://aka.ms/new-console-template for more information

/************************************************************************************
* 03) Faça um algoritmo que leia a idade de uma pessoa expressa em anos, meses e dias 
* e mostre-a expressa apenas em dias. Considerar ano com 365 dias e mês com 30 dias.
************************************************************************************/

int idade, meses, dia, quantidadeDias;

Console.WriteLine("Quantos anos você tem?");
idade = int.Parse(Console.ReadLine());

Console.WriteLine("Informe o dia que você nasceu");
dia = int.Parse(Console.ReadLine());

Console.WriteLine("Informe o mês que você nasceu");
meses = int.Parse(Console.ReadLine());

quantidadeDias = (365 * idade);
meses = (meses * 30);
quantidadeDias = quantidadeDias + meses + dia;

//quantidadeDias = (dia+(idade*365)+(meses*30));

Console.WriteLine("Quantidade de dias de vida " + quantidadeDias);
