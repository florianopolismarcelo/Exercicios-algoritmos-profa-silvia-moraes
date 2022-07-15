// See https://aka.ms/new-console-template for more information

/*****************************************************************************************************
21. Um vendedor precisa de um algoritmo que calcule o preço total devido por um cliente. O algoritmo 
deve receber o código de um produto e a quantidade comprada e calcular o preço total, usando a tabela 
abaixo. Mostre uma mensagem no caso de código inválido.

Código             	Preço unitário
'ABCD'	              R$ 5,30
'XYPK'	              R$ 6,00
'KLMP'	              R$ 3,20
'QRST'	              R$ 2,50
*****************************************************************************************************/

string codigo;
double valor = 0, quantidade = 0;

Console.WriteLine("    +++++++++++++++++++++++++++++++++++++++++++++++++++++  ");
Console.WriteLine("    + Digite o código do produto consumido pelo cliente +  ");
Console.WriteLine("    +++++++++++++++++++++++++++++++++++++++++++++++++++++  ");
Console.WriteLine("    +              Código              Valor            +  ");
Console.WriteLine("    +++++++++++++++++++++++++++++++++++++++++++++++++++++  ");
Console.WriteLine("    +              ['ABCD']      ==>    R$ 5,30        +  ");
Console.WriteLine("    +++++++++++++++++++++++++++++++++++++++++++++++++++++  ");
Console.WriteLine("    +              ['XYPK']      ==>    R$ 6,00         +  ");
Console.WriteLine("    +++++++++++++++++++++++++++++++++++++++++++++++++++++  ");
Console.WriteLine("    +              ['KLMP']      ==>    R$ 3,20         +  ");
Console.WriteLine("    +++++++++++++++++++++++++++++++++++++++++++++++++++++  ");
Console.WriteLine("    +              ['QRST']      ==>    R$ 2,50         +  ");
Console.WriteLine("    +++++++++++++++++++++++++++++++++++++++++++++++++++++  ");
codigo = (Console.ReadLine());

if (codigo != "ABCD" && codigo != "XYPK" && codigo != "KLMP" && codigo != "QRST")
{
    Console.WriteLine("+--------------------------------------------------------------------+");
    Console.WriteLine("+ Código inválido!!! Favor digitar o código correto da tabela acima. +");
    Console.WriteLine("+--------------------------------------------------------------------+");
}
else
{
    Console.Write("Digite a quantidade: ");
    quantidade = double.Parse(Console.ReadLine());
}

switch (codigo)
{
    case "ABCD":

        valor = quantidade * 5.30;
        Console.WriteLine("+---------------------------+");
        Console.WriteLine("O valor a ser pago é: " + valor.ToString("0.00"));
        Console.WriteLine("+---------------------------+");
        break;

    case "XYPK":

        valor = quantidade * 6.00;
        Console.WriteLine("+---------------------------+");
        Console.WriteLine("O valor a ser pago é: " + valor.ToString("0.00"));
        Console.WriteLine("+---------------------------+");
        break;

    case "KLMP":

        valor = quantidade * 3.20;
        Console.WriteLine("+---------------------------+");
        Console.WriteLine("O valor a ser pago é: " + valor.ToString("0.00"));
        Console.WriteLine("+---------------------------+");
        break;

    case "QRST":

        valor = quantidade * 2.50;
        Console.WriteLine("+---------------------------+");
        Console.WriteLine("O valor a ser pago é: " + valor.ToString("0.00"));
        Console.WriteLine("+---------------------------+");
        break;
}

