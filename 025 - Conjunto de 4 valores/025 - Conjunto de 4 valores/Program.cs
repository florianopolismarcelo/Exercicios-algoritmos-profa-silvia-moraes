// See https://aka.ms/new-console-template for more information

/**************************************************************************************************************
25. Escrever um algoritmo que lê um conjunto de 4 valores i, a, b, c, onde i é um valor inteiro e positivo 
e a, b, c, são quaisquer valores reais e os escreva. A seguir: 

a) Se i=1 escrever os três valores a, b, c em ordem crescente.
b) Se i=2 escrever os três valores a, b, c em ordem decrescente.
c) Se i=3 escrever os três valores a, b, c de forma que o maior entre a, b, c fique dentre os dois.
**************************************************************************************************************/

float a, b, c;
int ordem = 0;

Console.WriteLine("+---------------------------------------------------+");
Console.WriteLine("Digite o valor de [a] qualquer valor de número real: ");
Console.WriteLine("+---------------------------------------------------+");
a = float.Parse(Console.ReadLine());

Console.WriteLine("+---------------------------------------------------+");
Console.WriteLine("Digite o valor de [b] qualquer valor de número real: ");
Console.WriteLine("+---------------------------------------------------+");
b = float.Parse(Console.ReadLine());

Console.WriteLine("+---------------------------------------------------+");
Console.WriteLine("Digite o valor de [c] qualquer valor de número real: ");
Console.WriteLine("+---------------------------------------------------+");
c = float.Parse(Console.ReadLine());

Console.WriteLine("+-------------------------------------------------------------------+");
Console.WriteLine("+   Digite [1] para ver o valor de a, b, c em ordem crescente.      +");
Console.WriteLine("+                                                                   +");
Console.WriteLine("+   Digite [2] para ver o valor de a, b, c em ordem decrescente.    +");
Console.WriteLine("+                                                                   +");
Console.WriteLine("+   Digite [3] para que o maior entre a, b, c fique dentre os dois. +");
Console.WriteLine("+-------------------------------------------------------------------+");
ordem = int.Parse(Console.ReadLine());

switch (ordem)
{
    case 1:
        if (a < b && a < c && b < c)
        {
            Console.WriteLine(+a + " " + b + " " + c);
        }
        else if (a < b && a < c && c < b)
        {
            Console.WriteLine(+a + " " + c + " " + b);
        }
        else if (b < c && b < a && c < a)
        {
            Console.WriteLine(+b + " " + c + " " + a);
        }
        else if (b < c && b < a && a < c)
        {
            Console.WriteLine(+b + " " + a + " " + c);
        }
        else if (c < a && c < b && a < b)
        {
            Console.WriteLine(+c + " " + a + " " + b);
        }
        else if (c < a && c < b && b < a)
        {
            Console.WriteLine(+c + " " + b + " " + a);
        }
        break;

    case 2:
        if (a < b && a < c && b < c)
        {
            Console.WriteLine(+c + " " + b + " " + a);
        }
        else if (a < b && a < c && c < b)
        {
            Console.WriteLine(+b + " " + c + " " + a);
        }
        else if (b < c && b < a && c < a)
        {
            Console.WriteLine(+a + " " + c + " " + b);
        }
        else if (b < c && b < a && a < c)
        {
            Console.WriteLine(+c + " " + a + " " + b);
        }
        else if (c < a && c < b && a < b)
        {
            Console.WriteLine(+b + " " + a + " " + c);
        }
        else if (c < a && c < b && b < a)
        {
            Console.WriteLine(+a + " " + b + " " + c);
        }
        break;

    case 3:
        if (a > b && a > c)
        {
            Console.WriteLine(+b + " " + a + " " + c);
        }
        else if (b > a && b > c)
        {
            Console.WriteLine(+a + " " + b + " " + c);
        }
        else //if (c > a && c > b )
        {
            Console.WriteLine(+b + " " + c + " " + a);
        }
        break;
}
