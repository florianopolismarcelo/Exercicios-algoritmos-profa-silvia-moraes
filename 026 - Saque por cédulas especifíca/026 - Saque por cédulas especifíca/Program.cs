// See https://aka.ms/new-console-template for more information

/******************************************************************************************************
26) Escrever um algoritmo que lê um valor em reais e calcula qual o menor número possível de notas de 
100, 50, 10, 5 e 1 em que o valor lido pode ser decomposto. Escrever o valor lido e a relação de notas 
necessárias.
*******************************************************************************************************/

int valor, nota100, nota50, nota10, nota5, nota1, resto100, resto50, resto10, resto5, resto1;

Console.WriteLine("+-----------------------------------+");
Console.WriteLine("+ Digite um valor para saque R$$$ ? +");
Console.WriteLine("+-----------------------------------+");
Console.WriteLine("");
valor = int.Parse(Console.ReadLine());


nota100 = (valor / 100);
resto100 = (valor % 100);

nota50 = (resto100 / 50);
resto50 = (resto100 % 50);

nota10 = (resto50 / 10);
resto10 = (resto50 % 10);

nota5 = (resto10 / 5);
resto5 = (resto10 % 5);

nota1 = (resto5 / 1);
resto1 = (resto5 % 1);

Console.WriteLine("");
Console.WriteLine("+--------------------------------------------+");
Console.WriteLine("+ Quantidade de cédulas de R$ 100 reais: " + nota100);
Console.WriteLine("+--------------------------------------------+");
Console.WriteLine("+ Quantidade de cédulas de R$ 50 reais: " + nota50);
Console.WriteLine("+--------------------------------------------+");
Console.WriteLine("+ Quantidade de cédulas de R$ 10 reais: " + nota10);
Console.WriteLine("+--------------------------------------------+");
Console.WriteLine("+ Quantidade de cédulas de R$ 5 reais: " + nota5);
Console.WriteLine("+--------------------------------------------+");
Console.WriteLine("+ Quantidade de cédulas de R$ 1 reais: " + nota1);
Console.WriteLine("+--------------------------------------------+");
