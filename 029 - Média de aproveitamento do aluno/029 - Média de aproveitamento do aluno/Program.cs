// See https://aka.ms/new-console-template for more information

/****************************************************************************************************************
29. Escrever um algoritmo que lê o número de identificação, as 3 notas obtidas por um aluno nas 
3 verificações e a média dos exercícios que fazem parte da avaliação. Calcular a média de aproveitamento, 
usando a fórmula:

MA = (Nota1 + Nota2 x 2 + Nota3 x 3 + ME )/7

mediaAproveitamento = (nota1 + (nota2 * 2) + (nota3 * 3) + mediaExercicios) / 7;

A atribuição de conceitos obedece a tabela abaixo:

******************************************
*  Média de Aproveitamento  *  Conceito  *
******************************************
*                           *            *
*         9,0	            *     A      *
*---------------------------*------------*
*      7,5 e < 9,0	        *     B      *    
*---------------------------*------------*
*      6,0 e < 7,5	        *     C      *
----------------------------*------------*
*      4,0 e < 6,0	        *     D      *
*---------------------------*------------*
*       < 4,0	            *     E      *
*---------------------------*------------*

O algoritmo deve escrever o número do aluno, suas notas, a média dos exercícios, a média de aproveitamento, 
o conceito correspondente e a mensagem: APROVADO se o conceito for A,B ou C e REPROVADO se o conceito for D ou E.
******************************************************************************************************************/

float nota1, nota2, nota3, mediaExercicios, mediaAproveitamento;
String codigo;


Console.WriteLine("Digite o código do aluno");
codigo = Console.ReadLine();

Console.WriteLine("Digite a primeira nota do aluno");
nota1 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a segunda nota do aluno");
nota2 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a terceira nota do aluno");
nota3 = float.Parse(Console.ReadLine());


mediaExercicios = (nota1 + nota2 + nota3) / 3;

mediaAproveitamento = (nota1 + (nota2 * 2) + (nota3 * 3) + mediaExercicios) / 7;


if (mediaExercicios >= 9)
{
    Console.WriteLine("Código do Aluno:[" + codigo + "] Nota de aproveitamento [" + mediaAproveitamento + "] Conceito [A] ALUNO APROVADO!");
}
if (mediaExercicios >= 7.5 && mediaExercicios < 9)
{
    Console.WriteLine("Código do Aluno:[" + codigo + "] Nota de aproveitamento [" + mediaAproveitamento + "] Conceito [B] ALUNO APROVADO!");
}
if (mediaExercicios > 6 && mediaExercicios < 7.5)
{
    Console.WriteLine("Código do Aluno:[" + codigo + "] Nota de aproveitamento [" + mediaAproveitamento + "] Conceito [C] ALUNO APROVADO!");
}
if (mediaExercicios >= 4.0 && mediaExercicios < 6)
{
    Console.WriteLine("Código do Aluno:[" + codigo + "] Nota de aproveitamento [" + mediaAproveitamento + "] Conceito [D] ALUNO APROVADO!");
}
else
{
    Console.WriteLine("Código do Aluno:[" + codigo + "] Nota de aproveitamento [" + mediaAproveitamento + "] Conceito [E] ALUNO APROVADO!");
}

