// See https://aka.ms/new-console-template for more information

/***********************************************************************************************
31) Escrever um algoritmo que calcule os sucessivos valores de E usando a série abaixo 
e considerando primeiro 3 termos, depois 4 termos e, por fim, 5 termos:  

E = E = 1 + 1 / 1! + 1 / 2! + 1 / 3! + 1 / 4!


1! = 1
2! = 2
3! = 6
4! = 24
5! = 120
6! = 720
Mais informações sobre o número de Euler:
http://pt.wikipedia.org/wiki/N%C3%BAmero_de_Euler
Valor aproximado: 2,71828182845904523530287
***********************************************************************************************/

double e;

e = 1.0 + 1.0 + (1.0 / 2.0); //três termos
Console.WriteLine("+--------------------------------------+");
Console.WriteLine("e com tres termos:" +e);
Console.WriteLine("+--------------------------------------+");

e = e + (1.0 / 6.0); //quatro termos

Console.WriteLine("e com quatro termos:" + e);
Console.WriteLine("+--------------------------------------+");

e = e + (1.0 / 24.0); //cinco termos
Console.WriteLine("e com cinco termos:" + e);
Console.WriteLine("+--------------------------------------+");

e = e + (1.0 / 120.0); //seis termos
Console.WriteLine("e com seis termos:" + e);
Console.WriteLine("+--------------------------------------+");

e = e + (1.0 / 720.0); //sete termos
Console.WriteLine("e com sete termos:" + e);
Console.WriteLine("+--------------------------------------+");
