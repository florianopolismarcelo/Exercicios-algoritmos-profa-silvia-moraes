// See https://aka.ms/new-console-template for more information

/************************************************************************************************
14. Escreva um algoritmo que leia o código de um aluno e suas três notas. Calcule a média 
ponderada do aluno, considerando que o peso para a maior nota seja 4 e para as duas restantes 3. 
Mostre o código do aluno, suas três notas, a média calculada e uma mensagem "APROVADO" se a média 
for maior ou igual a 5 e "REPROVADO" se a média for menor que 5.
************************************************************************************************/

float nota1, nota2, nota3, mediaPonderada;
string codigoAluno;

Console.WriteLine("Digite o código do aluno:");
codigoAluno = Console.ReadLine();

Console.WriteLine("Digite a primeira nota do aluno");
nota1 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a segunda nota do aluno");
nota2 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a terceira nota do aluno");
nota3 = float.Parse(Console.ReadLine());

if (nota1 > nota2 && nota1 > nota3)
{
    mediaPonderada = ((4 * nota1) + (3 * nota2) + (3 * nota3)) / 10;
    if (mediaPonderada >= 5)
    {
        Console.WriteLine("O código do aluno é: " + codigoAluno);
        Console.WriteLine("Primeira nota: " + nota1 + " Segunda nota: " + nota2 + " Terceira nota: " + nota3);
        Console.WriteLine("Media = " + mediaPonderada + " Aluno Aprovado!!!");
    }
    else
    {
        Console.WriteLine("O código do aluno é: " + codigoAluno);
        Console.WriteLine("Primeira nota: " + nota1 + " Segunda nota: " + nota2 + " Terceira nota: " + nota3);
        Console.WriteLine("Media = " + mediaPonderada + " Aluno Reprovado!!!");
    }
}
else if (nota2 > nota1 && nota2 > nota3)
{
    mediaPonderada = ((3 * nota1) + (4 * nota2) + (3 * nota3)) / 10;
    if (mediaPonderada >= 5)
    {
        Console.WriteLine("O código do aluno é: " + codigoAluno);
        Console.WriteLine("Primeira nota: " + nota1 + " Segunda nota: " + nota2 + " Terceira nota: " + nota3);
        Console.WriteLine("Media = " + mediaPonderada + " Aluno Aprovado!!!");
    }
    else
    {
        Console.WriteLine("O código do aluno é: " + codigoAluno);
        Console.WriteLine("Primeira nota: " + nota1 + " Segunda nota: " + nota2 + " Terceira nota: " + nota3);
        Console.WriteLine("Media = " + mediaPonderada + " Aluno Reprovado!!!");
    }
}
else
{
    mediaPonderada = ((3 * nota1) + (3 * nota2) + (4 * nota3)) / 10;
    if (mediaPonderada >= 5)
    {
        Console.WriteLine("O código do aluno é: " + codigoAluno);
        Console.WriteLine("Primeira nota: " + nota1 + " Segunda nota: " + nota2 + " Terceira nota: " + nota3);
        Console.WriteLine("Media = " + mediaPonderada + " Aluno Aprovado!!!");
    }
    else
    {
        Console.WriteLine("O código do aluno é: " + codigoAluno);
        Console.WriteLine("Primeira nota: " + nota1 + " Segunda nota: " + nota2 + " Terceira nota: " + nota3);
        Console.WriteLine("Media = " + mediaPonderada + " Aluno Reprovado!!!");
    }
}