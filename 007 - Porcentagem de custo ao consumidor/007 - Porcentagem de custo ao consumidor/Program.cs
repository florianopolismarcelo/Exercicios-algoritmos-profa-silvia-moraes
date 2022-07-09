// See https://aka.ms/new-console-template for more information

/******************************************************************************************
* 07) O custo ao consumidor de um carro novo é a soma do custo de fábrica com a percentagem 
* do distribuidor e dos impostos (aplicados ao custo de fábrica). Supondo que a percentagem 
* do distribuidor seja de 28% e os impostos de 45%, escrever um algoritmo que leia o custo 
* de fábrica de um carro e escreva o custo ao consumidor.
******************************************************************************************/

float imposto = 0, valorFabrica, percentDistribuidor = 0, valorConsumidor ;

Console.WriteLine("Qual o valor de fábrica do automóvel?");
valorFabrica = float.Parse(Console.ReadLine());


percentDistribuidor = (valorFabrica * 28) / 100;
imposto = (valorFabrica * 45) / 100;
valorConsumidor = (valorFabrica + percentDistribuidor + imposto);

Console.WriteLine("O automóvel custará para o consumidor o valor de: R$"+valorConsumidor);



