// See https://aka.ms/new-console-template for more information

/************************************************************************************************
18. Um banco concederá um crédito especial aos seus clientes, variável com o saldo médio no 
último ano. Faça um algoritmo que leia o saldo médio de um cliente e calcule o valor do crédito 
de acordo com a tabela abaixo. Mostre uma mensagem informando o saldo médio e o valor do crédito. 
(use o comando caso-de e não faça repetições) 


Saldo médio	                Percentual

de 0 a 200	      =>        nenhum crédito
de 201 a 400	  =>        20% do valor do saldo médio
de 401 a 600	  =>        30% do valor do saldo médio
acima de 601	  =>        40% do valor do saldo médio
************************************************************************************************/


Console.WriteLine("    +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
Console.WriteLine("    +                Crédito especial ao cliente                +");
Console.WriteLine("    +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
Console.WriteLine("    +   Saldo médio                       Percentual            +");
Console.WriteLine("    +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
Console.WriteLine("    + de 0 a 200       =>       Cliente não possui crédito      +");
Console.WriteLine("    +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
Console.WriteLine("    + de 201 a 400     =>       20% do valor do saldo médio     +");
Console.WriteLine("    +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
Console.WriteLine("    + de 401 a 600     =>       30% do valor do saldo médio     +");
Console.WriteLine("    +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
Console.WriteLine("    + acima de 601     =>       40% do valor do saldo médio     +");
Console.WriteLine("    +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
Console.WriteLine("                                                                 ");
Console.WriteLine("    +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
Console.WriteLine("    +  Conforme a tabela acima infome o saldo médio do cliente: +");
Console.WriteLine("    +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

float saldo, credito = 0;
saldo = float.Parse(Console.ReadLine());


if (saldo >= 0 && saldo <= 200)
{
    Console.WriteLine("O cliente não possui crédito");
}
else if (saldo > 200 && saldo <= 400)
{
    credito = (saldo * 20) / 100;
    Console.WriteLine("O saldo médio do cliente é: " + saldo + " e o valor do crédito é: " + credito);
}
else if (saldo > 400 && saldo <= 600)
{
    credito = (saldo * 30) / 100;
    Console.WriteLine("O saldo médio do cliente é: " + saldo + " e o valor do crédito é: " + credito);
}
else
{
    credito = (saldo * 40) / 100;
    Console.WriteLine("O saldo médio do cliente é: " + saldo + " e o valor do crédito é: " + credito);
}






