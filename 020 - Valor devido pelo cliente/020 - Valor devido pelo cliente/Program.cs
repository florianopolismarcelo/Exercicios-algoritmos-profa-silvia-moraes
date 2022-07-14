// See https://aka.ms/new-console-template for more information

/************************************************************************************************
20) Um vendedor necessita de um algoritmo que calcule o preço total devido por um cliente. 
O algoritmo deve receber o código de um produto e a quantidade comprada e calcular o preço total, 
usando a tabela abaixo:

Código do Produto	      Preço unitário

1001	                      5,32
1324	                      6,45
6548	                      2,37
0987	                      5,32
7623	                      6,45
************************************************************************************************/

int codigo;
double valor = 0, quantidade = 0;

Console.WriteLine("    +++++++++++++++++++++++++++++++++++++++++++++++++++++  ");
Console.WriteLine("    + Digite o código do produto consumido pelo cliente +  ");
Console.WriteLine("    +++++++++++++++++++++++++++++++++++++++++++++++++++++  ");
Console.WriteLine("    +              Código              Valor            +  ");
Console.WriteLine("    +++++++++++++++++++++++++++++++++++++++++++++++++++++  ");
Console.WriteLine("    +              [1001]      ==>    R$ 5,32           +  ");
Console.WriteLine("    +++++++++++++++++++++++++++++++++++++++++++++++++++++  ");
Console.WriteLine("    +              [1324]      ==>    R$ 6,45           +  ");
Console.WriteLine("    +++++++++++++++++++++++++++++++++++++++++++++++++++++  ");
Console.WriteLine("    +              [6548]      ==>    R$ 2,37           +  ");
Console.WriteLine("    +++++++++++++++++++++++++++++++++++++++++++++++++++++  ");
Console.WriteLine("    +              [0987]      ==>    R$ 5,32           +  ");
Console.WriteLine("    +++++++++++++++++++++++++++++++++++++++++++++++++++++  ");
Console.WriteLine("    +              [7623]      ==>    R$ 6,45           +  ");
Console.WriteLine("    +++++++++++++++++++++++++++++++++++++++++++++++++++++  ");

codigo = int.Parse(Console.ReadLine());

Console.Write("Digite a quantidade: ");

quantidade = double.Parse(Console.ReadLine());

switch (codigo)
{
    case 1001:

        valor = quantidade * 5.32;
        Console.WriteLine("+---------------------------+");
        Console.WriteLine("O valor a ser pago é: " + valor.ToString("0.00"));
        Console.WriteLine("+---------------------------+");
        break;

    case 1324:

        valor = quantidade * 6.45;
        Console.WriteLine("+---------------------------+");
        Console.WriteLine("O valor a ser pago é: " + valor.ToString("0.00"));
        Console.WriteLine("+---------------------------+");
        break;

    case 6548:

        valor = quantidade * 2.37;
        Console.WriteLine("+---------------------------+");
        Console.WriteLine("O valor a ser pago é: " + valor.ToString("0.00"));
        Console.WriteLine("+---------------------------+");
        break;

    case 0987:

        valor = quantidade * 5.32;
        Console.WriteLine("+---------------------------+");
        Console.WriteLine("O valor a ser pago é: " + valor.ToString("0.00"));
        Console.WriteLine("+---------------------------+");
        break;

    case 7623:

        valor = quantidade * 6.45;
        Console.WriteLine("+---------------------------+");
        Console.WriteLine("O valor a ser pago é: " + valor.ToString("0.00"));
        Console.WriteLine("+---------------------------+");
        break;
}

