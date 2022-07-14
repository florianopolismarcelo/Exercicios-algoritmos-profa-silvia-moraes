// See https://aka.ms/new-console-template for more information

/****************************************************************************************
19. Um usuário deseja um algoritmo onde possa escolher que tipo de média deseja calcular 
a partir de 3 notas. Faça um algoritmo que leia as notas, a opção escolhida pelo usuário 
e calcule a média.

1 - aritmética
2 - ponderada (3,3,4)
3 - harmônica
****************************************************************************************/

float nota1, nota2, nota3, media;
int codigo = 0;

Console.WriteLine("+------------------------------+");
Console.WriteLine("INFORME A PRIMEIRA NOTA DO ALUNO");
Console.WriteLine("+------------------------------+");
nota1 = float.Parse(Console.ReadLine());

Console.WriteLine("+------------------------------+");
Console.WriteLine("INFORME A SEGUNDA NOTA DO ALUNO5");
Console.WriteLine("+------------------------------+");
nota2 = float.Parse(Console.ReadLine());

Console.WriteLine("+------------------------------+");
Console.WriteLine("INFORME A SEGUNDA NOTA DO ALUNO5");
Console.WriteLine("+------------------------------+");
nota3 = float.Parse(Console.ReadLine());

Console.WriteLine("    ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
Console.WriteLine("    + Agora digite a opção abaixo para média que deseja calcular +");
Console.WriteLine("    ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
Console.WriteLine("    +                                                            +");
Console.WriteLine("    ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
Console.WriteLine("    +  Digite [1] para calcular a média aritmética               +");
Console.WriteLine("    ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
Console.WriteLine("    +  Digite [2] para calcular a média ponderada peso (3,3,4)   +");
Console.WriteLine("    ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
Console.WriteLine("    +  Digite [3] para calcular a média harmônica                +");
Console.WriteLine("    ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

codigo = int.Parse(Console.ReadLine());

switch (codigo)
{
    case 1:
        media = (nota1 + nota2 + nota3) / 3;
        Console.WriteLine("+----------------------------------+");
        Console.WriteLine("A média aritmética do aluno é: " + media.ToString("0.0"));
        Console.WriteLine("+----------------------------------+");
        break;

    case 2:
        media = ((nota1 * 3) + (nota2 * 3) + (nota3 * 4)) / 10;
        Console.WriteLine("+---------------------------------+");
        Console.WriteLine("A média ponderada do aluno é: " + media.ToString("0.0"));
        Console.WriteLine("+---------------------------------+");
        break;

    case 3:
        media =  3 /(1 / nota1 + 1 / nota2 + 1 / nota3);
        Console.WriteLine("+----------------------------------+");
        Console.WriteLine("A média harmônica do aluno é: " + media.ToString("0.0"));
        Console.WriteLine("+----------------------------------+");
        break;
}




