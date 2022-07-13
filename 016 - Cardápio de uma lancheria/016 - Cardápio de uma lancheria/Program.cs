// See https://aka.ms/new-console-template for more information


/*********************************************************************************
16. O cardápio de uma lancheria é o seguinte:

Especificação	    Código	   Preço

Cachorro quente	     100	   1,20
Bauru simples	     101	   1,30
Bauru com ovo	     102	   1,50
Hambúrger	     103	      1,20
Cheeseburguer	     104	   1,30
Refrigerante	     105	   1,00

Escrever um algoritmo que leia o código do item pedido, a quantidade e calcule 
o valor a ser pago por aquele lanche. Considere que a cada execução somente será 
calculado um item.
********************************************************************************/

int codigo;
double valor = 0, quantidade = 0;

Console.WriteLine("    ++++++++++++++++++++++++++  ");
Console.WriteLine("             cardápio           ");
Console.WriteLine("    ++++++++++++++++++++++++++  ");
Console.WriteLine("      Código         Valor      ");
Console.WriteLine("    ++++++++++++++++++++++++++  ");
Console.WriteLine("      [100]   ==> R$ 1,20       ");
Console.WriteLine("    ++++++++++++++++++++++++++  ");
Console.WriteLine("      [101]   ==> R$ 1,30       ");
Console.WriteLine("    ++++++++++++++++++++++++++  ");
Console.WriteLine("      [102]   ==> R$ 1,50       ");
Console.WriteLine("    ++++++++++++++++++++++++++  ");
Console.WriteLine("      [103]   ==> R$ 1,20       ");
Console.WriteLine("    ++++++++++++++++++++++++++  ");
Console.WriteLine("      [104]   ==> R$ 1,30       ");
Console.WriteLine("    ++++++++++++++++++++++++++  ");
Console.WriteLine("      [105]   ==> R$ 1,00       ");
Console.WriteLine("    ++++++++++++++++++++++++++  ");
Console.WriteLine("    Digite o código do produto  ");
Console.WriteLine("    ++++++++++++++++++++++++++  ");

codigo = int.Parse(Console.ReadLine());
Console.WriteLine("    ++++++++++++++++++++++++++  ");
Console.WriteLine("    Quantos itens você deseja   ");
Console.WriteLine("    ++++++++++++++++++++++++++  ");
quantidade = double.Parse(Console.ReadLine());

switch (codigo)
{
    case 100:

        valor = quantidade * 1.20;

        Console.WriteLine("+--------------------------------------------+");
        Console.WriteLine("O valor a ser pago é: " + valor.ToString("0.00"));
        Console.WriteLine("+--------------------------------------------+");
        break;

    case 101:

        valor = quantidade * 1.30;

        Console.WriteLine("+--------------------------------------------+");
        Console.WriteLine("O valor a ser pago é: " + valor.ToString("0.00"));
        Console.WriteLine("+--------------------------------------------+");
        break;

    case 102:

        valor = quantidade * 1.50;

        Console.WriteLine("+--------------------------------------------+");
        Console.WriteLine("O valor a ser pago é: " + valor.ToString("0.00"));
        Console.WriteLine("+--------------------------------------------+");
        break;

    case 103:

        valor = quantidade * 1.20;

        Console.WriteLine("+--------------------------------------------+");
        Console.WriteLine("O valor a ser pago é: " + valor.ToString("0.00"));
        Console.WriteLine("+--------------------------------------------+");
        break;

    case 104:

        valor = quantidade * 1.30;

        Console.WriteLine("+--------------------------------------------+");
        Console.WriteLine("O valor a ser pago é: " + valor.ToString("0.00"));
        Console.WriteLine("+--------------------------------------------+");
        break;

    case 105:

        valor = quantidade * 1.00;

        Console.WriteLine("+--------------------------------------------+");
        Console.WriteLine("O valor a ser pago é: " + valor.ToString("0.00"));
        Console.WriteLine("+--------------------------------------------+");
        break;
}




