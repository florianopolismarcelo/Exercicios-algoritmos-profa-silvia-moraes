// See https://aka.ms/new-console-template for more information

/**************************************************************************************************************
25. Escrever um algoritmo que lê um conjunto de 4 valores i, a, b, c, onde i é um valor inteiro e positivo 
e a, b, c, são quaisquer valores reais e os escreva. A seguir: 

a) Se i=1 escrever os três valores a, b, c em ordem crescente.
b) Se i=2 escrever os três valores a, b, c em ordem decrescente.
c) Se i=3 escrever os três valores a, b, c de forma que o maior entre a, b, c fique dentre os dois.
**************************************************************************************************************/

float a, b, c;

Console.WriteLine("+-------------------------------------------------+");
Console.WriteLine("Digite valor de [a] qualquer valor de número real: ");
Console.WriteLine("+-------------------------------------------------+");
a = float.Parse(Console.ReadLine());

Console.WriteLine("+-------------------------------------------------+");
Console.WriteLine("Digite valor de [a] qualquer valor de número real: ");
Console.WriteLine("+-------------------------------------------------+");
a = float.Parse(Console.ReadLine());

Console.WriteLine("+-------------------------------------------------+");
Console.WriteLine("Digite valor de [a] qualquer valor de número real: ");
Console.WriteLine("+-------------------------------------------------+");
a = float.Parse(Console.ReadLine());

Console.WriteLine("+-------------------------------------------------------------------+");
Console.WriteLine("+   Digite [1] para ver o valor de a, b, c em ordem crescente.      +");
Console.WriteLine("+                                                                   +");
Console.WriteLine("+   Digite [2] para ver o valor de a, b, c em ordem decrescente.    +");
Console.WriteLine("+                                                                   +");
Console.WriteLine("+   Digite [3] para que o maior entre a, b, c fique dentre os dois. +");
Console.WriteLine("+-------------------------------------------------------------------+");
int i = int.Parse(Console.ReadLine());



