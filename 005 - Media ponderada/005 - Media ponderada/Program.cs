// See https://aka.ms/new-console-template for more information

/*******************************************************************************************
* 05) Faça um algoritmo que leia as 3 notas de um aluno e calcule a média final deste aluno. 
* Considerar que a média é ponderada e que o peso das notas é: 2,3 e 5, respectivamente.
*******************************************************************************************/

float nota1, nota2, nota3, mediaPonderada;

Console.WriteLine("Digite a primeira nota do aluno");
nota1 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a segunda nota do aluno");
nota2 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a terceira nota do aluno");
nota3 = float.Parse(Console.ReadLine());

mediaPonderada = ((2 * nota1) + (3 * nota2) + (5 * nota3))/10; // Media ponderada peso 2, 3 e 5 e dividido por 10 pois 2 + 3 + 5 = 10.

Console.WriteLine("A media poderada do aluno é: " +mediaPonderada);




