// See https://aka.ms/new-console-template for more information

/*************************************************************************************
* 01) Construa um algoritmo que, tendo como dados de entrada dois pontos quaisquer 
* no plano, P(x1,y1) e P(x2,y2), escreva a distância entre eles. A fórmula que efetua 
* tal d = √ (X2 - X1)^2 + (Y2 - Y1)^2
*************************************************************************************/

float distancia, valorX1 = 0, valorX2 = 0 , valorY1 = 0, valorY2 = 0;

Console.WriteLine("Informe o valor de X1");
valorX1 = float.Parse(Console.ReadLine());

Console.WriteLine("Informe o valor de X2");
valorX2 = float.Parse(Console.ReadLine());

Console.WriteLine("Informe o valor de Y1");
valorY1 = float.Parse(Console.ReadLine());

Console.WriteLine("Informe o valor de Y2");
valorY1 = float.Parse(Console.ReadLine());

valorX1 = valorX2 - valorX1;
valorY1 = valorY2 - valorY1;

valorX1 = (float)Math.Sqrt(2);
valorY1 = (float)Math.Sqrt(2);

distancia = valorX1 + valorY1;

distancia = (float)Math.Sqrt(2);

Console.WriteLine("A distância entre os dois pontos é: "+distancia);






