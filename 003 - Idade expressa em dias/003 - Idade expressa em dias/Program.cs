// See https://aka.ms/new-console-template for more information

/* 03.Faça um algoritmo que leia a idade de uma pessoa expressa em anos, meses e dias e mostre-a expressa apenas em dias.*/
int dia, mes, anoNascimento, anoAtual, idade =0, quatidadeDias;

Console.WriteLine("Informe seu ano de nascimento");
anoNascimento = int.Parse(Console.ReadLine());

Console.WriteLine("Informe o dia que você nasceu");
dia = int.Parse(Console.ReadLine());

Console.WriteLine("Informe o mês que você nasceu");
mes = int.Parse(Console.ReadLine());

Console.WriteLine("Informe o ano atual");
anoAtual = int.Parse(Console.ReadLine());


idade = anoAtual - anoNascimento;

quatidadeDias = (365 * idade) - 365; 
mes = (30 * mes) - 30;
quatidadeDias = quatidadeDias + mes + dia;

Console.WriteLine("Quantidade de dias de vida " +quatidadeDias);





//  16060 + 180 + 17



