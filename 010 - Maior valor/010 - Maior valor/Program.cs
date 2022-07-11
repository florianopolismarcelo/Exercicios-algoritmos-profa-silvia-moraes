// See https://aka.ms/new-console-template for more information

/*******************************************************************************************
Elaborar um algoritmo que lê 3 valores a,b,c e os escreve. A seguir, encontre o maior dos 3 
valores e o escreva com a mensagem : "É o maior ".
*******************************************************************************************/

float numero1, numero2, numero3;

Console.WriteLine("Informe o valor de A:");
numero1 = float.Parse(Console.ReadLine());

Console.WriteLine("Informe o valor de B:");
numero2 = float.Parse(Console.ReadLine());

Console.WriteLine("Informe o valor de C:");
numero3 = float.Parse(Console.ReadLine());

if (numero1 > numero2 && numero1 > numero3)
{
    Console.WriteLine("O valor de B é: "+numero2+ " o valor de C é: "+numero3+
    " e o valor de A possui o maior valor que é: "+numero1);
}
else if (numero2 > numero1 && numero2 > numero3)
{
    Console.WriteLine("O valor de A é: " + numero1 + " o valor de C é: " + numero3+
     " e o valor de B possui o maior valor que é: " + numero2);
}
else
{
    Console.WriteLine("O valor de A é: " + numero1 + " o valor de B é: " + numero2+
    " e o valor de C possui o maior valor que é: " + numero3);
}

