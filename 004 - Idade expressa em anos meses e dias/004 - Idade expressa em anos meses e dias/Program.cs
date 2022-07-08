// See https://aka.ms/new-console-template for more information

/* 04.Faça um algoritmo que leia a idade de uma pessoa expressa em dias e mostre-a expressa em anos, meses e dias.*/

float diasVida, idade, meses, dias; //, mes, anoNascimento, anoAtual, idade = 0, quatidadeDias;

Console.WriteLine("Quantos dias de vida você tem?");
diasVida = float.Parse(Console.ReadLine());

idade = diasVida / 365;
meses = (365 * idade) % 12;
//dias = (

//mes = idade % 12;
Console.WriteLine("Você tem : "+idade+" anos "+meses+" meses ");



//mes = 



