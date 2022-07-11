// See https://aka.ms/new-console-template for more information

/***************************************************************************
13) Escreva um algoritmo que leia 3 números inteiros e mostre o maior deles.
****************************************************************************/

int numero1, numero2, numero3;

Console.WriteLine("Informe o primeiro numero:");
numero1 = int.Parse(Console.ReadLine());

Console.WriteLine("Informe o segundo numero:");
numero2 = int.Parse(Console.ReadLine());

Console.WriteLine("Informe o terceiro numero:");
numero3 = int.Parse(Console.ReadLine());

if (numero1 > numero2 && numero1 > numero3)
{
    Console.WriteLine("O primeiro número: " + numero1 + " tem o maior valor");
}
else if (numero2 > numero1 && numero2 > numero3)
{
    Console.WriteLine("O segundo número: " + numero2 + " tem o maior valor");
}
else
{
    Console.WriteLine("O terceiro número: " + numero3 + " tem o maior valor");
}

