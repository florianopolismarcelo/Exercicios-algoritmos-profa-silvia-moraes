// See https://aka.ms/new-console-template for more information

/***************************************************************************
15) Faça um algoritmo que leia um nº inteiro e mostre uma mensagem indicando 
se este número é par ou ímpar, e se é positivo ou negativo.
****************************************************************************/

int numero;

Console.WriteLine("Didite um número inteiro:");
numero = int.Parse(Console.ReadLine());

if (numero % 2 == 0 && numero > 0)
{
    Console.WriteLine("Número par e possitivo");
}
else if (numero % 2 == 1 && numero > 0)
{
    Console.WriteLine("Número impar e possitivo");
}
else if (numero % 2 == 0 && numero < 0)
{
    Console.WriteLine("Número par e negativo");
}
else
{
    Console.WriteLine("Número impar e negativo");
}