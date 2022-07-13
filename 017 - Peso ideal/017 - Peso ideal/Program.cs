// See https://aka.ms/new-console-template for more information

/************************************************************************************************
17. Tendo como dados de entrada a altura e o sexo de uma pessoa (?M? masculino e ?F? feminino), 
construa um algoritmo que calcule seu peso ideal, utilizando as seguintes fórmulas:

Para homens: (72.7*h) - 58

Para mulheres: (62.1*h) - 44.7

************************************************************************************************/

char sexo;
float peso = 0, altura, imc=0;

Console.WriteLine("Informe sua altura (Ex.: 1.75):");
altura = float.Parse(Console.ReadLine());

Console.WriteLine("Digite seu sexo: M para Masculino ou F para feminino");
sexo = char.Parse(Console.ReadLine());


if (sexo == 'M')
{
    imc = (float)((72.7 * altura) - 58);
    Console.WriteLine("Seu imc é:" +imc);
}
else
{
    imc = (float)((62.1 * altura) - 44.7);
    Console.WriteLine("Seu imc é:" + imc);
}


