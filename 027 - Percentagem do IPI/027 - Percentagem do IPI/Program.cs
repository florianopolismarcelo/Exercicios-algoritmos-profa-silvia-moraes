﻿// See https://aka.ms/new-console-template for more information

/******************************************************************************
27) Escrever um algoritmo que lê:

- a percentagem do IPI a ser acrescido no valor das peças
- o código da peça 1, valor unitário da peça 1, quantidade de peças 1
- o código da peça 2, valor unitário da peça 2, quantidade de peças 2

O algoritmo deve calcular o valor total a ser pago e apresentar o resultado.

Fórmula : (valor1*quant1 + valor2*quant2)*(IPI/100 + 1)
******************************************************************************/

int codig;
double salario = 0, novoSalario = 0;

Console.WriteLine("    ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
Console.WriteLine("    +        Percentagem do IPI a ser acrescido no valor das peças         +");
Console.WriteLine("    ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
Console.WriteLine("    +              Código                                                  +");
Console.WriteLine("    ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
Console.WriteLine("    +              [1]                                                     +");
Console.WriteLine("    ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
Console.WriteLine("    +              [2]                                                     +");
Console.WriteLine("    ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
