// See https://aka.ms/new-console-template for more information

/******************************************************************************************
Calcule a média aritmética das 3 notas de um aluno e mostre, além do valor da média, uma 
mensagem de "Aprovado", caso a média seja igual ou superior a 6, ou a mensagem "reprovado"
caso contrário.
******************************************************************************************/

float nota1, nota2, nota3, media;

Console.WriteLine("Informa a primeira nota do aluno:");
nota1 = float.Parse(Console.ReadLine());

Console.WriteLine("Informa a segunda nota do aluno:");
nota2 = float.Parse(Console.ReadLine());

Console.WriteLine("Informa a terceira nota do aluno:");
nota3 = float.Parse(Console.ReadLine());

media = (nota1 + nota2 + nota3)/3;

if (media >= 6)
{
    Console.WriteLine("Média: " + media.ToString("0.0") + " Aluno Aprovado");
}
else if (media < 6)
{
    Console.WriteLine("Média: " + media.ToString("0.0") + " Aluno Reprovado");
}