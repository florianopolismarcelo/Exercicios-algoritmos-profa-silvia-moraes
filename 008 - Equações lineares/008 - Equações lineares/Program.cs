// See https://aka.ms/new-console-template for more information

/***************************************************************************************************
* 08) Um sistema de equações lineares do tipo:
* ax + by = c
* dx + ey = f   , pode ser resolvido segundo mostra abaixo:
* 
* x = ce - bf/ ae - bd    y = af - cd/ae - bd
* 
* Escreva um algoritmo que lê os coeficientes a,b,c,d,e e f e calcula e mostra os valores de x e y.
***************************************************************************************************/

float a, b, c, d, e, f, x, y;

Console.WriteLine("Informe o valor de: a ");
a = float.Parse(Console.ReadLine());

Console.WriteLine("Informe o valor de: b ");
b = float.Parse(Console.ReadLine());

Console.WriteLine("Informe o valor de: c ");
c = float.Parse(Console.ReadLine());

Console.WriteLine("Informe o valor de: d ");
d = float.Parse(Console.ReadLine());

Console.WriteLine("Informe o valor de: e ");
e = float.Parse(Console.ReadLine());

Console.WriteLine("Informe o valor de: f ");
f = float.Parse(Console.ReadLine());

x = ((c*e) - (b*f)) / ((a*e) - (b*d));
y = ((a*f) - (c*d)) / ((a*e) - (b*d));

Console.WriteLine("O valor de x é: "+x+" e o valor de y é: "+y);
