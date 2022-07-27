// See https://aka.ms/new-console-template for more information

/******************************************************************************
27) Escrever um algoritmo que lê:

- a percentagem do IPI a ser acrescido no valor das peças
- o código da peça 1, valor unitário da peça 1, quantidade de peças 1
- o código da peça 2, valor unitário da peça 2, quantidade de peças 2

O algoritmo deve calcular o valor total a ser pago e apresentar o resultado.

Fórmula : (valor1*quant1 + valor2*quant2)*(IPI/100 + 1)
******************************************************************************/

int percentagemIPI, quantidadePeca1, quantidadePeca2, valorPeca1, valorPeca2, valorTotal;
string codigoPeca1, codigoPeca2;


Console.WriteLine("    ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
Console.WriteLine("    +                                                                      +");
Console.WriteLine("    +                                                                      +");
Console.WriteLine("    +     Percentagem do IPI a ser acrescido no valor total das peças      +");
Console.WriteLine("    +                                                                      +");
Console.WriteLine("    +                                                                      +");
Console.WriteLine("    ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
Console.WriteLine("");


Console.WriteLine("+----------------------------------------------------------------+");
Console.WriteLine("+ Digite a percentagem do IPI a ser acrescido no valor das peças +");
Console.WriteLine("+----------------------------------------------------------------+");
percentagemIPI = int.Parse(Console.ReadLine());

Console.WriteLine("+-----------------------------+");
Console.WriteLine("+ Digite o código da peça [1] +");
Console.WriteLine("+-----------------------------+");
codigoPeca1 = Console.ReadLine();

Console.WriteLine("+-------------------------------------------------+");
Console.WriteLine("+ Digite a quantidade da peça [1] que você deseja +");
Console.WriteLine("+-------------------------------------------------+");
quantidadePeca1 = int.Parse(Console.ReadLine());

Console.WriteLine("+-------------------------------------+");
Console.WriteLine("+ Digite o valor unitário da peça [1] +");
Console.WriteLine("+-------------------------------------+");
valorPeca1 = int.Parse(Console.ReadLine());

Console.WriteLine("+-----------------------------+");
Console.WriteLine("+ Digite o código da peça [2] +");
Console.WriteLine("+-----------------------------+");
codigoPeca2 = Console.ReadLine();

Console.WriteLine("+-------------------------------------------------+");
Console.WriteLine("+ Digite a quantidade da peça [2] que você deseja +");
Console.WriteLine("+-------------------------------------------------+");
quantidadePeca2 = int.Parse(Console.ReadLine());

Console.WriteLine("+-------------------------------------+");
Console.WriteLine("+ Digite o valor unitário da peça [2] +");
Console.WriteLine("+-------------------------------------+");
valorPeca2 = int.Parse(Console.ReadLine());

valorPeca1 = valorPeca1 * quantidadePeca1;
valorPeca2 = valorPeca2 * quantidadePeca2;

percentagemIPI = ((valorPeca1 + valorPeca2) * percentagemIPI) / 100 + 1;

valorTotal = valorPeca1 + valorPeca2 + percentagemIPI;
Console.WriteLine("");
Console.WriteLine("O valor total a ser pago da peça [1]: " + codigoPeca1 + " e peça [2]: " + codigoPeca2 + " é de R$" + valorTotal);



