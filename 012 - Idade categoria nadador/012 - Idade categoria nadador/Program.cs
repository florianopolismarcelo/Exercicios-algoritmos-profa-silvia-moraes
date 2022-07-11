// See https://aka.ms/new-console-template for more information

/****************************************************************************************************
12. Elabore um algoritmo que dada a idade de um nadador classifica-o em uma das seguintes categorias:

Infantil A = 5 - 7 anos

Infantil B = 8 - 10 anos

Juvenil  A = 11 - 13 anos

Juvenil  B = 14 - 17 anos

Adulto = maiores de 18 anos

****************************************************************************************************/

int idade;

Console.WriteLine("Informe a idade do nadador");
idade = int.Parse(Console.ReadLine());


if (idade >= 5 && idade <= 7)
{
    Console.WriteLine("Categoria infantil A");
}
else if (idade >= 8 && idade <= 10)
{
    Console.WriteLine("Categoria infantil B");
}
else if (idade >= 11 && idade <= 13)
{
    Console.WriteLine("Categoria juvenil A");
}
else if (idade >= 14 && idade <= 17)
{
    Console.WriteLine("Categoria juvenil B");
}
else
{
    Console.WriteLine("Categoria adulto");
}
