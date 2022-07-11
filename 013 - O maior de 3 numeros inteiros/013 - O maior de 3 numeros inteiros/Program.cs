// See https://aka.ms/new-console-template for more information

/***************************************************************************
13) Escreva um algoritmo que leia 3 números inteiros e mostre o maior deles.
****************************************************************************/

int numero1, numero2, numero3;

Console.WriteLine("Informe o primeiro número inteiro:");
numero1 = int.Parse(Console.ReadLine());

Console.WriteLine("Informe o segundo número inteiro:");
numero2 = int.Parse(Console.ReadLine());

Console.WriteLine("Informe o terceiro número inteiro:");
numero3 = int.Parse(Console.ReadLine());

if (numero1 > numero2 && numero1 > numero3)
{
    Console.WriteLine(numero1 + " é o primeiro número inteiro digitado e tem o maior valor.");
}
else if (numero2 > numero1 && numero2 > numero3)
{
    Console.WriteLine(numero2 + " é o segundo número inteiro digitado e tem o maior valor.");
}
else
{
    Console.WriteLine(numero3 + " é o terceiro número inteiro digitado e tem o maior valor.");
}

