// See https://aka.ms/new-console-template for more information

/*************************************************************************************************************
23) Elaborar um algoritmo que lê 3 valores a,b,c e verifica se eles formam ou não um triângulo. Supor 
que os valores lidos são inteiros e positivos. Caso os valores formem um triângulo, calcular e escrever 
a área deste triângulo. Se não formam triângulo escrever os valores lidos. ( se a > b + c não formam triângulo 
algum, se a é o maior).
*************************************************************************************************************/

float lado1, lado2, lado3,p, area = 0;


Console.WriteLine("+--------------------+");
Console.WriteLine("DIGITE O PRIMEIRO LADO");
Console.WriteLine("+--------------------+");
lado1 = float.Parse(Console.ReadLine());

Console.WriteLine("+-------------------+");
Console.WriteLine("DIGITE O SEGUNDO LADO");
Console.WriteLine("+-------------------+");
lado2 = float.Parse(Console.ReadLine());

Console.WriteLine("+--------------------+");
Console.WriteLine("DIGITE O TERCEIRO LADO");
Console.WriteLine("+--------------------+");
lado3 = float.Parse(Console.ReadLine());

// ABAIXO É CONDICAO LOGICA PARA VERIFICAR SE NÃO É UM TRIANGULO:
if (lado1 > lado2 + lado3 || lado2 > lado1 + lado3 || lado3 > lado1 + lado2)
{
    Console.WriteLine("+----------------------------------------------------------------------+");
    Console.WriteLine("Valor de A: " + lado1 + " Valor de B: " + lado2 + " Valor de C: " + lado3);
    Console.WriteLine("                                                                        ");
    Console.WriteLine("                     Não forma um triangulo                             ");
    Console.WriteLine("+----------------------------------------------------------------------+");
}
else
{
    p = (lado1 + lado2 + lado3) / 2;
    area = p * (p - lado1) * (p - lado2) * (p - lado3);

    Console.WriteLine("+----------------------------------------------------------+");
    Console.WriteLine(" Forma um triangulo e o valor da área do triangulo é: " +Math.Sqrt(area));
    Console.WriteLine("+----------------------------------------------------------+");
}