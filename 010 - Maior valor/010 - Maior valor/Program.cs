// See https://aka.ms/new-console-template for more information

/*******************************************************************************************
Elaborar um algoritmo que lê 3 valores a,b,c e os escreve. A seguir, encontre o maior dos 3 
valores e o escreva com a mensagem : "É o maior ".
*******************************************************************************************/

float numero1, numero2, numero3, maiorValor;

Console.WriteLine("Informe o primeiro numero:");
numero1 = float.Parse(Console.ReadLine());

Console.WriteLine("Informe o segundo numero:");
numero2 = float.Parse(Console.ReadLine());

Console.WriteLine("Informe o terceiro numero:");
numero3 = float.Parse(Console.ReadLine());

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

