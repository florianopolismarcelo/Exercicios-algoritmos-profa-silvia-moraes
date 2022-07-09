// See https://aka.ms/new-console-template for more information

/****************************************************************************************
* 02) Escreva um algoritmo que leia três números inteiros e positivos (A, B, C) e calcule 
* a seguinte expressão:  D = R + S/2 onde R = (A + B) ^2  e  S (B + C) ^2 
****************************************************************************************/

int numero01, numero02, numero03;
float D, R, S;

Console.WriteLine("Digite o primeiro numero");
numero01 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo numero");
numero02 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o terceiro numero");
numero03 = int.Parse(Console.ReadLine());


R = numero01 + numero02;
S = numero02 + numero03;

R = (float)Math.Sqrt(2);
S = (float)Math.Sqrt(2);

D = (R + S) / 2;

Console.WriteLine("O calculo da expressão é: " + D);